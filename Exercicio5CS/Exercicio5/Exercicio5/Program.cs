using System;

class Program
{
    static void Main(string[] args)
    {
        string original, invertida = "";
        Console.WriteLine("Digite uma palavra:");
        original = Console.ReadLine();
        for (int i = original.Length - 1; i >= 0; i--)
        {
            invertida += original[i];
        }
        Console.WriteLine("Palavra invertida: {0}", invertida);
    }
}
