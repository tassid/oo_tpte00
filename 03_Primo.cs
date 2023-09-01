using System;

class Program
{
    static bool EhPrimo(int num)
    {
        if (num <= 1)
            return false;
        if (num <= 3)
            return true;

        if (num % 2 == 0 || num % 3 == 0)
            return false;

        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
                return false;
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (EhPrimo(num))
            Console.WriteLine($"{num} é primo.");
        else
            Console.WriteLine($"{num} não é primo.");
    }
}
