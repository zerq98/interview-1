using System;

namespace Interview.Task5
{
    public class ConsoleCountriesSearchReportWriter
    {
        public void Write(CountryDto[] foundCountries) // zapis raportu na konsolę
        {
            Console.WriteLine("Odanelziono następujące państwa:");

            foreach (var country in foundCountries)
            {
                Console.WriteLine($"- {country.Name}.");
                Console.WriteLine($"  -stolica: {country.Capital}");
                Console.WriteLine($"    - ludność: {country.Population / 1e6} milionów");
                Console.WriteLine($"    - powierzchnia: {country.Area} km^2");
                Console.WriteLine($"    - długość geograficzna: {(country.LatLng!=null?country.LatLng[1].ToString():"brak")} ");
                Console.WriteLine($"    - szerokość geograficzna: {(country.LatLng != null ? country.LatLng[0].ToString() : "brak")} ");
                Console.WriteLine($"    - gęstość zaludnienia: {Math.Round((double)(((country.Population.HasValue? country.Population.Value:0d) / 1e6)/ (country.Area.HasValue?country.Area.Value:1)),2)} /km^2");
                Console.WriteLine($"    - skrót trzy literowy: {country.Alpha3Code}");
            }
        }
    }
}
