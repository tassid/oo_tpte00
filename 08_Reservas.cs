using System;

class Program
{
    static void Main(string[] args)
    {
        const int totalLugares = 50;
        bool[] lugar = new bool[totalLugares];

        while (true)
        {
            Console.Write("Digite o número do assento (1 a 50) ou 'sair' para finalizar: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "sair")
                break;

            int lugarNumero = Convert.ToInt32(input) - 1;

            if (lugarNumero < 0 || lugarNumero >= totalLugares)
            {
                Console.WriteLine("Número de assento inválido.");
                continue;
            }

            if (lugar[lugarNumero])
            {
                Console.WriteLine("Assento já reservado.");
            }
            else
            {
                lugar[lugarNumero] = true;
                Console.WriteLine($"Assento {lugarNumero + 1} reservado.");
            }
        }
    }
}
