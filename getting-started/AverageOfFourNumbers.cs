using System;

/*Write program to calculate and display 
the average of four integer numbers entered by the user.*/

class AverageOfFourNumbers
{
    static void Main()
    {
        int num1, num2, num3, num4;

        Console.Write("Enter number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number: ");
        num3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number: ");
        num4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Average = {0}", (num1 + num2 + num3 + num4) / 4);
    }
}
