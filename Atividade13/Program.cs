
using System;
using System.Diagnostics.Metrics;


class Program
{
    static int BuscaBinaria(int[] array, int elemento)
    {
        int inicio = 0, fim = array.Length - 1;

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;

            if (array[meio] == elemento)
            {
                return meio;
            }

            if (array[meio] < elemento)
            {
                inicio = meio + 1;
            }
            else
            {
                fim = meio - 1;
            }
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

        Console.Write("Digite o elemento para para saber os números menores que ele: ");
        int chave = int.Parse(Console.ReadLine());

        int resultado = BuscaBinaria(numeros, chave);
        Console.Write( $"Elemento encontrado menor que {chave}: ");
        foreach (int numero in numeros)
        {
            if (numero < chave)
            {
                Console.Write($"{numero} ");
            }

        }
        Console.Write($"elemento não encontrado!");

    }
}

