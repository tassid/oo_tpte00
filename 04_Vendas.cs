using System;

class Program
{
    static void Main(string[] args)
    {
        int totalItems = 0;
        double totalValor = 0;

        while (true)
        {
            Console.Write("Nome do produto (ou 'sair' para finalizar): ");
            string nomeProduto = Console.ReadLine();

            if (nomeProduto.ToLower() == "sair")
                break;

            Console.Write("Quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço por unidade: ");
            double precoPorUnidade = Convert.ToDouble(Console.ReadLine());

            double subtotal = quantidade * precoPorUnidade;
            Console.WriteLine($"Subtotal: {subtotal}");

            totalItems += quantidade;
            totalValor += subtotal;
        }

        Console.WriteLine($"Total de itens vendidos: {totalItems}");
        Console.WriteLine($"Total da venda: {totalValor:C}");
    }
}
