using System;
using System.IO;

namespace Seasons
{
    class Program
    {
        static void Main(string[] args)

        {
            string winterfile = @"C:\Users\opilane\samples\Winter.txt";
            string autumnfile = @"C:\Users\opilane\samples\Autumn.txt";

            string[] winterData = File.ReadAllLines(autumnfile);
            string[] autumnData = File.ReadAllLines(winterfile);

            File.WriteAllLines(autumnfile, autumnData);
            File.WriteAllLines(winterfile, winterData);
            

            
        }
    }
}
