using System;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reg = @"\s\b[A-Za-z]+[A-Za-z1-9\.\-_]+@[A-Za-z]+[\.\-][A-Za-z]+[A-Za-z\.\-]+\b";
            Regex regex = new Regex(reg);
            var mathedEmails = regex.Matches(input);

            foreach (var email in mathedEmails)
            {
                string output = email.ToString().Trim();
                Console.WriteLine(output);
            }
        }
    }
}
/*
 * Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.

 */