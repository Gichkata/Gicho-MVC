using Gicho_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gicho_MVC.Controllers
{
    public class KotkaContoller : Controller
    {
        public IActionResult index()
        {
            List<Kotka> Kotki = new List<Kotka>()
            {
                new Kotka() { KotkaId = 2, Poroda = "britanska", Vid = "malka", YearBorn = 2018}
            };
            return View(Kotki);
        }
    }
}
