using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");

            string input = Console.ReadLine();

            int age = int.Parse(input);

            age++;

            string output = age.ToString();

            Console.WriteLine("Next year you will be {0} years old", output);

            Console.ReadKey();
        }
    }
}
