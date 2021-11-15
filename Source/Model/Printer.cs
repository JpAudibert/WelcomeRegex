using System.Collections.Generic;

namespace Source.Model
{
    public class Printer
    {
        public static void PrintCities(List<City> cities)
        {
            cities.ForEach(city => System.Console.WriteLine(city));
        }
    }
}