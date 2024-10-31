using System;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<string> results = new List<string>();
            List<string> decryptedResults = new List<string>();

            string input = string.Empty;
            while((input = Console.ReadLine()) != "find")
            {
                char[] charArr = input.ToCharArray();
                string decrypted = string.Empty;
                int br = 0;
                for(int i = 0; i < charArr.Length; i ++)
                {
                    int key = keys[br];
                    char ch = charArr[i];
                    char newCh = (char)((int)ch - key);
                    br++;
                    if(br == keys.Length)
                    {
                        br = 0;
                    }
                    decrypted += newCh;
                }
                results.Add(decrypted);
            }

            foreach(string result in results)
            {
                int indexOfType1 = result.IndexOf("&") + 1;
                int indexOfType2 = result.LastIndexOf("&");
                string type = result.Substring(indexOfType1, indexOfType2 - indexOfType1);

                int indexOfCoordinates1 = result.IndexOf("<") + 1;
                int indexOfCoordinates2 = result.IndexOf(">");
                string coordinates = result.Substring(indexOfCoordinates1, indexOfCoordinates2 - indexOfCoordinates1);

                string decrypted = $"Found {type} at {coordinates}";
                decryptedResults.Add(decrypted);
            }

            foreach(string res in decryptedResults)
            {
                Console.WriteLine(res);
            }
        }
    }
}
