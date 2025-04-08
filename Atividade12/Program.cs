
using System;


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

        Array.Sort(numeros);
        Console.Write("Digite o elemento para quantas vezes ele aparece: ");
        int chave = int.Parse(Console.ReadLine());


        int resultado = BuscaBinaria(numeros, chave);
        if (resultado != -1)
        {
            int contagem = 1;
            int i = resultado - 1;
            while (i >= 0 && numeros[i] == chave)
            {
                contagem++;
                i--;
            }
            i = resultado + 1;
            while (i < numeros.Length && numeros[i] == chave)
            {
                contagem++;
                i++;
            }
            Console.WriteLine(resultado != -1 ? $"Elemento foi encontrado {contagem}x" : "Elemento não encontrado");
        }
    }
}

