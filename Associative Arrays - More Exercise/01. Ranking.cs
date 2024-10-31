namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var maxPoints = new Dictionary<string, int>();

            var courses = new Dictionary<string, string>();
            string input;
            while((input = Console.ReadLine()) != "end of contests")
            {
                string[] course = input.Split(":").ToArray();
                courses.Add(course[0], course[1]);
            }

            var users = new SortedDictionary<string, SortedDictionary<string, int>>();
            string inp;
            while((inp = Console.ReadLine()) != "end of submissions")
            {
                string[] user = inp.Split("=>").ToArray();
                string course = user[0];
                string pass = user[1];
                string name = user[2];
                int points = int.Parse(user[3]);

                if(courses.ContainsKey(course) )
                {
                    if (courses[course] == pass)
                    {
                        if(users.ContainsKey(name))
                        {
                            if (users[name].ContainsKey(course))
                            {
                                if (users[name][course] < points)
                                {
                                    maxPoints[name] += points - users[name][course];
                                    users[name][course] = points;
                                }
                            }
                            else
                            {
                                users[name].Add(course, points);
                                maxPoints[name] += points;
                            }
                        }
                        else
                        {
                            users.Add(name, new SortedDictionary<string, int>() { [course] = points });
                            maxPoints.Add(name, points);
                        }
                    }
                }
            }

            Console.WriteLine($"Best candidate is {maxPoints.MaxBy(x => x.Value).Key}" +
                $" with total {maxPoints.MaxBy(x => x.Value).Value} points.");
            Console.WriteLine("Ranking:");
            foreach( var user in users)
            {
                Console.WriteLine(user.Key);
                foreach(var courseAndPoints in users[user.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {courseAndPoints.Key} -> {courseAndPoints.Value}");
                }
            }
        }
    }
}