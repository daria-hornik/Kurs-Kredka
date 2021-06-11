using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DariaHornikLab7Zadanie.Services;
using DariaHornikLab7Zadanie.Models;

namespace DariaHornikLab7Zadanie.Controllers
{
    [Route("api/pizza")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        //obsluga pizza serwisu
        private IPizzaService pizzaService;
 
        /// <summary>
        /// konstruktor
        /// </summary>
        public PizzaController(CompanyContext _pizzaContext)
        {
            pizzaService = new PizzaService(_pizzaContext);
        }

        /// <summary>
        ///  pobranie danych z bazy w postaci listy
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var pizzas = pizzaService.Get();
            return Ok(pizzas);
        }

        /// <summary>
        /// dodanie rekordu
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody]Pizza pizza) 
        {
            var id = pizzaService.Post(pizza);
            return Ok(id);
        }

        /// <summary>
        /// aktualizacja rekordu
        /// </summary>
        /// <param name="pizza"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Pizza pizza, [FromRoute] int id)
        {
            //znaleznienie pizzy o podanym w URL indexie
            Pizza updatedPizza = pizzaService.Find(id);

            //jeśli pizza o podanym id nie istnieje - błąd 
            if(updatedPizza == null)
                return Conflict("Nie można znaleźć pizzy o podanym id");
         
            //jesli istnieje pizza o podanym id, zostanie zaktualizowana, jeśli nie błąd 404
            if(pizzaService.Put(pizza, id)) 
                return NoContent();
            else 
                return NotFound();
        }
        
        /// <summary>
        /// usuwanie rekordu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            //znaleznienie pizzy o podanym w URL indexie
            Pizza deletedPizza = pizzaService.Find(id);

            //jesli istnieje pizza o podanym id, zostanie zaktualizowana, jeśli nie błąd 404
            if (deletedPizza == null)
                return Conflict("Brak pizzy o podanym id");

            //jesli istnieje pizza o podanym id, zostanie usunięta, jeśli nie błąd 404
            if (!pizzaService.Delete(deletedPizza))
                return NotFound(); //nigdy się nie wykona xd
         
            return NoContent();
        }
    }
}