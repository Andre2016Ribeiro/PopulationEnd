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
            client.BaseAddress = new Uri("https://population1.azurewebsites.net/");
           
            //https://localhost:7066/api/countries/
            var countrie = await client.GetFromJsonAsync<List<Country>>("");
            return View(countrie);
        }

        // GET: CountryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                client.BaseAddress = new Uri("https://population1.azurewebsites.net/");
                //"https://localhost:7066/api/countries/");

                await client.PostAsJsonAsync<Country>("", collection);
               
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: CountryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CountryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CountryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CountryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
