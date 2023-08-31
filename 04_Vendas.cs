using System;

class Program
{
    static void Main(string[] args)
    {
        int totalItems = 0;
        double totalAmount = 0;

        while (true)
        {
            Console.Write("Nome do produto (ou 'sair' para finalizar): ");
            string productName = Console.ReadLine();

            if (productName.ToLower() == "sair")
                break;

            Console.Write("Quantidade: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço por unidade: ");
            double pricePerUnit = Convert.ToDouble(Console.ReadLine());

            double subtotal = quantity * pricePerUnit;
            Console.WriteLine($"Subtotal: {subtotal}");

            totalItems += quantity;
            totalAmount += subtotal;
        }

        Console.WriteLine($"Total de itens vendidos: {totalItems}");
        Console.WriteLine($"Total da venda: {totalAmount:C}");
    }
}
