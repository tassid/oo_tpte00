using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o capital inicial: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a taxa de juros (em decimal): ");
        double interestRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o número de períodos: ");
        int periods = Convert.ToInt32(Console.ReadLine());

        double finalAmount = principal * Math.Pow(1 + interestRate, periods);

        Console.WriteLine($"Montante final: {finalAmount:C}");
    }
}
