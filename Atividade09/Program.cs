using System;


class Program
{
    static int Palavraemtexto(string[] array, string palavra)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == palavra)
            {
                return i + 1; 
            }
        }
        return -1; 
    }

    static void Main()
    {
        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine();
        Console.Write("Digite a palavra a ser buscada: ");
        string busca = Console.ReadLine();

        string[] palavras = texto.Split(' ');

        int resultado = Palavraemtexto(palavras, busca);
        Console.WriteLine(resultado != -1 ? $"Índice: {resultado}" : "Elemento não encontrado");
    }
}
