using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesDesignPattern
{
    class Country
    {
        public enum Continents
        {
            NorthAmerica,
            SouthAmerica,
            Antartica,
            Europe,
            Africa,
            Asia,
            AnotherOne //I'm too ashamed to google this and I'm mad I don't remember
        }
        public string Name { get; set; }
        public Continents Continent { get; set; }
        public List<string> Colors { get; set; }
    }
}
