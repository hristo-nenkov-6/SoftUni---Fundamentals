using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> listedInput = input.Split(" ").ToList();

                string firstName = listedInput[0];
                string lastName = listedInput[1];
                int age = int.Parse(listedInput[2]);
                string homeTown = listedInput[3];

                Students student = students.FirstOrDefault(s => s.FirstName == firstName &&
                                                            s.LastName == lastName);

                if(student == null)
                {
                    students.Add(new Students(firstName, lastName, age, homeTown));
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
            }

            string wantedCity = Console.ReadLine();

            List<Students> filteredStudents = students
                                                .Where(student => student.HomeTown == wantedCity)
                                                .ToList();

            foreach (Students student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        class Students
        {
            public Students(string firstName, string lastName, int age, string homeTown)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                HomeTown = homeTown;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
    }

}