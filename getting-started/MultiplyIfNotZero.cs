using System;

/*Write a program to ask the user for a number. 
 If it is not zero, then ask for a second number 
 and display their product. If it is zero, then display 0*/

class MultiplyIfNotZero
{
    static void Main()
    {
        int x, y;

        Console.Write("Enter number: ");
        x = Convert.ToInt32(Console.ReadLine());

        if (x != 0)
        {
            Console.Write("Enter number: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} x {1} = {2}", x, y, x * y);
        }
        if (x == 0)
        {
            Console.WriteLine(x);
        }
    }
}
