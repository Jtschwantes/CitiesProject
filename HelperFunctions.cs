using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Cities
{
    public static class HelperFunctions
    {
        public static List<Row> ReadCSV(string path)
        {
            List<Row> cities = new List<Row>();
            using (var sr = new StreamReader(path))
            using (var csv = new CsvReader(sr))
            {
                cities = csv.GetRecords<Row>().ToList();
            }
            return cities;
        }
        
        public static void WriteToFile(string path, string json)
        {
            File.WriteAllText(path, json);
        }
    }
}