using System;

class Program
{
    static bool EhPalindromo(string input)
    {
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
                return false;
            left++;
            right--;
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite uma palavra ou frase: ");
        string input = Console.ReadLine().ToLower().Replace(" ", "");

        if (EhPalindromo(input))
            Console.WriteLine("É um palíndromo.");
        else
            Console.WriteLine("Não é um palíndromo.");
    }
}
