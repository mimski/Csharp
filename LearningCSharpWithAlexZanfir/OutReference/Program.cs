using System;

namespace OutReference
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 2;

            Console.WriteLine(x);

            Five(x);

            Console.WriteLine(x);

            Six(out x);

            Console.WriteLine(x);

            Double(ref x);

            Console.WriteLine(x);
        }

        static void Five(int a)
        {
            a = 5;

            Console.WriteLine(a);
        }

        static void Six(out int a)
        {
            a = 6;

            Console.WriteLine(a);
        }

        static void Double(ref int a)
        {
            a *= 2;

            Console.WriteLine(a);
        }
    }
}
