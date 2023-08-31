using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu peso (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite sua altura (m): ");
        double height = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / (height * height);

        Console.WriteLine($"Seu IMC é: {bmi:F2}");

        if (bmi < 18.5)
            Console.WriteLine("Abaixo do peso");
        else if (bmi < 24.9)
            Console.WriteLine("Peso normal");
        else if (bmi < 29.9)
            Console.WriteLine("Sobrepeso");
        else
            Console.WriteLine("Obeso");
    }
}
