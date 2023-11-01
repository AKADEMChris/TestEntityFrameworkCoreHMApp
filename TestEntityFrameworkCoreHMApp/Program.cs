using System;
using TestEntityFrameworkCoreHMApp.Model;

namespace TestEntityFrameworkCoreHMApp
{
    internal class Program
    {
        public static void TestAdd()
        {
            try
            {
                RdbSongsService playlist = new RdbSongsService();
                playlist.Add(new Song { Artist = "Exyl", Title = "Ping!2", Year = 2022 });
                playlist.Add(new Song { Artist = "Dua Lipa", Title = "Dance", Year = 2023 });
                playlist.Add(new Song { Artist = "Thom Yorke", Title = "Unmade", Year = 2018 });
                playlist.Add(new Song { Artist = "ANGELPLAYA", Title = "PULL UP", Year = 2023 });
                playlist.Add(new Song { Artist = "Kvi Baba", Title = "Tombi", Year = 2023 });
                Console.WriteLine("Songs added.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void TestPrintAll()
        {
            try
            {
                RdbSongsService playlist = new RdbSongsService();
                Console.WriteLine("Id - Artist name - Title - Year");
                foreach (Song song in playlist.GetAll())
                {
                    Console.WriteLine($"{song.Id} - {song.Artist} - {song.Title} - {song.Year}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void TestGetById()
        {
            try
            {
                RdbSongsService playlist = new RdbSongsService();
                Song song = playlist.GetById(1);
                Console.WriteLine(song.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            //TestAdd();

            //TestPrintAll();

            //TestGetById();
        }
    }
}