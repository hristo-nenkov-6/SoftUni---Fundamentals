using System.ComponentModel;
using System.Numerics;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
                                            .Split("_")
                                            .ToList();

                string typeList = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }

            string wantedType = Console.ReadLine();
            if(wantedType == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = songs
                                            .Where(s => s.TypeList == wantedType)
                                            .ToList ();

                foreach(Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }

}