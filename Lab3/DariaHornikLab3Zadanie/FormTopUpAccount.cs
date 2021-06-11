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
    internal partial class FormTopUpAccount : Form
    {
        //pole klasy
        Customer myCustomer;
        SqlConnection connection;

        /// <summary>
        /// konstruktor klasy, odpowiada za zainicjalizowanie obiektu
        /// </summary>
        /// <param name="customer"></param>
        public FormTopUpAccount(Customer customer, SqlConnection _connection)
        {
            InitializeComponent();
            myCustomer = customer;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            connection = _connection;
        }

       

        /// <summary>
        /// kliknięcie w guzik wykonaj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTopUpAccount_Click(object sender, EventArgs e)
        {
            //dodanie pieniędzy na konto myCustomera i zamkniecie okna 
            myCustomer.TopUpAccount(float.Parse(textBoxTopUpAccount.Text));

            String query = "UPDATE Bank.dbo.Customer SET accountBalance = @money WHERE accountsNumber = @account; ";
            SqlCommand command = new SqlCommand(query, this.connection);
            command.Parameters.Add("@money", myCustomer.accountBalance.ToString());
            command.Parameters.Add("@account", myCustomer.accountsNumber);
            command.ExecuteNonQuery();
             this.Close();
        }

        private void textBoxTopUpAccount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
