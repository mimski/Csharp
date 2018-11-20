using System;

/*Write a program to ask the user for a number 
 and display its multiplication table.*/

class MultiplicationTable
{
    static void Main()
    {
        Console.Write("Enter a number: ");

        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} x 0 = {1}", x, x * 0);
        Console.WriteLine("{0} x 1 = {1}", x, x * 1);
        Console.WriteLine("{0} x 2 = {1}", x, x * 2);
        Console.WriteLine("{0} x 3 = {1}", x, x * 3);
        Console.WriteLine("{0} x 4 = {1}", x, x * 4);
        Console.WriteLine("{0} x 5 = {1}", x, x * 5);
        Console.WriteLine("{0} x 6 = {1}", x, x * 6);
        Console.WriteLine("{0} x 7 = {1}", x, x * 7);
        Console.WriteLine("{0} x 8 = {1}", x, x * 8);
        Console.WriteLine("{0} x 9 = {1}", x, x * 9);
        Console.WriteLine("{0} x 10 = {1}", x, x * 10);
    }
}
