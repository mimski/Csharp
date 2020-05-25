using System;

namespace Survey
{
    class Program
    {
        class Data
        {
            public string Name;
            public int Age;
            public string Month;

            public void Display()
            {
                Console.WriteLine("Your name is: {0}", Name);
                Console.WriteLine("Your age is: {0}", Age);
                Console.WriteLine("Your birth month is: {0}", Month);

                // Zodiac accuracy is not the biggest concern for this exercise
                if (Month == "march")
                {
                    Console.WriteLine("you are an Aries");
                }
                else if (Month == "april")
                {
                    Console.WriteLine("you are a Taurus");
                }
                else if (Month == "may")
                {
                    Console.WriteLine("you are a Gemini");
                }
            }
        }

        public static event Action Posted;

        static void Main(string[] args)
        {
            var stats = new Stats();
            stats.Start();

            var data = new Data();

            Console.WriteLine("What is your name?");
            data.Name = TryAnswer();

            Console.WriteLine("What is your age?");
            data.Age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born in?");
            data.Month = TryAnswer();

            if (Posted != null)
            {
                Posted();
            }

            data.Display();
        }

        static string TryAnswer()
        {
            var input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }

            return input;
        }
    }
}
