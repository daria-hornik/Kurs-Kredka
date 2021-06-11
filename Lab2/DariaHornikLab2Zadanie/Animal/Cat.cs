using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab2Zadanie
{
    class Cat : Animal
    {
        //pola klasy
        protected bool isPurring;

        //konstruktor
        public Cat()
        {
            age = 0;
            name = "Unknown";
            isPurring = true;
        }

        public override string Feed()
        {
            return "Miauuuu, pycha";
        }

        public override string MakeASound()
        {
            return "Miauuuu";
        }

        public override string Sleep()
        {
            return "Dobranoc... Miauuuu";
        }
     
    }
}
