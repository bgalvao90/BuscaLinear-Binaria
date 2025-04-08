using System;

class Program
{
    static int NumeroMaisProximo(int[] array, int x)
    {
        int inicio = 0, fim = array.Length - 1;
        int maisProximo = array[0];

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;

            if (Math.Abs(array[meio] - x) < Math.Abs(maisProximo - x))
            {
                maisProximo = array[meio];
            }
            else if (Math.Abs(array[meio] - x) == Math.Abs(maisProximo - x) && array[meio] < maisProximo)
            {
                maisProximo = array[meio];
            }

            if (array[meio] < x)
            {
                inicio = meio + 1;
            }
            else if (array[meio] > x)
            {
                fim = meio - 1;
            }
            else
            {
                return array[meio];
            }
        }

        return maisProximo;
    }

    static void Main()
    {
        int[] numeros = { 1, 3, 5, 7, 9, 11, 13 };
        int x = 6;

        int resultado = NumeroMaisProximo(numeros, x);
        Console.WriteLine($"O número mais próximo de {x} é {resultado}");
    }
}
