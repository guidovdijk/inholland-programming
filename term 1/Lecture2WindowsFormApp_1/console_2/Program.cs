using System;

namespace console_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double number1 = getValue("enter first number: ");
            double number2 = getValue("enter second number: ");
            double number3 = getValue("enter third number: ");

            double total = (number1 + number2 + number3) / 3;

            Console.WriteLine($"The average is: {total.ToString()}");
        }
        public static double getValue(string text)
        {
            Console.Write(text);

            string input = Console.ReadLine();
            return double.Parse(input);
        }
    }
}
