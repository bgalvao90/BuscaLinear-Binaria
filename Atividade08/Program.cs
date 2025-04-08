using System;
using System.Net.Http.Headers;


class Program
{
    static int BuscaSentinela(int[] array, int chave)
    {
        int ultimo;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == chave)
            {
                ultimo = chave;
                return ultimo;
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
        Console.Write("Digite o elemento que deseja buscar: ");
        int chave = int.Parse(Console.ReadLine());


        int resultado = BuscaSentinela(numeros, chave);

        foreach (int numero in numeros)
        {
            if (numero != chave)
            {
                Console.Write($"{numero} ");
            }
        }
        Console.WriteLine( resultado !=  - 1 ?$"{resultado}" : " ");
    }
    
}
