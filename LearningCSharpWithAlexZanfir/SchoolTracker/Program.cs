﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Import();

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

        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "birthday", "address", 123456);
            Console.WriteLine("Name: {0}, Grade: {1}", importedStudent.Name, importedStudent.Grade);
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
