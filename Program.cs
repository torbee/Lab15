using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    class Program
    {
        public static void Main(string[] args)
        {
            string filepath = @"D:\Documents\Visual Studio 2015\Projects\Lab15\Lab15\countries.txt";
            CountriesApp option = new CountriesApp(filepath);

            while (true)
            {
                option.Menu();
            }


        }
    }
}