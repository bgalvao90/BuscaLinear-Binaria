using System;
using System.Xml.Linq;


class Program
{
    static int Maior(int[] array)
    {
        int maior = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maior)
                maior = array[i];
        }
        return maior;
    }

    static int Menor(int[] array)
    {
        int menor = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < menor)
                menor = array[i];
        }
        return menor;
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

        int maior = Maior(numeros);
        int menor = Menor(numeros);
        Console.WriteLine($"Maior elemento: {maior}, menor elemento: {menor}");
    }
}
