using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                var student = new Student();
                Console.Write("Student Name: ");
                student.Name = Console.ReadLine();

                Console.Write("Student Grade: ");
                student.Grade = int.Parse(Console.ReadLine());

                Console.Write("Student Birthday: ");
                student.Birthday = Console.ReadLine();

                Console.Write("Student Address: ");
                student.Address = Console.ReadLine();

                Console.Write("Student Phone: ");
                student.Phone = int.Parse(Console.ReadLine());

                students.Add(student);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
        }
    }

    class Student
    {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private int phone;

        public int Phone
        {
            set { phone = value; }
        }

        public void SetPhone(int number)
        {
            phone = number;
        }
    }
}
