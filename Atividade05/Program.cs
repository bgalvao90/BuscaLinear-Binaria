using System;


class Program
{
    static int Multiplo(int[] array, int elemento)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % elemento == 0 )
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
        Console.Write("Digite um elemento para encontrar o primeiro multiplo: ");
        int chave = int.Parse(Console.ReadLine());

        int resultado = Multiplo(numeros, chave);
        Console.WriteLine(resultado != -1 ? $"primeiro multiplo encontrado {resultado}" : "Elemento não encontrado");
    }
}
