using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariaHornikLab1
{
    public partial class FormMain : Form
    {
        int numberOne = 0;
        int numberTwo = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Przycisk zmieniajacy kolor programu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColor_Click(object sender, EventArgs e)
        {
            //zmiana koloru tła
            BackColor = Color.Silver;
            buttonColor.BackColor = Color.SeaGreen;
        
    
        }

  

        /// <summary>
        /// Funkcja uruchamiająca obliczenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCount_Click(object sender, EventArgs e)
        {
            //Zamiana typu zmiennych
            numberOne = Int32.Parse(textBoxCount.Text);
            numberTwo = Int32.Parse(textBoxCount2.Text);

           // nowe okno
            MessageBox.Show("Dodawanie: "+add(numberOne, numberTwo).ToString(), "Mnożenie: "+(numberTwo * numberOne).ToString());
          
            if(numberOne>30)
            {
                textBoxCount.BackColor = Color.Azure;
            }


        }


        /// <summary>
        /// funkcja zwracajaca sume dwóch liczb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int add(int a, int b)
        {
            return a + b;
        }


        /// <summary>
        /// funkcja zwracajaca różnice dwóch liczb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int sub(int a, int b)
        {
            return a-b;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///Funkcja włączająca timer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerCount.Interval = 1000;
            timerCount.Start();
        }

        /// <summary>
        /// Fukcja odpowiadająca za timer  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCount_Tick(object sender, EventArgs e)
        {
            //zwiekszanie liczby 
            numberOne++;

            //wyświetanie 
            textBoxCount.Text = numberOne.ToString();
            
            //Funkcja zmieniająca kolor tła
            if (numberOne % 2 == 0)
            {
                BackColor = Color.LightGray;
                buttonStart.Left += numberOne;
            }
            else
                BackColor = Color.Gray;
        }


        /// <summary>
        /// funkcja otwierająca nowe okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            //tworzenie nowego obiektu
            FormAbout formAbout = new FormAbout();

            //wyświetlenie okna 
            formAbout.formName = "Daria";
            formAbout.Show(); //showDialog ->okno, z którego nie da się wyjść, dopóki się go nie zamknie 
           
        }
    }
}
