using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DariaHornikLab7.Models;

namespace DariaHornikLab7.Services
{
    public class PizzaService : IPizzaService
    {
        private static List<Pizza> pizzas = new List<Pizza>();

      
        public List<Pizza> Get()
        {
            return pizzas;
        }

        public int Post(Pizza pizza)
        {
            int id;
            if(pizzas.Count() == 0)
            {
                id = 0;
            }else
            {
                id = pizzas.Max(x => x.Id);
                pizza.Id = ++id;
            }

            pizzas.Add(pizza);
            return id;
        }

        /// <summary>
        /// Aktualizacja pizza 
        /// </summary>
        /// <param name="pizza"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Put(Pizza pizza, int Id)
        {
            var pizzaToUpdate = pizzas.Where(x => x.Id.Equals(Id)).SingleOrDefault();

            if(pizzaToUpdate == null)
            {
                return false;
            }

            pizzaToUpdate.Name = pizza.Name;
            pizzaToUpdate.Cost = pizza.Cost;
            pizzaToUpdate.Description = pizza.Description;
            return true;
        }


        public bool Delete(Pizza pizza)
        {
            if(!pizzas.Contains(pizza))
            {
                return false;
            }

            pizzas.Remove(pizza);
            return true;
        }

        
        public Pizza Find(int id)
        {
            return pizzas.Find(x => x.Id.Equals(id));
        }


    }
}
