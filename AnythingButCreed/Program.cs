using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var allSongs = new List<Song>();
            var goodSongs = new List<Song>();

            allSongs.Add(new Song("Blackbird", "The Beatles"));
            allSongs.Add(new Song("CreedSong1", "Creed"));
            allSongs.Add(new Song("CreedSong2", "Creed"));
            allSongs.Add(new Song("CreedSong3", "Creed"));
            allSongs.Add(new Song("Cinnamon Tree", "Esperanza Spalding"));
            allSongs.Add(new Song("Radio Song", "Esperanza Spalding"));
            allSongs.Add(new Song("Paradise Lost", "Outer Park"));
            allSongs.Add(new Song("CreedSong4", "Creed"));
            allSongs.Add(new Song("Bikes", "Rubblebucket"));
            allSongs.Add(new Song("Poncianna", "Ahmad Jamal"));

            var notCreed = allSongs.Where(num => num.Artist != "Creed");

            goodSongs.AddRange(notCreed);

            foreach(var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist}: {song.Name}");
            }
        }
    }
}
