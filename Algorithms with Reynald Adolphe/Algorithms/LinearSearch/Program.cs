using System;

/* Searches target value within a list. 
 * Checks each element of the list until match found or reaches end.*/
namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 7;
            int[] array = new int[] { 1, 4, 5, 7, 9, 22 };

            Console.WriteLine("The array contains:");
            Array.ForEach(array, x => Console.Write(x + " "));

            Console.WriteLine($"\n\nThe result of a linear search for {theValue} is: {LinearSearch(array, theValue)}");
        }

        static int LinearSearch(int[] a, int x)
        {
            int answer = 1;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }

            return answer;
        }
    }
}
