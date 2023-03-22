using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.Write("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int c = 0;

        while (c < num)
        {
            c = a + b;
            a = b;
            b = c;
        }

        if (c == num)
        {
            Console.WriteLine(num + " pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine(num + " não pertence à sequência de Fibonacci.");
        }
    }
}