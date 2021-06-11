using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariaHornikLab3Zadanie
{
    internal partial class FormSignUp : Form
    {
        //pola klasy
        public string name, surname, login, pin;
        public Bank myBank;

        /// <summary>
        /// konstruktor klasy, odpowiada za zainicjalizowanie obiektu
        /// </summary>
        /// <param name="bank"></param>
        public FormSignUp(Bank bank)
        {
            InitializeComponent();
            myBank = bank;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        /// <summary>
        /// metoda przechwytująca dane z textBoxa i zapisująca je w polu klasy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCustomersLogin_TextChanged(object sender, EventArgs e)
        {
            login = textBoxCustomersLogin.Text;
        }

        /// <summary>
        /// metoda przechwytująca dane z textBoxa i zapisująca je w polu klasy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCustomersPin_TextChanged(object sender, EventArgs e)
        {
            pin = textBoxCustomersPin.Text;
        }

        private void labelRegistration_Click(object sender, EventArgs e)
        {

        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// metoda przechwytująca dane z textBoxa i zapisująca je w polu klasy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCustomersSurname_TextChanged(object sender, EventArgs e)
        {
            surname = textBoxCustomersSurname.Text;
        }

        /// <summary>
        /// metoda przechwytująca dane z textBoxa i zapisująca je w polu klasy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBoxCustomersName.Text;
        }

        /// <summary>
        /// metoda dodająca nowego klienta do banku i zamykająca okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            myBank.AddNewCustomer(name, surname, login, pin);
            this.Close();
        }

    }
}
