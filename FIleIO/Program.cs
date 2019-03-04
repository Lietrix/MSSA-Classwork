using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string TextFile = "C:\\Users\\WWStudent\\source\\repos\\Classwork\\FIleIO\\RandomPoem.txt";
            ReadFileIO(TextFile);
        }

        public static void ReadFileIO(string path)
        {
            int blankLines = 0;
            List<string> Words = new List<string> { };
            List<string> TextFile = File.ReadAllLines(path).ToList();
            List<string> DistinctWords = new List<string> { };
            try
            {
                foreach (string line in TextFile)
                {
                    if (line.Length < 1) blankLines++;
                    foreach (string word in line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        Words.Add(word);
                        if (!DistinctWords.Contains(word)) DistinctWords.Add(word);
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("can't open file for reading" + path);
            }
            Console.WriteLine($"{TextFile.Count} lines read\n{blankLines} lines blank" +
                $"\n{Words.Count} total words\n{DistinctWords.Count} Unique Words");
            foreach(string line in TextFile) Console.WriteLine("\t" + line);
        }
    }
}
