using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariaHornikLab3Zadanie
{
    class Menager
    {
        //pola klasy
        FormStartPanel formStartPanel;
        FormSignUp formSignUp;
        FormMainPage formMainPage;
        Bank myBank;
        SqlConnection connection = new SqlConnection(@"Data Source =DESKTOP-7V7FK5M\ELENTIYA; Initial Catalog = Bank; User ID = sa; Password =Nehemia7");
        
        
        /// <summary>
        /// konstruktor klasy, odpowiada za zainicjalizowanie obiektu
        /// </summary>
        /// <param name="name"></param>
        public Menager(string name)
        {
            myBank = new Bank(name, connection);
            formSignUp = new FormSignUp(myBank);
            formStartPanel = new FormStartPanel(myBank, formSignUp, formMainPage, connection);

        }

        /// <summary>
        /// metoda zwracjąca referencje do obiektu pierwszego panelu
        /// </summary>
        /// <returns></returns>
        public FormStartPanel Start()
        {
            return formStartPanel;
        }

        /// <summary>
        /// etoda zwracjąca referencje do obiektu  panelu rejestracji
        /// </summary>
        /// <returns></returns>
        public FormSignUp Registration()
        {
            return formSignUp;
        }
    }
}
