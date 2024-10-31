namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                                        .Split(" ")
                                        .ToList();

            Random rnd = new Random();
            for(int i = 0; i < input.Count; i++)
            {
                string oldValue = input[i]; ;
                int newIndex = rnd.Next(0, input.Count);
                string newValue = input[newIndex];

                input[i] = newValue;
                input[newIndex] = oldValue;
            }

            foreach(string value in input)
            {
                Console.WriteLine(value);
            }
        }
    }

}