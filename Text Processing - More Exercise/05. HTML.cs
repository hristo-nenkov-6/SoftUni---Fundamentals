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
            List<List<string>> list = new List<List<string>>();
            string head = Console.ReadLine();
            list.Add(HTMLformat("h1", head));
            
            string article = Console.ReadLine();
            list.Add(HTMLformat("article", article));

            string comments = string.Empty;
            while((comments = Console.ReadLine()) != "end of comments")
            {
                list.Add(HTMLformat("div", comments));
            }
            foreach(var l in list)
            {
                foreach(var c in l)
                {
                    Console.WriteLine(c);
                }
            }
        }
        public static List<string> HTMLformat(string type, string text)
        {
            List<string> list = new List<string>();
            list.Add($"<{type}>");
            list.Add($"     {text}");
            list.Add($"</{type}>");
            return list;
        }
    }
}
/*
 * SoftUni Article
Some content of the SoftUni article
some comment
more comment
last comment
end of comments
 */