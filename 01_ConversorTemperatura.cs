using System;

class Program
{
    static double CelsiusFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    static double FahrenheitCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static void Main(string[] args)
    {
        Console.Write("Escolha a unidade de origem (C/F): ");
        char escolha = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        Console.Write("Digite a temperatura: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        if (escolha == 'C')
        {
            double convertedTemp = CelsiusFahrenheit(temperature);
            Console.WriteLine($"{temperature}°C equivale a {convertedTemp}°F");
        }
        else if (escolha == 'F')
        {
            double convertedTemp = FahrenheitCelsius(temperature);
            Console.WriteLine($"{temperature}°F equivale a {convertedTemp}°C");
        }
    }
}
