using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número para a tabuada: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Tabuada do {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}
