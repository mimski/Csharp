using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    enum School
    {
        Hogwarts,
        Harvard,
        MIT
    }

    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            Import();

            var adding = true;

            while (adding)
            {
                try
                {
                    var student = new Student();

                    student.Name = Util.Console.Ask("Student Name: ");

                    student.Grade = Util.Console.AskInt("Student Grade: ");

                    student.School = (School) Util.Console.AskInt("School Name (type the corresponding number): \n 0 - Hogwarts \n 1 - Harvard \n 2 - MIT");

                    student.Birthday = Util.Console.Ask("Student Birthday: ");

                    student.Address = Util.Console.Ask("Student Address: ");

                    student.Phone = Util.Console.AskInt("Student Phone: ");

                    students.Add(student);
                    Student.Count++;
                    Console.WriteLine("Student count {0}", Student.Count);

                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                    {
                        adding = false;
                    }

                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error adding student");
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }

            Exports();
        }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "birthday", "address", 123456);
            Console.WriteLine("Name: {0}, Grade: {1}", importedStudent.Name, importedStudent.Grade);
        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case School.Hogwarts:
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                    case School.Harvard:
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    case School.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;
                }
            }
        }
    }

    class Member
    {
        public string Name;
        public string Address;
        protected int phone;

        public int Phone
        {
            set { phone = value; }
        }
    }

    class Student : Member
    {
        static public int Count = 0;

        public int Grade;
        public string Birthday;
        public School School;

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            this.Name = name;
            this.Grade = grade;
            this.Birthday = birthday;
            this.Address = address;
            this.Phone = phone;
        }
    }

    class Teacher : Member
    {
        public string Subject;
    }
}
