using System;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Song.songCount);

            Console.WriteLine();

            Song holiday = new Song("Holiday", "Green Day", 320);

            Console.WriteLine(holiday.title);
            Console.WriteLine(holiday.artist);
            Console.WriteLine(holiday.duration);
            Console.WriteLine(Song.songCount);
            
            Console.WriteLine();

            Song kashmir = new Song("Kashmir", "Led Zeppelin", 220);
            Console.WriteLine(kashmir.title);
            Console.WriteLine(kashmir.artist);
            Console.WriteLine(kashmir.duration);
            Console.WriteLine(Song.songCount);
        }
    }
}
