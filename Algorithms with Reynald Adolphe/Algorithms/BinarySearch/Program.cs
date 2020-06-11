using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 78;
            int[] array = new int[] { 11, 12, 43, 54, 57, 59, 62, 78 };

            Console.WriteLine("Our array contains: ");
            Array.ForEach(array, x => Console.Write(x + " "));

            Console.Write($"\n\nThe result of a binary search for {theValue} is: {BinarySearch(array, theValue)} (index)");
            Console.WriteLine();
        }

        /// <summary>
        /// a = array
        /// x = what we are searching
        /// p = first index
        /// q = midpoint
        /// r = last index
        /// </summary>
        public static int BinarySearch(int[] a, int x)
        {
            // Step 1. Initialize the variables
            int p = 0; // beginning of the range 
            int r = a.Length - 1; // the end of the range aka last slot

            // Step 2. Search for our value
            while (p <= r) // when true, we are still in the range
            {
                int q = (p + r) / 2; // find the midpoint
                if (x < a[q])
                {
                    r = q - 1; // set r to midpoint. We narrow to 1st half of the array in the case x is less the data in slot q
                }
                else if (x > a[q])
                {
                    p = q + 1; // the opposite occurs. We bring p to the right of the array
                }
                else
                {
                    return q;
                }
            }

            // Step 3. Indicate not found
            return -1;
        }
    }
}
