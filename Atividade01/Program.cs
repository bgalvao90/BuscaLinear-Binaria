using System;


class Program
{
    static int BuscaLinear(int[] array, int elemento)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == elemento)
                return i;
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
        Console.Write("Digite o elemento a ser buscado: ");
        int chave = int.Parse(Console.ReadLine());

        int resultado = BuscaLinear(numeros, chave);
        Console.WriteLine(resultado != -1 ? $"Elemento encontrado na posição {resultado + 1}" : "Elemento não encontrado");
    }
}
