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
            PayRoll payRoll = new PayRoll();
            payRoll.PayAll();

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

            ShowGrade("");

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

        static void ShowGrade(string name)
        {
            //var found = students.Find(predicate);

            //var found = students.Find(student =>
            //{
            //    return (student.Name == "Jim");
            //});

            var found = students.Find(student => student.Name == "Jim");

            Console.WriteLine("{0}'s Grade: {1}", found.Name, found.Grade);
        }

        //static bool predicate(Student student)
        //{
        //    return (student.Name == "Jim");

        //    //if (student.Name == "Jim")
        //    //{
        //    //    return true;
        //    //}
        //    //else
        //    //{
        //    //    return false;
        //    //}
        //}
    }

    class Member
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }

    class Student : Member
    {
        static public int Count { get; set; } = 0;

        public int Grade { get; set; }
        public string Birthday { get; set; }
        public School School { get; set; }

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

   
}
