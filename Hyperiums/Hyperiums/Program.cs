using System;
using System.IO;

namespace Hyperiums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extraction and display file planet.txt
            string[] planets = File.ReadAllLines("C:/Users/ponta/Desktop/La manu/Git/Hyperiums/log/planet.txt").Skip('#');
            Console.WriteLine(planets);

            foreach (string line in planets)
            Console.WriteLine(line);
        }
    }
}
