using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DariaHornikLab7Zadanie.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string Description { get; set; }
        public Decimal Cost { get; set; }
    }
}
