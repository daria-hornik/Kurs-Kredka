using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DariaHornikLab7.Services;
using DariaHornikLab7.Models;

namespace DariaHornikLab7.Controllers
{
    [Route("api/pizza")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private IPizzaService pizzaService;

        /// <summary>
        /// snippet
        /// </summary>
        public PizzaController(IPizzaService _pizzaService)
        {
            pizzaService = _pizzaService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var pizzas = pizzaService.Get();
            return Ok(pizzas); //kod 200
        }

        [HttpPost]
        public IActionResult Post([FromBody]Pizza pizza) 
        {
            var id = pizzaService.Post(pizza);
            return Ok(id);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Pizza pizza, [FromRoute] int id)
        {
            Pizza updatedPizza = pizzaService.Find(id);
            if(updatedPizza == null)
            {
                return Conflict("Nie można znaleźć id");
            }

            pizzaService.Put(pizza, id);
            return NoContent();

            //kod z zajęć, który nie działa xd
            /*if(id != pizza.Id)
            {
                return Conflict("Nie można edytować id");
            }else
            {
                var isUpdateSuccessful = pizzaService.Put(pizza, id);
                if(isUpdateSuccessful)
                {
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
            }*/
        }
        
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            Pizza deletedPizza = pizzaService.Find(id);
           
            if (!pizzaService.Delete(deletedPizza))
                return NotFound();
         
            return NoContent();
        }
    }
}