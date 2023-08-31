using System;

class Program
{
    static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static void Main(string[] args)
    {
        Console.Write("Escolha a unidade de origem (C/F): ");
        char choice = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        Console.Write("Digite a temperatura: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        if (choice == 'C')
        {
            double convertedTemp = CelsiusToFahrenheit(temperature);
            Console.WriteLine($"{temperature}°C equivale a {convertedTemp}°F");
        }
        else if (choice == 'F')
        {
            double convertedTemp = FahrenheitToCelsius(temperature);
            Console.WriteLine($"{temperature}°F equivale a {convertedTemp}°C");
        }
    }
}
