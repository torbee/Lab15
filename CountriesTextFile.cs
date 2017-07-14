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
        string path;
        public CountriesTextFile(string filepath)
        {
            path = filepath;
        }
        public void showList()
        {            
            StreamReader reader = new StreamReader(path);
            string line = reader.ReadToEnd();
            Console.WriteLine(line);
            reader.Close();
        }

        public void addFile(string country)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.Write(country);
            writer.Close();
        }
    }
}