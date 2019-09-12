using System;

namespace Exercise3
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int score = 200;
            int level = 3;
            int nItems = 4;
            int score_new, level_new;
            // increase score and level

            // var++ increases the new value and remembers the old one
            // ++var doesn't remember the old value and updates both
            score_new = score++;
            level_new = ++level;
            Console.WriteLine("Score (old): {0}, score (new): {1}", score, score_new);
            Console.WriteLine("level (old): {0}, level (new): {1}", level, level_new);
            nItems += 5;
            Console.WriteLine("number of items: {0}", nItems);
            // wait for user to press a key
            Console.ReadKey();
        }
    }
}
