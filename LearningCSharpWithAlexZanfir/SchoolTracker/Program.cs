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

                student.Name = Util.Console.Ask("Student Name: ");
                
                student.Grade = int.Parse(Util.Console.Ask("Student Grade: "));
                
                student.Birthday = Util.Console.Ask("Student Birthday: ");
               
                student.Address = Util.Console.Ask("Student Address: ");

                student.Phone = int.Parse(Util.Console.Ask("Student Phone: "));

                students.Add(student);
                Student.Count++;
                Console.WriteLine("Student count {0}", Student.Count);

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
        static public int Count = 0;

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
