using DariaHornikLab7Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DariaHornikLab7Zadanie.Services
{
    interface IShopService
    {
        List<Shop> Get();
        int Post(Shop shop);
        bool Put(Shop shop, int Id);
        bool Delete(Shop shop);
        Shop Find(int id);
    }
}
