
using System;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;


class Program
{
    static int BuscaBinaria(string[] array, string elemento)
    {
        int inicio = 0, fim = array.Length - 1;

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;
            int comparar = string.Compare(array[meio], elemento, StringComparison.OrdinalIgnoreCase);

            if (comparar == 0)
            {
                return meio;
            }
            else if (comparar < 0)
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
        string[] dicionario = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o elemento {i + 1}: ");
            dicionario[i] = Console.ReadLine();
        }

        Array.Sort(dicionario, StringComparer.OrdinalIgnoreCase);
        Console.Write("Digite o elemento para verificar sua existência: ");
        string chave = Console.ReadLine();
        int resultado = BuscaBinaria(dicionario, chave);

        if (resultado != -1)
        {
            Console.WriteLine($"Elemento encontrado na posição {resultado + 1}");
        }
        else
        {
            Console.WriteLine("Elemento não encontrado");
        }
    }
}

