using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número para a tabuada: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Tabuada do {number}:");
        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }
}
