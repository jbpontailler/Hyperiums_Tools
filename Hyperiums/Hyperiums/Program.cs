using System;
using System.IO;

namespace Hyperiums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extraction and display file planet.txt
            string[] planets = File.ReadAllLines("C:/Users/JB/Desktop/La Manu/Git/Hyperiums_Tools/log/planet.txt");
            Console.WriteLine(planets);

            var lines = File.ReadLines(ofd.FileName);
            foreach (string line in lines.Skip(2))
                Trace.WriteLine(line);

            foreach (string line in planets)
            Console.WriteLine(line);
        }
    }
}
