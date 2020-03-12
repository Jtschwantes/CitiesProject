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
            // Edit me!
            return default;
        }

    }
}
