using System;
using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;


namespace ConsoleApp3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            List<Emplyee> employees = new List<Emplyee>();
            List<string> departments = new List<string>();
            int departmentCount = 0;

            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string name = input[0];
                string department = input[2];
                double salary = double.Parse(input[1]);

                Emplyee newEmp = new Emplyee(name, salary, department);
                employees.Add(newEmp);

                if(!departments.Contains(department))
                {
                    departmentCount++;
                    departments.Add(department);
                }
            }

            double max = 0;
            string bestDepartment = "";
            for(int i = 0; i < departmentCount; i++)
            {
                double sumOfSalary = 0;
                int br = 0;
                foreach(Emplyee emplyee in employees.Where(department => department.Department.Equals(departments[i])))
                {
                    sumOfSalary += emplyee.Salary;
                    br++;
                }
                if(sumOfSalary / br >= max)
                {
                    max = sumOfSalary / br;
                    bestDepartment = departments[i];
                }
            }

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");
            foreach (Emplyee empl in employees.Where(department => department.Department.Equals(bestDepartment))
                                               .OrderByDescending(salary => salary.Salary))
            {
                Console.WriteLine($"{empl.Name} {empl.Salary:f2}");
            }
        }
        class Emplyee
        {
            public Emplyee(string name, double salary, string department)
            {
                Name = name;
                Department = department;
                Salary = salary;
            }
            public string Name { get; set; }
            public string Department { get; set; }
            public double Salary { get; set; }
        }
    }
}