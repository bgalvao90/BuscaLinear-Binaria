
using System;
using System.Diagnostics.Metrics;


class Program
{
    static int BuscaBinaria(int[] array,int tamanho,  int elemento)
    {
        int inicio = 0, fim = tamanho - 1;

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;

            if (array[meio] < elemento)
            {
                inicio = meio + 1;
            }
            else
            {
                fim = meio - 1;
            }
        }
        return inicio;
    }

    static void Main()
    {
        Console.Write("Digite a quantidade de elementos que deseja: ");
        int n = int.Parse(Console.ReadLine());
        int[] numeros = new int[n];
        int tamanhoAtual = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o elemento {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());

            int posicao = BuscaBinaria(numeros, tamanhoAtual, numero);

            for (int j = tamanhoAtual; j > posicao; j--)
            {
                numeros[j] = numeros[j - 1];
            }
            numeros[posicao] = numero;
            tamanhoAtual++;
        }
        Console.WriteLine("Vetor ordenado:");
        for (int i = 0; i < tamanhoAtual; i++)
        {
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();

    }
}

