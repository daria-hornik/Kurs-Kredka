using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DariaHornikLab7Zadanie.Models;
using DariaHornikLab7Zadanie.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DariaHornikLab7Zadanie.Controllers
{
    [Route("api/shop")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private IShopService shopService;

        public ShopController(CompanyContext _shopContext)
        {
            shopService = new ShopService(_shopContext);
        }


        /// <summary>
        ///  pobranie danych z bazy w postaci listy
        /// </summary>
        /// <returns></returns>
        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            List<Shop> shops = shopService.Get();
            return Ok(shops);
        }


        /// <summary>
        /// dodanie rekordu
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        [HttpPost("AddShop")]
        public IActionResult Post([FromBody]Shop shop)
        {
            var id = shopService.Post(shop);
            return Ok(id);
        }

        /// <summary>
        /// aktualizacja rekordu
        /// </summary>
        /// <param name="pizza"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("Update/{id}")]
        public IActionResult Put(int id, [FromBody]Shop shop)
        {
            //znaleznienie pizzy o podanym w URL indexie
            Shop updatedShop = shopService.Find(id);

            //jeśli pizza o podanym id nie istnieje - błąd 
            if (updatedShop == null)
                return Conflict("Nie można znaleźć pizzy o podanym id");

            //jesli istnieje sklep o podanym id, zostanie zaktualizowany, jeśli nie błąd 404
            if (shopService.Put(shop, id))
                return NoContent();
            else
                return NotFound();

        }

        /// <summary>
        /// usuwanie rekordu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("DeleteShop/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            //znaleznienie sklepu o podanym w URL indexie
            Shop deletedShop = shopService.Find(id);

            //jesli istnieje sklep o podanym id, zostanie zaktualizowany, jeśli nie błąd 404
            if (deletedShop == null)
                return Conflict("Brak sklepu o podanym id");

            //jesli istnieje sklep o podanym id, zostanie usunięty, jeśli nie błąd 404
            if (!shopService.Delete(deletedShop))
                return NotFound(); //nigdy się nie wykona xd

            return NoContent();
        }
    }
}
