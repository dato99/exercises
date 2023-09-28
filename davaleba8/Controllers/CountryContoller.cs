using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Text.Json;

namespace davaleba8.Controllers
{
    public class CountryContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GenerateCountryDataFilesAsync()
        {
            try
            {
                string apiUrl = "https://restcountries.com/v3.1/all";

                using var httpClient = new HttpClient();
                var response = await httpClient.GetStringAsync(apiUrl);

                var countries = JsonSerializer.Deserialize<Country[]>(response);

                foreach (var country in countries)
                {
                    string countryName = country.Name.Common;
                    string fileName = $"{countryName}.txt";

                    string region = country.Region;
                    string subregion = country.Subregion;
                    string latlng = string.Join(", ", country.Latlng);
                    string area = country.Area.ToString();
                    string population = country.Population.ToString();

                    string fileContent = $"Country: {countryName}\nRegion: {region}\nSubregion: {subregion}\nLatlng: {latlng}\nArea: {area}\nPopulation: {population}";

                    await System.IO.File.WriteAllTextAsync(Path.Combine("wwwroot", fileName), fileContent);
                }

                ViewBag.Message = "Files created successfully!";
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"Error: {ex.Message}";
            }

            return View("Index");
        }

    }
}
