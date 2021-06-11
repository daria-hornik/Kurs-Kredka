using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariaHornikLab1Zadanie
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()

        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //stworzenie obiektu, który zarądza 
            Menager myMenager = new Menager("Miaraculum");
            Application.Run(myMenager.start());

        }
    }
}
