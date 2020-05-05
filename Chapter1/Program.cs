using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Hideyuki Ide",
                Birthday = new DateTime(1970, 04, 01),
                Grade = 3,
                ClassNumber = 2,
            };
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Birthday: " + student.Birthday);
            Console.WriteLine("Grade: " + student.Grade);
            Console.WriteLine("ClassNumber: " + student.ClassNumber);

            Person person = student;
        }
    }
}
