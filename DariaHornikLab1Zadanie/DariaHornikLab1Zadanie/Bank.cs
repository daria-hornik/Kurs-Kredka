using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab1Zadanie
{
    class Bank
    {
        //pola klasy
        public List<Customer> customers { get;  }
        public string name { get; }

        /// <summary>
        /// konstruktor klasy, odpowiada za zainicjalizowanie obiektu
        /// </summary>
        /// <param name="_name"></param>
        public Bank(string _name)
        {
            this.name = _name;
            this.customers = new List<Customer>();
        }

        /// <summary>
        /// metoda zwracająca informacje czy człowiek o podanych parametrach jest w bazie banku
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool isSuccessfulSignIn(string login, string password)
        {
            //zapisanei indexu, pod którym ten klient figuruje w bazie 
            int index = findIndexCustometr(login, password);
            //jeśli index jest mniejszy niż zero, nie ma takiego klienta w bazie 
            if(index>=0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// metoda dodająca do bazy banku nowego klienta o podanych parametrach  
        /// </summary>
        /// <param name="name"></param>
        /// <param name="subname"></param>
        /// <param name="login"></param>
        /// <param name="pin"></param>
        public void addNewCustomer(string name, string subname, string login, string pin)
        {
            //stworzenie obiektu klienta, wygenerowanie mu numeru konta i dodanie do list banku 
            Customer myNewCustomer = new Customer(name,  subname,  login,  pin);
            myNewCustomer.accountsNumber = generateAccountNumber();
            this.customers.Add(myNewCustomer);
        }

        /// <summary>
        /// metoda zwracająca index pod którym figuruje klient w liście, lub -1 w razie jego braku na podstaie loginu i pinu
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pin"></param>
        /// <returns></returns>
        public int findIndexCustometr(string login, string pin)
        {
            //przejście po liście 
            for (int i = 0; i < this.customers.Count; i++)
            {
                //sprawdzenie czy login klienta pod indexem i jest zgodny z parametrem przekazanym 
                if (customers[i].login == login)
                {
                    //sprawdzenie czy pin klienta pod indexem i jest zgodny z parametrem przekazanym 
                    if (customers[i].pin == pin)
                        return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// etoda zwracająca index pod którym figuruje klient w liście, lub -1 w razie jego braku na podstaie numeru konta 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int findIndexCustometr(long number)
        {
            for(int i=0; i<customers.Count; i++)
            {
                //sprawdzenie czy numer konta klienta pod indexem i jest zgodny z parametrem przekazanym 
                if (customers[i].accountsNumber == number)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// metoda generująca numer konta 
        /// </summary>
        /// <returns></returns>
        private long generateAccountNumber()
        {
            //stworzenie obiektu do losowania liczb i wylosowanie liczby naturalnej 
            Random generator = new Random();
            int id = generator.Next();
            //stworzenie numeru o początku 94, końcówce wylosowanej i reszcie wypełnionej do dziesięciu zerami
            string accountNumber = string.Format("94{0:D10}", id);
            //sprawdzenie czy takiego numeru już nie ma w bazie, jeśli jest rekurencyjne wywołane tej samej metody
            if(!isOnlyOneNumber(long.Parse(accountNumber)))
            {
                generateAccountNumber();
            }
            //zwrócenie numeru
            return long.Parse(accountNumber);
        }


        /// <summary>
        /// metoda sprwdająca czy podany numer jest jedyny na licie banku
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool isOnlyOneNumber(long number)
        {
            //przejście po liście i porównanie numerów , w razie równoście przerwanie poszukiwań i zwrócenie fals
            for(int i=0; i<customers.Count; i++)
            {
                if(customers[i].accountsNumber == number)
                {
                    return false;
                }
            }
            return true;
        }
    }

}
