using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace PopulationEnd.Controllers
{
    public class CountryController : Controller
    {

        // GET: CountryController
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:7066/api/countries");

            client.BaseAddress = new Uri("https://populacaoapi.azurewebsites.net/api/countries");
            var countrie = await client.GetFromJsonAsync<List<Country>>("");
            return View(countrie);
        }

        // GET: CountryController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:7066/api/countries/");

            client.BaseAddress = new Uri("https://populacaoapi.azurewebsites.net/api/countries/");
            var countrie = await client.GetFromJsonAsync<Country>(id.ToString());
            return View(countrie);
            
        }

        // GET: CountryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Country collection)
        {
            try
            {
                HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri("https://localhost:7066/api/countries/");
                client.BaseAddress = new Uri("https://populacaoapi.azurewebsites.net/api/countries/");

                await client.PostAsJsonAsync<Country>("", collection);
               
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: CountryController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:7066/api/countries/");

            client.BaseAddress = new Uri("https://populacaoapi.azurewebsites.net/api/countries/");
            var countrie = await client.GetFromJsonAsync<Country>(id.ToString());
            return View(countrie);
            
        }

        // POST: CountryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Country collection)
        {
            try
            {
                HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri("https://localhost:7066/api/countries/");
                client.BaseAddress = new Uri("https://populacaoapi.azurewebsites.net/api/countries/");

                await client.PutAsJsonAsync<Country>(id.ToString(), collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: CountryController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:7066/api/countries/");

            client.BaseAddress = new Uri("https://populacaoapi.azurewebsites.net/api/countries/");
            var countrie = await client.GetFromJsonAsync<Country>(id.ToString());
            return View(countrie);
            
        }

        // POST: CountryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Country collection)
        {
            try
            {
                HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri("https://localhost:7066/api/countries/");
                client.BaseAddress = new Uri("https://populacaoapi.azurewebsites.net/api/countries/");
                await client.DeleteAsync(id.ToString());
                return RedirectToAction(nameof(Index));
                
            }
            catch
            {
                return View(collection);
            }
        }
    }
}
