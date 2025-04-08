using System;


class Program
{
    static int BuscaBinaria(int[] array, int elemento)
    {
        int inicio = 0, fim = array.Length - 1;
        int resultado = -1;

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;


            if (array[meio] == elemento)
            {
                resultado = meio;
                inicio = meio  + 1;
            }
            else if (array[inicio] < elemento)
            {
                inicio = meio + 1;
            }
            else
            {
                fim = meio - 1;
            }
        }


        return resultado;
    }


    static void Main()
    {

        int[] numeros = { 1, 1, 1, 1, 1, 1, 1 };

        int chave = 1;

        int resultado = BuscaBinaria(numeros, chave);
        Console.WriteLine(resultado != -1 ? $"Primeira ocorrência do elemento {chave} está na posição {resultado + 1}" : "Elemento não encontrado");
    }
}
