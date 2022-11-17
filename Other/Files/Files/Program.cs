using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\programs\thisIsntAFile.txt";

            if (!File.Exists(path))
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("This file was just made ");


                }
            //string filename = Path.GetFileName(path);

            Console.WriteLine("PATH: {0}", path);
            //Console.WriteLine("FILENAME: {0}", filename);
        }
    }
}
