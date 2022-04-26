using System;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Task5
{
    public class Tester5
    {
        private readonly CountriesRestApiClient _apiClient;
        private readonly ConsoleCountriesSearchReportWriter _countriesSearchReportWriter;

        public Tester5()
        {
            _apiClient = new CountriesRestApiClient();
            _countriesSearchReportWriter = new ConsoleCountriesSearchReportWriter();
        }

        public async Task Test()
        {
            try
            {
                Console.WriteLine("Szukaj państwa (nazwa po angielsku, nie trzeba wpisywać całej nazwy - można np. tylko pierwszą literę):");
                var searchText = Console.ReadLine();

                var countries = await _apiClient.GetCountries(searchText);

                _countriesSearchReportWriter.Write(countries.Where(x=>x.Name.Contains(searchText)).ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
