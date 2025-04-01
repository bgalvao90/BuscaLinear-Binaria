using System;


class Program
{
    static int BuscaLinearString(string[] array, string elemento)
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
        string[] nomes = new string [n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o elemento {i + 1}: ");
            nomes[i] = Console.ReadLine();
        }
        Console.Write("Digite o elemento a ser buscado: ");
        string chave = Console.ReadLine();

        int resultado = BuscaLinearString(nomes, chave);
        Console.WriteLine(resultado != -1 ? $"Elemento encontrado no índice: {resultado + 1}" : "Elemento não encontrado");
    }
}
