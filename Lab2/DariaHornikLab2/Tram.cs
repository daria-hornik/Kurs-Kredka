using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab2
{
    class Tram : Vehicle, IPantograph
    {
        bool pantographIsDown;

        /// <summary>
        /// Konstruktor klasy tramwaj.
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Tram(int nr, int year, string mod)
        {
            vehicleNumber = nr;
            yearOfProduction = year;
            name = mod;
            pantographIsDown = false;
        }

        /// <summary>
        /// Metoda podnosząca pantograf. Metoda z interfejsu.
        /// </summary>
        /// <returns></returns>
        public string PantograpgUp()
        {
            if (pantographIsDown)
            {
                pantographIsDown = false;
                return "Pantograf podniesiony";
            }
            else return "Pantorgaf już podniesiony";
        }

        /// <summary>
        /// Metoda opuszczająca pantograf. Metoda z interfejsu.
        /// </summary>
        /// <returns></returns>
        public string PantographDown()
        {
            if (!pantographIsDown)
            {
                pantographIsDown = true;
                return "Pantograf opuszczony";
            }
            else return "Pantograf już opuszczony.";

        }

        /// <summary>
        /// Dzwonienie tramwaju.
        /// </summary>
        /// <returns></returns>
        public string Bell()
        {
            return "Tramwaj dzwoni!";
        }
        /// <summary>
        /// Metoda informująca o starcie jazdy.
        /// </summary>
        /// <returns></returns>
        public override string StartVehicle()
        {
            if (pantographIsDown)
            {
                return "Tramwaj odjechał.";
            }
            return "Tramwaj nie może odjechać. Pantograf jest opuszczony.";
        }


        /// <summary>
        /// Metoda informująca że tramwaj się zatrzymał.
        /// </summary>
        /// <returns></returns>
        public override string StopVehicle()
        {
            return "Tramwaj się zatrzymuje.";
        }
    }
}
