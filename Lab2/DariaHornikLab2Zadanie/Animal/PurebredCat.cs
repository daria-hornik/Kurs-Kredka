using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab2Zadanie
{
    class PurebredCat : Cat
    {
        //pola klasy
        protected string breed;
        public int nr;

        //konstruktor
        public PurebredCat(int number)
        {
            age = 0;
            name = "Unknown";
            isPurring = true;
            breed = "Kot syjamski";
            nr = number;
        }
        //konstruktor
        public PurebredCat(string _breed)
        {
            age = 0;
            name = "Unknown";
            isPurring = true;
            breed = _breed;
        }


        public override string Feed()
        {
            return "Najlepsze jedzenie, dla najlepszego kota. Dziękuję.";
        }

        public override string MakeASound()
        {
            throw new NotImplementedException();
        }

        public override string Sleep()
        {
           return "Trzeba dbać o siebie, któtka drzemka jeszcze nikomu nie zaszkodziła.";
        }

    }
}
