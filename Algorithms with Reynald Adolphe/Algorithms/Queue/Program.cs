using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue theQueue = new Queue(5);

            theQueue.Insert(1000);
            theQueue.Insert(10);
            theQueue.Insert(20);
            theQueue.Insert(30);
            theQueue.View();

            Console.WriteLine("Front of queue is " + theQueue.PeekFront());

            Console.WriteLine("About to remove item from queue");
            theQueue.Remove();

            Console.WriteLine("Front of queue is " + theQueue.PeekFront());
        }
    }

    public class Queue
    {
        private int maxSize;
        private long[] myQueue;
        private int front;
        private int rear;
        private int items;

        public Queue(int size)
        {
            maxSize = size;
            myQueue = new long[size];
            front = 0;
            rear = -1;
            items = 0;
        }

        public void Insert(long j)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                if (rear == maxSize - 1)
                {
                    rear = -1;
                }

                rear++;
                myQueue[rear] = j;
                items++;
            }
        }

        public long Remove()
        {
            long temp = myQueue[front];
            front++;

            if (front == maxSize)
            {
                front = 0;
            }

            return temp;
        }

        public long PeekFront()
        {
            return myQueue[front];
        }

        public void View()
        {
            Console.Write("[ ");
            for (int i = 0; i < myQueue.Length; i++)
            {
                Console.Write(myQueue[i] + " ");
            }
            Console.WriteLine("]");
        }

        public bool IsEmpty()
        {
            return (items == 0);
        }

        private bool IsFull()
        {
            return (items == maxSize);
        }
    }
}
