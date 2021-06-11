using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab2Zadanie
{
    class PetOwner
    {
        //pola klasy
        public string name;
        public double money;
        private string password;
        public List<Animal> myPets;

        //konstruktor
        public PetOwner(string _name, double _money)
        {
            name = _name;
            money = _money;
            myPets = new List<Animal>();
        }

        //konstruktor
        public PetOwner()
        {
            name = "Kasida";
            money = 10000;
            myPets = new List<Animal>();
        }


        /// <summary>
        /// zmian imienia
        /// </summary>
        /// <param name="name"></param>
        public void setName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// zmiana hasla
        /// </summary>
        /// <param name="password"></param>
        public void setPassword(string password)
        {
            this.password = password;
        }

        /// <summary>
        /// zakup zwierzecia
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="number"></param>
        /// <param name="price"></param>
        public void BuyAnimal(Animal animal, int number, double price)
        {
            if (animal is Dog)
            {
                myPets.Add(new Dog(number));
            }
            else if (animal is MixedBreedCat)
            {
                myPets.Add(new MixedBreedCat(number));
            }
            else
            {
                myPets.Add(new PurebredCat(number));
            }
            money -= price;
        }

        /// <summary>
        /// metoda sprawdzająca czy danego czlowieka stac na dany zakup
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public bool canAfford(int price)
        {
            return price <= money;
        }
    }
}
