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
    internal partial class FormTransfre : Form
    {
        // pola klasy
        public long recipientNumer;
        public float transferAmount;
        public Customer recipient;
        public Customer broadcaster;
        private Bank myBank;

        /// <summary>
        /// konstruktor klasy, odpowiada za zainicjalizowanie obiektu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="bank"></param>
        public FormTransfre(Customer sender, Bank bank)
        {
            InitializeComponent();
            this.broadcaster = sender;
            myBank = bank;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void labelInsideTransfer_Click(object sender, EventArgs e)
        {

        }

        private void textBoxrecipientsLogin_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// metoda wykonująca się po kliknięciu w guzik 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMakeTransfer_Click(object sender, EventArgs e)
        {
            //zapisanie danych z textBoxów w polach klasy
            string number = textBoxrecipientsNumber.Text;
            recipientNumer = Convert.ToInt64(number);
            transferAmount = float.Parse(textBoxTransferAmount.Text);
           //warunek jeśli adresat ma wystarczająco pieniędzy może wykonać przelew
            if (broadcaster.isEnoughtToMakeTransfer(transferAmount))
            {
                //zapisanie w zminnej indexu, pod którym w liście w anku figuruje odbiorca
                int customersIndex = myBank.findIndexCustometr(recipientNumer);
                //jeśli index jest mniejszy od 0 nie ma takiego klienta 
                if (customersIndex >= 0)
                {
                    //doładowanie stanu konta odbiorcy i wyświtlenie komunikatu, ze operacja się powiodła
                    myBank.customers[customersIndex].topUpAccount(transferAmount);
                    MessageBox.Show("Przelew wykonany.");
                }
                else
                {
                    //wyświtlenie komunikatu, ze operacja się nie powiodła
                    MessageBox.Show("Nie mamy klienta o takim numerze konta.");
                }

            }
            else
            {
                //wyświtlenie komunikatu, ze operacja się powiodła z powodu braku środków
                MessageBox.Show("Operacja się nie powiodła. Masz za mało środków na koncie.");

            }
            this.Close();
        }

        private void FormTransfre_Load(object sender, EventArgs e)
        {

        }
    }
}
