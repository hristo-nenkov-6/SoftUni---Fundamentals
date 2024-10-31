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
            Family familiy = new Family();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person member = new Person(name, age);
                familiy.AddMember(member);
            }

            Person oldest = familiy.GetOldestMember();
            Console.WriteLine(oldest.Name + " " + oldest.Age);

        }
        class Family
        {
            public List<Person> persons = new List<Person>();
            public void AddMember(Person member)
            {
                persons.Add(member);
            }
            public Person GetOldestMember()
            {
                return persons.MaxBy(p => p.Age);
            }
        }
        class Person
        {
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public string Name { get; set; }
            public int Age { get; set; }
        }
            
    }
}