using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab2Zadanie
{
    class Dog : Animal
    {
        //pola klasy
        protected bool isVaccinated;
        protected bool isDangerous;
        public int nr;

        //konstruktor
        public Dog(int number)
        {
            age = 0;
            name = "Unknown";
            isVaccinated = false;
            isDangerous = false;
            nr = number;
        }

        public override string Feed()
        {
            return "Hauuu, hauu, jesteś najlepszy";
        }

        public override string MakeASound()
        {
            return "Bark: Hau Hau";
        }

        public override string Sleep()
        {
            //ustaw zdroweir na 100
            return "I go to sleep, do zobaczenia za 2 minuty.";
        }
        
    }
}
