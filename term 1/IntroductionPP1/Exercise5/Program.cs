using System;

namespace Exercise5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            int number1 = rnd.Next(101, 10000);
            int number2 = rnd.Next(101, 10000);
            int number3 = rnd.Next(101, 10000);
            int number4 = rnd.Next(101, 10000);

            Console.WriteLine("{0} + {1} + {2} + {3} =", number1, number2, number3, number4);

            int numbersCombined = (number1 + number2 + number3 + number4);

            Console.WriteLine(numbersCombined.ToString());

            Console.ReadKey();
        }
    }
}
