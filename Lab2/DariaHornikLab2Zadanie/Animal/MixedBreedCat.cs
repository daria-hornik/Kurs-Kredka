using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab2Zadanie
{
    class MixedBreedCat : Cat
    {
        //pola klasy
        protected bool catchAMouse;
        public int nr;

        //konstruktor
        public MixedBreedCat(int number)
        {
            age = 0;
            name = "Unknown";
            isPurring = true;
            catchAMouse = true;
            nr = number;
        }

        public override string Feed()
        {
            return "Wole sam sobie coś upolować, ale niech ci będzie, zjem to";
        }

        public override string MakeASound()
        {
            throw new NotImplementedException();
        }

        public override string Sleep()
        {
            return "Ale jestem zmęczzony, muszę odpoczać.";
        }
        
    }
}
