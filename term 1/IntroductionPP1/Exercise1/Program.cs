using System;

namespace Exercise1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name;
            string age;

            name = Console.ReadLine(); 

            age = Console.ReadLine();

            Console.Write("Your name is: {0}", name);
            Console.Write("Your age is: {0}", age);

            Console.ReadKey();
        }
    }
}
