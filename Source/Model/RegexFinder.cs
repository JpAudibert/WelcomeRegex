using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Source.Model
{
    public class RegexFinder
    {
        public static List<City> FindRSSaintsCities(List<string> cities)
        {
            try
            {
                Regex regex = new Regex(@"RS.+\b(Santa|Santo|São)\b.+");
                IEnumerable<string> rsCities;
                IEnumerable<City> rsSaintCities;

                rsCities = cities.Where(city => regex.IsMatch(city));

                rsSaintCities = rsCities.Select(rsCity =>
                {
                    string[] citySplitted = rsCity.Split(";");

                    City city = new City(citySplitted[0], citySplitted[1], citySplitted[2], citySplitted[3], citySplitted[4]);

                    return city;
                });

                return rsSaintCities.ToList();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}