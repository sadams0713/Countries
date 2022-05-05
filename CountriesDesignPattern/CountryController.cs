using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesDesignPattern
{
    class CountryController
    {
        List<Country> CountryDB = new List<Country>();

        public CountryController()
        {
            CountryDB.Add(new Country() { Name = "Portugal", Continent = Country.Continents.SouthAmerica, Colors = new List<string> { "Red", "White", "Green" } });
            CountryDB.Add(new Country() { Name = "Canada", Continent = Country.Continents.NorthAmerica, Colors = new List<string> { "Red", "White" } });
            CountryDB.Add(new Country() { Name = "France", Continent = Country.Continents.Europe, Colors = new List<string> { "Blue", "White", "Red" } });
            CountryDB.Add(new Country() { Name = "United States", Continent = Country.Continents.NorthAmerica, Colors = new List<string> { "Red", "White", "Blue" } });
            CountryDB.Add(new Country() { Name = "Japan", Continent = Country.Continents.Asia, Colors = new List<string> { "Red", "White" } });
            CountryDB.Add(new Country() { Name = "England", Continent = Country.Continents.Europe, Colors = new List<string> { "White", "Red" } });
            CountryDB.Add(new Country() { Name = "Brazil", Continent = Country.Continents.SouthAmerica, Colors = new List<string> { "Green", "Yellow", "Blue" } });
            CountryDB.Add(new Country() { Name = "Argentina", Continent = Country.Continents.SouthAmerica, Colors = new List<string> { "Yellow", "White", "Blue" } });
            CountryDB.Add(new Country() { Name = "Sweden", Continent = Country.Continents.Europe, Colors = new List<string> { "Blue", "Yellow" } });
            CountryDB.Add(new Country() { Name = "Egypt", Continent = Country.Continents.Africa, Colors = new List<string> { "Red", "White", "Black" } });
            CountryDB.Add(new Country() { Name = "Morracco", Continent = Country.Continents.Africa, Colors = new List<string> { "Red","Green" } });
            CountryDB.Add(new Country() { Name = "Uruguay", Continent = Country.Continents.SouthAmerica, Colors = new List<string> { "Yellow", "Blue", "White" } });
            CountryDB.Add(new Country() { Name = "Belgium", Continent = Country.Continents.Europe, Colors = new List<string> { "Black", "Yellow", "Red" } });
            CountryDB.Add(new Country() { Name = "Germany", Continent = Country.Continents.Europe, Colors = new List<string> { "Black", "Red", "Yellow" } });
            CountryDB.Add(new Country() { Name = "Artic", Continent = Country.Continents.Antartica, Colors = new List<string> { "Blue", "Cold", "White" } });
        }

        public void CountryAction(Country country)
        {
            CountryView countryView = new CountryView(country);
            countryView.Display();
        }

        public void WelcomeAction()
        {
            int index = -1;
            CountryListView countryList = new CountryListView(CountryDB);

            Console.WriteLine("Wrelcome to the Country App! Please select a country from the following: ");
            countryList.Display();

            do
            {
                Console.WriteLine("Select the index number of the country you'd like to see");
                string input = Console.ReadLine();

                if (int.TryParse(input, out index) && index >= 1 && index <= countryList.Countries.Count)
                {
                    break;
                }

                Console.WriteLine("Welcome to the Country App! Please select from the following countries: ");
                countryList.Display();

                Console.WriteLine("Sorry I didn't catch that. Let's pick again.");

            } while (true);

            CountryAction(countryList.Countries[index - 1]);

            do
            {
                Console.WriteLine("Would you like to learn about another country? Please enter yes or no. ");

                string input = Console.ReadLine();

                if (input == "y" || input == "yes")
                {
                    WelcomeAction();
                    break;
                }
                else if (input == "n" || input == "no")
                {
                    Console.WriteLine("Thanks for using the Country App! Come back soon!");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry I didn't quite get that.");
                }
            }
            while (true);
        }
    }
}
