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
            string input = string.Empty;
            List<User> users = new List<User>();
            while((input = Console.ReadLine()) != "End")
            {
                string[] arrInp = input.Split(" ").ToArray();
                string name = arrInp[0];
                string ID = arrInp[1];
                int age = int.Parse(arrInp[2]);

                if(!users.Any(user =>  user.ID.Equals(ID)))
                {
                    User user = new User(name, ID, age);
                    users.Add(user);
                }
                else
                {
                    User newUseer = new User(name, ID, age);
                    int index = users.IndexOf(users.Find(user => user.ID.Equals(ID)));
                    users[index] = newUseer;
                }
            }
            foreach(User user in users.OrderBy(user => user.Age))
            {
                Console.WriteLine(user.ToString());
            }
        }
        class User
        {
            public User(string name, string iD, int age)
            {
                Name = name;
                ID = iD;
                Age = age;
            }

            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"{Name} with ID: {ID} is {Age} years old.";
            }
        }
    }
}