using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariaHornikLab1Zadanie
{
    internal partial class FormTopUpAccount : Form
    {
        //pole klasy
        Customer myCustomer;

        /// <summary>
        /// konstruktor klasy, odpowiada za zainicjalizowanie obiektu
        /// </summary>
        /// <param name="customer"></param>
        public FormTopUpAccount(Customer customer)
        {
            InitializeComponent();
            myCustomer = customer;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void FormTopUpAccount_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// kliknięcie w guzik wykonaj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTopUpAccount_Click(object sender, EventArgs e)
        {
            //dodanie pieniędzy na konto myCustomera i zamkniecie okna 
            myCustomer.topUpAccount(float.Parse(textBoxTopUpAccount.Text));
            this.Close();
        }

        private void textBoxTopUpAccount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
