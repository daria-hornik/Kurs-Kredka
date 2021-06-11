using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DariaHornikLab7Zadanie.Models;

namespace DariaHornikLab7Zadanie.Services
{
    public class PizzaService : IPizzaService
    {
        //połączenie z bazą danych
        private CompanyContext pizzaContext;

        /// <summary>
        /// konstruktor 
        /// </summary>
        /// <param name="_pizzaContext"></param>
        public PizzaService(CompanyContext _pizzaContext)
        {
            pizzaContext = _pizzaContext;
        }

        /// <summary>
        /// pobranie rekordów z bazy i zapisanie w formie listy
        /// </summary>
        /// <returns></returns>
       public List<Pizza> Get()
        {
            return pizzaContext.Set<Pizza>().ToList<Pizza>();
        }
        
        /// <summary>
        /// dodawanie rekordów
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        public int Post(Pizza pizza)
        {
            //dodanie obiektu i zapisanie stanu bazy danych 
            pizzaContext.Set<Pizza>().Add(pizza);
            pizzaContext.SaveChanges();
            return 0;
        }
 
        /// <summary>
        /// aktualizacja rekordu
        /// </summary>
        /// <param name="pizza"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Put(Pizza pizza, int Id)
        {
            //znalezienie pizzy o podnym id, do aktualizacji
            Pizza pizzaToUpdate = Get().Where(x => x.Id.Equals(Id)).Single<Pizza>();

            if (pizzaToUpdate == null)
                return false;
            //upenwnie się, ze nie zostalo zmienione id(klucz)
            pizza.Id = Id;
            //aktualizacja i zapis
            pizzaContext.Entry(pizzaToUpdate).CurrentValues.SetValues(pizza);
            pizzaContext.SaveChanges();
           
            return true;
        }

        /// <summary>
        /// usuwanie rekordu
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        public bool Delete(Pizza pizza)
        {
            //usuniecie i zapis bazy
            pizzaContext.Set<Pizza>().Remove(pizza);
            pizzaContext.SaveChanges();
            return true;
        }

        /// <summary>
        /// szukanie rekordu po id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Pizza Find(int id)
        {
            return Get().Find(x => x.Id.Equals(id));
           
        }
    }
}
