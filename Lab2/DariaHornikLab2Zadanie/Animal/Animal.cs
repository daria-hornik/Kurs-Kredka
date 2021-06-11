using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab2Zadanie
{
    abstract class Animal
    {
        //pola klasy
        public int age;
        public String name;
        public Stack<Illness> bookHealth;
        //geter i setter
        public int MyProperty { get; set; }

        //konstruktor
        public Animal()
        {
            age = 1;
            name = "Unknown";
            bookHealth = new Stack<Illness>();
           
        }
        //konstruktor
        public Animal(int _age, string _name)
        {
            age = _age;
            name = _name;
            bookHealth = new Stack<Illness>();
        }

        //metody abstrakcyjne
        abstract public string Feed();
        abstract public string Sleep();
        abstract public string MakeASound();

    }
}
