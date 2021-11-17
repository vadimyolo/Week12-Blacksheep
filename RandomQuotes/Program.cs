using System;
using System.IO;

namespace RandomQuotes
{
    class Program
    {
        static void Main(string[] args)
        {

            string directoryPath = @"C:\Users\opilane\Samples";
            string fileName = "quotes.txt";
            string fullPath = $@"{directoryPath}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(fullPath);
            Random rnd = new Random();
            Console.WriteLine(dataFromFile[0]);
            Console.WriteLine(dataFromFile[rnd.Next(dataFromFile.Length)]);
        }
    }
}
