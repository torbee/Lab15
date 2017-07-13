using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    public class CountriesTextFile
    {
        public void Reader() {
            string filepath = @"C:\Users\GC Student\Documents\Visual Studio 2015\Projects\Lab15\Lab15\countries.txt";
            StreamReader reader = new StreamReader(filepath);
            string input;

            string line = reader.ReadLine();
            input = reader.ReadLine();
            Console.WriteLine(input);
            Console.WriteLine(line);
        }
        
    }

}
