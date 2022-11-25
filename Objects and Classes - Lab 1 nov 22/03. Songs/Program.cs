using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> playlist = new List<Song>();
            //Song[] playlist = new Song[n];

            for (int i = 0; i < n; i++)
            {
                string[] songsArr = Console.ReadLine().Split('_');

                Song song = new Song();
                
                song.TypeList = songsArr[0];
                song.Name = songsArr[1];
                song.Time = songsArr[2];

                playlist.Add(song);
                //playlist[i] = song;
            }

            string typeOfList = Console.ReadLine();

            if (typeOfList == "all")
            {
                foreach (Song song in playlist)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, song.Name));
                }
            }
            else
            {
                foreach (Song song in playlist)
                {
                    if (typeOfList == song.TypeList)
                    {
                        Console.WriteLine(string.Join(Environment.NewLine, song.Name));
                    }
                }
            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
