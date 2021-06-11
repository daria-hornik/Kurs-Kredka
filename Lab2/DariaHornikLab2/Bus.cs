using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab2
{
    class Bus : Vehicle
    {
        int gasoilLevel;

        /// <summary>
        /// Konstruktor klasy bus.
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Bus(int nr, int year, string mod)
        {
            vehicleNumber = nr;
            yearOfProduction = year;
            name = mod;
        }

        /// <summary>
        /// Metoda zwracająca informacje o zatankowaniu autobusa.
        /// </summary>
        /// <returns></returns>
        public string Refuel()
        {
            gasoilLevel = 100;
            return "Autobus został zatankowany.";
        }

        
        public override string StartVehicle()
        {
            return "Autobus odjeżdza.";
        }

        public override string StopVehicle()
        {
            return "autobus przyjechał.";
        }
    }
}
