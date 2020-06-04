using System;
using System.IO;
using FileIOLibrary;

namespace UsandoDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ReadFile.txt");
            string lineContents = null;
            int lineNumber = 3;

            FileIO fileIO = new FileIO();
            lineContents = fileIO.ReadLine(filePath, lineNumber);

            if (lineContents != null)
                Console.WriteLine(lineContents);

            Console.ReadLine();
        }
    }
}
