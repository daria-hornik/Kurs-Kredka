using System.Collections.Generic;
using DariaHornikLab7Zadanie.Models;

namespace DariaHornikLab7Zadanie.Services
{
    public interface IPizzaService
    {
        List<Pizza> Get();
        int Post(Pizza pizza);
        bool Put(Pizza pizza, int Id);
        bool Delete(Pizza pizza);
        Pizza Find(int id);
    }
}