using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DariaHornikLab6.Models
{
    public class CarViewModel
    {
        public string Model { get; set; }
        public string Manufacturerr { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }


        public CarViewModel(string model, string manufacturer, decimal price, string photo)
        {
            Model = model;
            Manufacturerr = manufacturer;
            Price = price;
            Photo = photo;
        }


    }
}
