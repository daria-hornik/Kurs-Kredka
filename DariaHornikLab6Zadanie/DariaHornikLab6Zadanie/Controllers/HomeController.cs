using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DariaHornikLab6Zadanie.Models;
using DariaHornikLab6Zadanie.Services;

namespace DariaHornikLab6Zadanie.Controllers
{
    public class HomeController : Controller
    {
        //singleton przechowujący liste atrakcji
        private DariaHornikLab6Zadanie.Services.MySingletonService singleton = DariaHornikLab6Zadanie.Services.MySingletonService.GetInstance();

        /// <summary>
        /// konstruktor klasy
        /// </summary>
        public HomeController()
        {
        }

        /// <summary>
        /// Widok strony głównej
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            TempData["Info"] = "Zapraszamy do zapoznania się z naszą ofertą wycieczek.";
            return View();
        }

        /// <summary>
        /// widok strony do dodawnaia nowych atrakcji 
        /// </summary>
        /// <returns></returns>
        [HttpGet] 
        public IActionResult AddNewAtractions()
        {
            return View();
        }

        /// <summary>
        /// widok strony do dodawnaia nowych atrakcji 
        /// </summary>
        /// <param name="formViewModel"></param>
        /// <returns></returns>
        /// 
        [HttpPost]
        public IActionResult AddNewAtractions(AddNewAttractionFormViewModel formViewModel)
        {
            string name = formViewModel.AttractionsName;
            string place = formViewModel.Place;
            string description = formViewModel.Description;
            int type = formViewModel.Type;

            ViewBag.Author = formViewModel.AuthorName;
            Attraction newAttraction = new Attraction(name, place, description, type);
           
            singleton.AddAttractions(newAttraction);
            return View("RecentlyAddAttraction", newAttraction);
        }

        /// <summary>
        /// metoda wyszukująca atrakcje z tej samej kategorii
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [HttpGet]
        private List<Attraction> FindAttractionOfTheSameType(int type)  {
            List<Attraction> endingList = new List<Attraction>();
            foreach (var attr in singleton.GetAttractions())
            {
                if (attr.Type == type)
                    endingList.Add(attr);
            }
            return endingList;
        }

        /// <summary>
        /// strona z atrakcjami naukowymi i kulturalnymi
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public IActionResult ScienceAndCulture()
        {
            // return View(FindAttractionOfTheSameType(1));
            return View(FindAttractionOfTheSameType(1));
        }

        /// <summary>
        /// strona z atrakcjami architektonicznymi
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public IActionResult Architecture()
        {
            return View(FindAttractionOfTheSameType(3));
        }

        /// <summary>
        /// strona z atrakcjami przyrodniczymi
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public IActionResult Nature()
        {
            return View(FindAttractionOfTheSameType(2));
        }

        /// <summary>
        /// ostatnia dodana atrakcja
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult RecentlyAddAttraction()
        {
            return View(singleton.GetAttractions().Last());
        }

        /// <summary>
        /// zmiana oceny atrakcji
        /// </summary>
        /// <param name="formViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult RecentlyAddAttraction(NewGradeForAttractionsForm formViewModel)
        {
           double grade= formViewModel.Grade;
            singleton.GetAttractions().Last().Grade = (singleton.GetAttractions().Last().Grade + grade) / 2;
            return View("Index");
        }

        /// <summary>
        /// wyswietlenie wszystkich atrakcji
        /// </summary>
        /// <returns></returns>
        public IActionResult ShowAllAttractions(Attraction model)
        {
            return View(singleton.GetAttractions());
        }
    }
}
