using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab1Zadanie
{
    class Customer
    {
        //pola klasy
        public string name { get; }
        public string surname { get; }
        public string login { get; }
        public string pin { get; }
        public float accountBalance { get; set; }
        public long accountsNumber { get; set; }

        /// <summary>
        /// konstruktor klasy, odpowiada za zainicjalizowanie obiektu
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="login"></param>
        /// <param name="pin"></param>
        public Customer(string name, string surname, string login, string pin)
        {
            this.name = name;
            this.surname = surname;
            this.login = login;
            this.pin = pin;
            accountBalance = 0; 
        }

        /// <summary>
        /// przeciążony konstruktor klasy, odpowiada za zainicjalizowanie pól klasy
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="login"></param>
        /// <param name="pin"></param>
        /// <param name="number"></param>
        public Customer(string name, string surname, string login, string pin, long number)
        {
            this.name = name;
            this.surname = surname;
            this.login = login;
            this.pin = pin;
            accountBalance = number;
        }

        /// <summary>
        /// metoda zwracająca dane klienta 
        /// </summary>
        /// <returns></returns>
        public String customersData()
        {
            return "Imie i nazwisko:\n "+name + " " + surname+"\nNumer konta:\n "+accountsNumber;
        }

        /// <summary>
        /// metoda zwracająca wrażliwe dane klienta
        /// </summary>
        /// <returns></returns>
        public String CustomersInsitiveData()
        {
            return name + " " + surname + " " + pin;
        }

        /// <summary>
        /// metoda sprawdająca czy klient ma wystarczające środki na koncie, by wykonać przelew
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public bool isEnoughtToMakeTransfer(float money)
        {
            if(accountBalance < money)
            {
                return false;
            }
            accountBalance -= money;
            return true;
        }

        /// <summary>
        /// metoda dodająca środki na własne konto 
        /// </summary>
        /// <param name="money"></param>
        public void topUpAccount(float money)
        {
            accountBalance += money;
        }         
}
}
