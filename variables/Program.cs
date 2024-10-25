using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int         i = 90;
            float       f = 42.42f;
            decimal     d = 33.01m;
            bool        b = true;
            char        c = 'c';
            string      str = "hello!";
            var         x = "20";
            var         y = 202;
            string[]    strs = {"hey", "hadi", "how", "you", "doing?"};

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", i, f, d, b, c, str, x, y);
            Console.WriteLine(strs[4].Length);
        }
    }
}