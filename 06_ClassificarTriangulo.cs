using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o comprimento do lado 1: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o comprimento do lado 2: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o comprimento do lado 3: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        if (lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado3 + lado1 > lado2)
        {
            if (lado1 == lado2 && lado2 == lado3)
                Console.WriteLine("Triângulo equilátero");
            else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
                Console.WriteLine("Triângulo isósceles");
            else
                Console.WriteLine("Triângulo escaleno");
        }
        else
        {
            Console.WriteLine("Não forma um triângulo.");
        }
    }
}
