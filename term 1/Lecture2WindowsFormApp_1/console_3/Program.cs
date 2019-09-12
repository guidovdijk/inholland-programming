using System;

namespace console_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double seconds = getValue("enter number of seconds: ");

            TimeSpan time = TimeSpan.FromSeconds(seconds);

            string str = time.ToString(@"hh\:mm\:ss");

            Console.WriteLine(str);
        }
        public static double getValue(string text)
        {
            Console.Write(text);

            string input = Console.ReadLine();
            return double.Parse(input);
        }
    }
}
