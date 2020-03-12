using System;
using static Prysm.Pym;
using static Prysm.Colors;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using static Cities.HelperFunctions;

namespace Cities
{
    class Program
    {
        public static void Main(string[] args)
        {
            // No need to edit this stuff
            Initialize();
            var json = FormatCities(ReadCSV("./cities.csv"));
            Gradient(JsonConvert.SerializeObject(json), Cyan, Magenta);
            WriteToFile(@"./json.json", JsonConvert.SerializeObject(json));
        }

        public static List<Country> FormatCities(List<Row> cities)
        {
            return cities
                .Select(city => city.Country) // Map to country name
                .Distinct() // Ensure only unique names
                .OrderBy(z => z) // Order alphabetically
                .Select(countryName => new Country(countryName, cities // Maps list of cities to country objects
                    .Where(city => city.Country == countryName) // Filter to only cities that have the right country name
                    .Select(city => city.State) // Map to state name
                    .Distinct() // Ensure only unique names
                    .OrderBy(z => z) // Orders alphabetically
                    .Select(stateName => new State(stateName, cities // Maps list of cities to state objects
                        .Where(city => city.State == stateName && city.Country == countryName) // Filter to cities only in the right state and coutry
                        .Select(city => new City(city.Name, city.Population)) // Map cities into new city objects
                        .OrderBy(city => city.Population) // Sort by population
                        .ToList())) // Formats cities to list to put into state object
                    .ToList())) // Formats states to list to insert into country object
                .ToList(); // Formats countries to list
        }

    }
}
