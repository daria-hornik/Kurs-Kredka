using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DariaHornikLab7Zadanie.Models;

namespace DariaHornikLab7Zadanie.Services
{
    public class ShopService : IShopService
    {
        //połączenie z bazą danych
        private CompanyContext shopContext;

        /// <summary>
        /// konstruktor 
        /// </summary>
        /// <param name="_pizzaContext"></param>
        public ShopService(CompanyContext _shopContext)
        {
            shopContext = _shopContext;
        }

        /// <summary>
        /// pobranie rekordów z bazy i zapisanie w formie listy
        /// </summary>
        /// <returns></returns>
        public List<Shop> Get()
        {
            return shopContext.Set<Shop>().ToList<Shop>();
        }

        /// <summary>
        /// dodawanie rekordów
        /// </summary>
        /// <param name="shop"></param>
        /// <returns></returns>
        public int Post(Shop shop)
        {
            //dodanie obiektu i zapisanie stanu bazy danych 
            shopContext.Set<Shop>().Add(shop);
            shopContext.SaveChanges();
            return 0;
        }

        /// <summary>
        /// aktualizacja rekordu
        /// </summary>
        /// <param name="shop"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Put(Shop shop, int Id)
        {
            //znalezienie sklepu o podnym id, do aktualizacji
            Shop shopToUpdate = Get().Where(x => x.Id.Equals(Id)).Single<Shop>();
            if (shopToUpdate == null)
                return false;

            //upenwnie się, ze nie zostalo zmienione id(klucz)
            shop.Id = Id;
            //aktualizacja i zapis
            shopContext.Entry(shopToUpdate).CurrentValues.SetValues(shop);
            shopContext.SaveChanges();

            return true;
        }

        /// <summary>
        /// usuwanie rekordu
        /// </summary>
        /// <param name="shop"></param>
        /// <returns></returns>
        public bool Delete(Shop shop)
        {
            //usuniecie i zapis bazy
            shopContext.Set<Shop>().Remove(shop);
            shopContext.SaveChanges();
            return true;
        }

        /// <summary>
        /// szukanie rekordu po id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Shop Find(int id)
        {
            return Get().Find(x => x.Id.Equals(id));
        }
    }
}
