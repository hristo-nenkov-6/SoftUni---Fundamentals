using System;
using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                List<string> input = Console.ReadLine().Split(" ").ToList();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Student std = new Student(firstName, lastName, grade);
                students.Add(std);
            }
            foreach(Student student in students.OrderByDescending(student => student.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }

        class Student
        {
            public Student(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;     
                Grade = grade;
            }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public double Grade { get; set; }
        }
    }
}