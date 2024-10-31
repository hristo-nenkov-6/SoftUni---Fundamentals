using System;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = string.Empty;
            Dictionary<string, char> morse = new Dictionary<string, char>();
            morse.Add(".-",'a');
            morse.Add("-...", 'b');
            morse.Add("-.-.",'c');
            morse.Add("-..",'d');
            morse.Add(".",'e');
            morse.Add("..-.",'f');
            morse.Add("--.",'g');
            morse.Add( "....",'h');
            morse.Add("..",'i');
            morse.Add(".---",'j');
            morse.Add("-.-",'k');
            morse.Add(".-..",'l');
            morse.Add("--",'m');
            morse.Add("-.",'n');
            morse.Add("---",'o');
            morse.Add(".--.",'p');
            morse.Add("--.-",'q');
            morse.Add(".-.",'r');
            morse.Add("...",'s');
            morse.Add("-",'t');
            morse.Add("..-",'u');
            morse.Add("...-",'v');
            morse.Add(".--",'w');
            morse.Add("-..-",'x');
            morse.Add("-.--",'y');
            morse.Add("--..",'z');

            StringBuilder input = new StringBuilder(Console.ReadLine());
            string[] words = input.ToString().Split('|').ToArray();
            foreach(string word in words)
            {
                string[] letters = word.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray(); 
                foreach(string letter in letters)
                {
                    char a = morse[letter];
                    output += a;
                }
                output += " ";
            }
            Console.WriteLine(output.ToUpper());
        }
    }
}
/*.. | -- .- -.. . | -.-- --- ..- | .-- .-. .. - . | .- | .-.. --- -. --. | -.-. --- -.. .

 */