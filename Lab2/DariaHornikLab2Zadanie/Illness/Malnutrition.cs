using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab2Zadanie
{
    class Malnutrition : Illness
    {
        //konstruktor
        public Malnutrition(string _cause) : base(_cause)
        {
            name = "niedożywienie";
        }

        public override string WayOfTreatment()
        {
            return "podawać regularnie zdrowe posiłki.";
        }
    }
}
