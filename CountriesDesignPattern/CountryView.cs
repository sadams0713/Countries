using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesDesignPattern
{
     class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country Country)
        {
            this.DisplayCountry = Country;
        }

        public void Display()
        {
            Console.WriteLine("Here's your countries details: ");
            Console.WriteLine();
            Console.WriteLine("Name: " + DisplayCountry.Name);
            Console.WriteLine("Continent: " + DisplayCountry.Continent.ToString().Replace("_", " "));
            Console.Write("Flag colors: "); //Still need to figure out how to display these. 
          
        }
    }
}
