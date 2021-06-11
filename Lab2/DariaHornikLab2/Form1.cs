using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariaHornikLab2
{
    public partial class FormAplication : Form
    {
       //Lista pojazdów
        private List<Vehicle> vehiclesList = new List<Vehicle>();
        private int listIndex;
        private Vehicle vehicle;

        public FormAplication()
        {
            InitializeComponent();
            listIndex = 0;
        }

        private void FormNAme_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            //jeśli zaznaczono tramwaj 
            if (radioButtonTram.Checked)
            {
                //Utworzenie obiektu vehicle, który będzie tramwajem 
                vehicle = new Tram(Int32.Parse(textBoxVehicleNumber.Text),
                    Int32.Parse(textBoxYearOfProduction.Text), textBoxName.Text);
            }
            else
            {
                //Utworzenie obiektu vehicle, który będzie autobusem
                vehicle = new Bus(Int32.Parse(textBoxVehicleNumber.Text),
                    Int32.Parse(textBoxYearOfProduction.Text), textBoxName.Text);
            }
            //dodaj do listy pojazdów.
            vehiclesList.Add(vehicle);


            //czyszczenie poł tekstowych 
            textBoxName.Text = "";
            textBoxYearOfProduction.Text = "";
            textBoxVehicleNumber.Text = "";
               
        }

        /// <summary>
        /// Przejscie do poprzedniego elementu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            //Pobieranie danyh z listy
            vehicle = vehiclesList[Math.Abs(listIndex-- % vehiclesList.Count)];

            //Pobieranie parametrów obiektu z Vehicle.
            labelActualNumberDescription.Text = vehicle.GetVehicleNumber().ToString();
            labelActualYearDescription.Text = vehicle.GetYearProduction().ToString();
            labelActualModelDescription.Text = vehicle.GetName().ToString();

            //Jesli vehicle wskazuje na tramwaj
            if(vehicle is Tram)
            {
                labelActualVehicleDescription.Text = "Tramwaj";
            }
            else
            {
                labelActualVehicleDescription.Text = "Autobus";
            }


        }
        /// <summary>
        /// Przejscie do następnego elementu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            //Pobieranie danyh z listy
            vehicle = vehiclesList[Math.Abs(listIndex++ % vehiclesList.Count)];

            //Pobieranie parametrów obiektu z Vehicle.
            labelActualNumberDescription.Text = vehicle.GetVehicleNumber().ToString();
            labelActualYearDescription.Text = vehicle.GetYearProduction().ToString();
            labelActualModelDescription.Text = vehicle.GetName();

            //Jesli vehicle wskazuje na tramwaj
            if (vehicle is Tram)
            {
                labelActualVehicleDescription.Text = "Tramwaj";
            }
            else
            {
                labelActualVehicleDescription.Text = "Autobus";
            }

        }

        /// <summary>
        /// Ruszenie pojazdem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartVehicle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vehicle.StartVehicle());
        }

        /// <summary>
        /// Zatrzymanie pojazdu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopVehicle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vehicle.StopVehicle());

        }

        private void buttonBell_Click(object sender, EventArgs e)
        {
            if(vehicle is Tram)
            {
                Tram tram = (Tram)vehicle;
              MessageBox.Show(tram.Bell());
            }
            else
            {
                MessageBox.Show("Obiekt nie jest tramwajem.");
            }
        }

        private void buttonRefuel_Click(object sender, EventArgs e)
        {
            if(vehicle is Bus)
            {
                Bus bus = (Bus)vehicle;
                MessageBox.Show(bus.Refuel());
            }
            else
            {
                MessageBox.Show("Obiekt nie jest busem");
            }
           
        }

        /// <summary>
        /// Opuszczenie pantografu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPantographDown_Click(object sender, EventArgs e)
        {
            if(vehicle is Tram)
            {
                Tram tram = (Tram)vehicle;
                MessageBox.Show(tram.PantographDown());
            }
            else
            {
                MessageBox.Show("Wybrany obiekt nie jest tramwajem.");
            }
        }

        private void buttonPantographUp_Click(object sender, EventArgs e)
        {
            if (vehicle is Tram)
            {
                Tram tram = (Tram)vehicle;
                MessageBox.Show(tram.PantograpgUp());
            }
            else
            {
                MessageBox.Show("Wybrany obiekt nie jest tramwajem.");
            }
        }

    }
}
