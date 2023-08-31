using System;

class Program
{
    static void Main(string[] args)
    {
        const int totalSeats = 50;
        bool[] seats = new bool[totalSeats];

        while (true)
        {
            Console.Write("Digite o número do assento (1 a 50) ou 'sair' para finalizar: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "sair")
                break;

            int seatNumber = Convert.ToInt32(input) - 1;

            if (seatNumber < 0 || seatNumber >= totalSeats)
            {
                Console.WriteLine("Número de assento inválido.");
                continue;
            }

            if (seats[seatNumber])
            {
                Console.WriteLine("Assento já reservado.");
            }
            else
            {
                seats[seatNumber] = true;
                Console.WriteLine($"Assento {seatNumber + 1} reservado.");
            }
        }
    }
}
