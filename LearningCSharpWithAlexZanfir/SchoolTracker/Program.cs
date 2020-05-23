using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new int[] { 70, 77, 45, 88, 53 };

            studentGrades[0] = 80;
            studentGrades[1] = 90;
            studentGrades[4] = 77;

            foreach (var studentGrade in studentGrades)
            {
                Console.WriteLine(studentGrade);
            }
        }
    }
}
