using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 1;

            while (count <= 10)
            {
                Console.WriteLine(count);
                count++;
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            #region Challenge: Loop Counting
            /* Count from 1 to 10 
             * and then back to 1, 
             * and repeat five times
             * Do not use if statements
             */

            for (int i = 1; i <= 5; i++)
            {
                for (int x = 0; x <= 10; x++)
                {
                    Console.WriteLine(x);
                }
                for (int y = 10; y >= 1; y--)
                {
                    Console.WriteLine(y);
                }
            }
            #endregion
        }
    }
}
