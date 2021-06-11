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
    internal partial class FormAdministratorPage : Form
    {
        SqlConnection connection;
        private Bank bank;

        public FormAdministratorPage(SqlConnection _conn, Bank mybank)
        {
            bank = mybank;
            InitializeComponent();
            connection = _conn;
        }

        private void FormAdministratorPage_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter;

            try
            {
                String query = "SELECT * FROM dbo.Customer;";
                adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewCustomersData.DataSource = dataTable;
                dataGridViewCustomersData.Show();
            }
            catch (Exception ex)
            {
                connection.Close();
            }

        }

        private void buttonNextPageForAdministrator_Click(object sender, EventArgs e)
        {
            if(bank.AmIAdministrator(textBoxAdministratorLogin.Text.ToString(), maskedTextBoxAdministratorPassword.Text.ToString()))
            {
                panelSignUpForAdministrator.Visible = false;
                panelCustomersData.Visible = true;
            }
            else
            {
                MessageBox.Show("błędne dane administratora");
                this.Close();
            }
        }

        private void buttonRemoveAccount_Click(object sender, EventArgs e)
        {
            textBoxNumberRemovingAccount.Visible = true;
            buttonAcceptRemovingAccount.Visible = true;

        }

        private void buttonAcceptRemovingAccount_Click(object sender, EventArgs e)
        {
            try
            {
                String query = " DELETE FROM dbo.Customer WHERE accountsNumber=@accountnum;";
                SqlCommand command = new SqlCommand(query, this.connection);
                command.Parameters.Add("@accountnum", textBoxNumberRemovingAccount.Text.ToString());
                command.ExecuteNonQuery();
                dataGridViewCustomersData.Update();
                MessageBox.Show("Konto zostanie usunięte przy najbliższym wylogowaniu");
                textBoxNumberRemovingAccount.Visible = false;
                buttonAcceptRemovingAccount.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Operacja się nie powiodła");
            }
           
        }
    }

}