using System;

/*Write a program to print the result of adding, subtracting,
multiplying and dividing two numbers typed by the user*/

class BasicCalculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
        Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
    }
}
