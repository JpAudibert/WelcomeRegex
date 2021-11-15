using System.Collections.Generic;
using Source.FileStream;
using Source.Model;

namespace Source
{

    class Program
    {
        private static readonly List<string> FILE = new List<string>() {"files", "estimativa_populacional_julho_2021.csv"};
        static void Main(string[] args)
        {
            string fullPath = PathCombiner.combineInputPaths(FILE);
            List<string> cities = FileReader.ReadFile(fullPath);

            List<City> regexedCities = RegexFinder.FindRSSaintsCities(cities);

            Printer.PrintCities(regexedCities);
        }
    }
}
