using System;


class Program
{
    static int BuscaLinear(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int ultimo = array[array.Length - 1];
            if (array[i] == ultimo)
                return array[i];
        }
        return -1;
    }

    static void Main()
    {
        Console.Write("Digite a quantidade de elementos que deseja: ");
        int n = int.Parse(Console.ReadLine());
        int[] numeros = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o elemento {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int resultado = BuscaLinear(numeros);
        Console.WriteLine($"A última ocorrência de um elemento é: {resultado}" );
    }
}
