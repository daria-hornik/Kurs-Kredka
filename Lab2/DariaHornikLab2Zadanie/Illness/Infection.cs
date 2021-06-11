using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab2Zadanie
{
    class Infection : Illness
    {
        public Infection(string cause) : base(cause)
        {
            name = "infekcja";
        }

        //konstruktor
        public override string WayOfTreatment()
        {
            return "podawać regularnie tabetki.";
        }
    }
}
