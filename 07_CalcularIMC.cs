using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu peso (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite sua altura (m): ");
        double height = Convert.ToDouble(Console.ReadLine());

        double imc = weight / (height * height);

        Console.WriteLine($"Seu IMC é: {imc:F2}");

        if (imc < 18.5)
            Console.WriteLine("Abaixo do peso");
        else if (imc < 24.9)
            Console.WriteLine("Peso normal");
        else if (imc < 29.9)
            Console.WriteLine("Sobrepeso");
        else
            Console.WriteLine("Obeso");
    }
}
