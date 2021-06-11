using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DariaHornikLab6Zadanie.Models
{
    public class Attraction
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public double Grade { get; set; }

        public Attraction(string name, string place, string description, int type)
        {
            this.Name = name;
            this.Place = place;
            this.Description = description;
            this.Type = type;
            this.Grade = 0.0;
        }

        public Attraction(string name, int type)
        {
            this.Name = name;
            this.Type = type;
        }

        public Attraction()
        {
        }

    }
}
