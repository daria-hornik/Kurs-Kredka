using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab2Zadanie
{
    abstract class Illness
    {
        //pola klasy
        protected string cause;
        public string name;
        public bool isCured;

        //konstruktor
        public Illness(string _cause)
        {
            cause = _cause;
            isCured = false;
        }

        //konstruktor
        public Illness(string _cause, string cause) : this(_cause)
        {
            this.cause = cause;
        }

        //metoda abstrakcyjna
        abstract public string WayOfTreatment();

    }
}
