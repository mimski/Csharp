using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack theStack = new Stack(4);

            theStack.Push("Star wars");
            theStack.Push("Titanic");
            theStack.Push("Jaws");
            theStack.Push("Rocky");
            theStack.Push("Jaws 2");

            Console.WriteLine("============== \nAbout to peek:");
            Console.WriteLine(theStack.Peek() + "is as the top of the stack");

            Console.WriteLine("============== \nThe Stack contains:");

            while (!theStack.IsEmpty())
            {
                string movie = theStack.Pop();
                Console.WriteLine(movie);
            }
        }
    }

    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void Push(string m)
        {
            if (IsFull())
            {
                Console.WriteLine("This stack is full");
            }
            else
            {
                top++;
                stackArray[top] = m;
            }
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty.");
                return "--";
            }
            else
            {
                int old_top = top;
                top--;
                return stackArray[old_top];
            }
        }

        public string Peek()
        {
            return stackArray[top];
        }

        private bool IsFull()
        {
            return (maxSize - 1 == top);
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }
    }
}
