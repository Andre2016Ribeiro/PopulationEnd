using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace PopulationEnd.Controllers
{
    public class CitiesController : Controller
    {
        // GET: CitiesController
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:7066/api/cities");
            client.BaseAddress = new Uri("https://populacaoapi.azurewebsites.net/api/cities");

            var result= await client.GetFromJsonAsync<List<City>>("");
            
            return View(result);
        }

        // GET: CitiesController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:7066/api/countries/");
            client.BaseAddress = new Uri("https://populacaoapi.azurewebsites.net/api/cities/");

           var result = await client.GetFromJsonAsync<City>(id.ToString());
            
            
            return View(result);
        }

        // GET: CitiesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CitiesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(City collection)
        {
            try
            {
                HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri("https://localhost:7066/api/countries/");
                client.BaseAddress = new Uri("https://populacaoapi.azurewebsites.net/api/cities/");

                await client.PostAsJsonAsync<City>("", collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: CitiesController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:7066/api/countries/");
            client.BaseAddress = new Uri("https://populacaoapi.azurewebsites.net/api/cities/");

            var result = await client.GetFromJsonAsync<City>(id.ToString());
            return View(result);
        }

        // POST: CitiesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, City collection)
        {
            try
            {
                HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri("https://localhost:7066/api/countries/");
                client.BaseAddress = new Uri("https://populacaoapi.azurewebsites.net/api/cities/");

                await client.PutAsJsonAsync<City>(id.ToString(), collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CitiesController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:7066/api/countries/");
            client.BaseAddress = new Uri("https://populacaoapi.azurewebsites.net/api/cities/");

            var result = await client.GetFromJsonAsync<City>(id.ToString());
            return View(result);
        }

        // POST: CitiesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, City collection)
        {
            try
            {
                HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri("https://localhost:7066/api/countries/");
                client.BaseAddress = new Uri("https://populacaoapi.azurewebsites.net/api/cities/");
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
