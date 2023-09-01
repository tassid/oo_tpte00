using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o capital inicial: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a taxa de juros (em decimal): ");
        double taxa = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o número de períodos: ");
        int tempo = Convert.ToInt32(Console.ReadLine());

        double total = principal * Math.Pow(1 + taxa, tempo);

        Console.WriteLine($"Montante final: {total:C}");
    }
}
