using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DariaHornikLab6.Models;

namespace DariaHornikLab6.Controllers
{
    public class HomeController : Controller
    {
        //Lista przechowywanych samocodów
        List<CarViewModel> cars;

        /// <summary>
        /// konstruktor klasy 
        /// </summary>
        public HomeController()
        {
            //inicjalizacja listy i dodanie elementów do niej 
            cars = new List<CarViewModel>();
            cars.Add(new CarViewModel("Foocus", "Ford", 72000, "~/Content/Image/focus.png"));
            cars.Add(new CarViewModel("Golf", "Volkswagen", 8000, "~/Content/Image/golf.png"));
            cars.Add(new CarViewModel("Civic", "Honda", 30000, "~/Content/Image/civic.png"));
            cars.Add(new CarViewModel("Megane", "2222", 72000, "~/Content/Image/megane.png"));
        }

        /// <summary>
        /// Widok dla strony kontaktowej 
        /// </summary>
        /// <returns></returns>
        [HttpGet] //pozwala na zapytania get
        public IActionResult ContactForm()
        {
            return View();
        }

        /// <summary>
        /// widok dla strony z listą samochodów
        /// </summary>
        /// <returns></returns>
        public IActionResult GetListOfModels()
        {
            // Lista nazw modeli samochodów do wyświetlenia
            List<string> allModels = new List<string>();

            // Pętla dodająca model samochodu do listy
            foreach (CarViewModel car in this.cars)
            {
                allModels.Add(car.Model);
            }
            // Przekazanie listy modeli do widoku
            return View(allModels);
        }

        /// <summary>
        /// widok dla strony kontaktowej, która przekazuje dane za pomocą viewbag'a  
        /// </summary>
        /// <param name="formViewModel"></param>
        /// <returns></returns>
        /// 
        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel formViewModel)
        {
            string fullName = formViewModel.FirstName + " " + formViewModel.LastName;
            ViewBag.UserName = fullName;
            return View("ContactFormGreetings");
        }

        /// <summary>
        /// widok dla strony wybranego samochodu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IActionResult GetCarByModel(string model)
        {
            //wybranie z listy pierwszego samochodu spełniającego warunek 
            CarViewModel car = cars.Where(c => c.Model.ToLower() == model.ToLower()).FirstOrDefault();
            return View(car);
        }

        /// <summary>
        /// widok strony dla wszystkich samochodów
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllCars()
        {
            return View(cars);
        }

        /// <summary>
        /// Strona główna
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            string name = "Daria Hornik";
            return View("Index", name);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        /// <summary>
        /// widok strony kontaktowej
        /// </summary>
        /// <returns></returns>
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        /// <summary>
        /// strona z linkami
        /// </summary>
        /// <returns></returns>
        public IActionResult InterstingLinks()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
