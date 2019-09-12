using System;

namespace console_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const double vat = 21.00;
            Console.Write("Enter a price:");

            string input = Console.ReadLine();

            double price = double.Parse(input);

            double vatPrice = price * (vat/100);

            double total = price + vatPrice;

            Console.WriteLine($"price: {input}, VAT: {vat}, Total: {total}");

        }
    }
}
