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
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Countries Maintenance Application!");
            Console.WriteLine("1 - See the list of countries.");
            Console.WriteLine("2 - Add a country.");
            Console.WriteLine("3 - Exit.");

            Reader a = new Reader();
            Console.WriteLine(a);
        }
    }
}
