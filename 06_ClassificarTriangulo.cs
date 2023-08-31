using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o comprimento do lado 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o comprimento do lado 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o comprimento do lado 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        if (side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2)
        {
            if (side1 == side2 && side2 == side3)
                Console.WriteLine("Triângulo equilátero");
            else if (side1 == side2 || side2 == side3 || side3 == side1)
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
