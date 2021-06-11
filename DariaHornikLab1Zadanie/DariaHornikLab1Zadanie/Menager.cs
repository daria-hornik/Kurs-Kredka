using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariaHornikLab1Zadanie
{
    class Menager
    {
        //pola klasy
        FormStartPanel formStartPanel;
        FormSignUp formSignUp;
        FormMainPage formMainPage;
        Bank myBank;

        /// <summary>
        /// konstruktor klasy, odpowiada za zainicjalizowanie obiektu
        /// </summary>
        /// <param name="name"></param>
        public Menager(string name)
        {
            myBank = new Bank(name);
            formSignUp = new FormSignUp(myBank);
            formStartPanel = new FormStartPanel(myBank, formSignUp, formMainPage);

        }

        /// <summary>
        /// metoda zwracjąca referencje do obiektu pierwszego panelu
        /// </summary>
        /// <returns></returns>
        public FormStartPanel start()
        {          
            return formStartPanel;
        }

        /// <summary>
        /// etoda zwracjąca referencje do obiektu  panelu rejestracji
        /// </summary>
        /// <returns></returns>
        public FormSignUp registration()
        {
            return formSignUp;
        }









    }
}
