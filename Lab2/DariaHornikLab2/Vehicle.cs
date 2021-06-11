using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab2
{
    abstract class Vehicle
    {
        protected int vehicleNumber, yearOfProduction;
        protected string name;

        /// <summary>
        /// MEtoda pobierająca numer pojazdu
        /// </summary>
        /// <returns></returns>
        public virtual int GetVehicleNumber()
        {
            return vehicleNumber;
        }

        /// <summary>
        /// Metoda pobierająca rok pojazdu
        /// </summary>
        /// <returns></returns>
        public virtual int GetYearProduction()
        {
            return yearOfProduction;
        }

        /// <summary>
        /// Metoda zwracjąca nazwe pojazdu
        /// </summary>
        /// <returns></returns>
        public virtual string GetName()
        {
            return name;
        }


        /// <summary>
        /// Metoda ustawiająca numer pojazdu
        /// </summary>
        /// <param name="n"></param>
        public virtual void SetVehicleNumber(int n)
        {
            vehicleNumber = n;
        }

        abstract public string StartVehicle();
        abstract public string StopVehicle();

    }
}
