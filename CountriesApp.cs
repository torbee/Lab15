using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    public class CountriesApp
    {
        CountriesTextFile ctf;
        public CountriesApp(string filepath)
        {
            ctf = new CountriesTextFile(filepath);
        }

        public void Menu()
        {
            Console.WriteLine("Welcome to the Countries Maintenance Application!");
            Console.WriteLine("1 - See the list of countries");
            Console.WriteLine("2 - Add a country");
            Console.WriteLine("3 - Exit");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                ctf.showList();
            }
            else if (option == 2)
            {
                string getCountry = Console.ReadLine();
                ctf.addFile(getCountry);
            }
            else if (option == 3)
            {
                Console.WriteLine("Later nerd!");
            }
        }

    }
}
