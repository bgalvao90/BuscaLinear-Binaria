using System;


class Program
{
    static int Par(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
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
        

        int resultado = Par(numeros);
        Console.WriteLine(resultado != -1 ? $"primeiro par encontrado {resultado}" : "Elemento não encontrado");
    }
}
