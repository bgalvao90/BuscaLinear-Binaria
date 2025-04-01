using System;


class Program
{
    static int CountLinear(int[] array, int elemento)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == elemento)
                count++;
        }
        return count;
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
        Console.Write("Digite o elemento a ser buscado: ");
        int chave = int.Parse(Console.ReadLine());

        int resultado = CountLinear(numeros, chave);
        Console.WriteLine(resultado != 0 ? $"Contagem {resultado}" : "Elemento não encontrado");
    }
}
