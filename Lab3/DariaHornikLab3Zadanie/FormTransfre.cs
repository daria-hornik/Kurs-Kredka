using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariaHornikLab3Zadanie
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
            if (broadcaster.IsEnoughtToMakeTransfer(transferAmount))
            {
                //zapisanie w zminnej indexu, pod którym w liście w anku figuruje odbiorca
                int customersIndex = myBank.FindIndexCustometr(recipientNumer);
                //jeśli index jest mniejszy od 0 nie ma takiego klienta 
                if (customersIndex >= 0)
                {
                    //doładowanie stanu konta odbiorcy i wyświtlenie komunikatu, ze operacja się powiodła
                    myBank.customers[customersIndex].TopUpAccount(transferAmount);
                    MessageBox.Show("Przelew wykonany.");

                    //aktualzacja danych w bazie danych 
                    String query = "UPDATE Bank.dbo.Customer SET accountBalance = @balance WHERE accountsNumber = @account;";
                    SqlCommand command = new SqlCommand(query, myBank.connection);
                    command.Parameters.Add("@balance", myBank.customers[customersIndex].accountBalance);
                    command.Parameters.Add("@account", recipientNumer);
                    command.ExecuteNonQuery();

                    //aktualzacja danych w bazie danych 
                    String query2 = "UPDATE Bank.dbo.Customer SET accountBalance = @balance WHERE accountsNumber = @account;";
                    SqlCommand command2 = new SqlCommand(query2, myBank.connection);
                    command2.Parameters.Add("@balance", broadcaster.accountBalance);
                    command2.Parameters.Add("@account", broadcaster.accountsNumber);
                    command2.ExecuteNonQuery();


                    //zapis w historii banku
                    String query3 = "INSERT INTO Bank.dbo.Transfer VALUES(@source, @destiny, @money);";
                    SqlCommand command3 = new SqlCommand(query3, myBank.connection);
                    command3.Parameters.Add("@source", broadcaster.accountsNumber.ToString());
                    command3.Parameters.Add("@destiny", recipientNumer.ToString());
                    command3.Parameters.Add("@money", transferAmount.ToString());
                    command3.ExecuteNonQuery();

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
