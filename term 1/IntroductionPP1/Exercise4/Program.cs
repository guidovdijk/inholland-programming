using System;

namespace Exercise4
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int age = int.Parse(input);

            bool tooOld = (age > 65);

            if (tooOld)
            {
                Console.WriteLine("your age is: {0}. Your're too old", age);
            } else
            {
                Console.WriteLine("your age is: {0}. Your're not too old", age);
            }
            // wait for user to press a key
            Console.ReadKey();
        }
    }
}
