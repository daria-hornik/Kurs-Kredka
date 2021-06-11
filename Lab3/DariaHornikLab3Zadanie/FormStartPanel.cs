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
    internal partial class FormStartPanel : Form
    {
        //pola klasy
        public Bank myBank { get;}
        private FormMainPage formMainPage;
        private FormSignUp formSignUp;
        private FormAdministratorPage formAdministratorPage;
        private int counter = 0;
        SqlConnection connection;

        /// <summary>
        /// konstruktor klasy, odpowiada za zainicjalizowanie obiektu
        /// </summary>
        /// <param name="bank"></param>
        /// <param name="formSignUp"></param>
        /// <param name="formMAinPage"></param>
        public FormStartPanel(Bank bank, FormSignUp formSignUp, FormMainPage formMAinPage, SqlConnection conn)
        {
            InitializeComponent();
            myBank = bank;
            formSignUp = new FormSignUp(myBank);
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            connection = conn;
        }
        
        /// <summary>
        /// metoda inicjalizująca pola textBoxów
        /// </summary>
        private void initialSettings()
        {
            textBoxLogin.Text = "Login";
            textBoxPassword.Text = "Password";
        }


        /// <summary>
        /// metoda wykonująca się po kliknięciu na guzik Zaloguj 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            //zapisanie do zminnej czy użytkownik o podanych w textBoxach parametrach istnieje w bazie banku
            bool isLogIn = this.myBank.isSuccessfulSignIn(textBoxLogin.Text, textBoxPassword.Text);
            //jeśli tak to:
            if (isLogIn)
            {
                //tworzymy obiekt FormMainPage i wyświetlamy, a strone poprzednią przywracamy do początkowych ustawień 
                //formMainPage = new FormMainPage(myBank, myBank.customers[myBank.findIndexCustometr(textBoxLogin.Text, textBoxPassword.Text)]); ;



                String query = "SELECT name , surname, login, pin,  accountBalance, accountsNumber  FROM Bank.dbo.Customer  WHERE login = @login AND pin = @pin;";
                SqlCommand command = new SqlCommand(query, this.connection);     
                command.Parameters.Add("@login", textBoxLogin.Text);
                command.Parameters.Add("@pin", textBoxPassword.Text);
                command.ExecuteNonQuery();
                
                SqlDataReader dataReader;
                SqlDataAdapter adapter = new SqlDataAdapter(); 
                dataReader = command.ExecuteReader();
              
                if(dataReader.Read())
                {
                    formMainPage = new FormMainPage(myBank, new Customer(dataReader.GetValue(0).ToString(), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString(), dataReader.GetValue(3).ToString(), long.Parse(dataReader.GetValue(4).ToString()), long.Parse(dataReader.GetValue(5).ToString())));
                    formMainPage.Show();
                    initialSettings();
                    timerStartsPanel.Stop();
                    dataReader.Close();
                }
               
                 
            }
             else
             {
                 //jeśli w bazie nie ma takiego użytkownika, messagebox informuje o tym
                MessageBox.Show("Błędnie wprowadzone parametry!");
                this.initialSettings();

            }
        }

        /// <summary>
        /// metoda po kliknięciu w guzik, otwiera nowe okno i wyśiwtla je
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            formSignUp = new FormSignUp(myBank);
            formSignUp.Show();
            timerStartsPanel.Stop();
        }


        /// <summary>
        /// metoda ładująca komponenty okna do wyświtlenia 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormStartPanel_Load(object sender, EventArgs e)
        {
            //włączamy timer
            timerStartsPanel.Start();
        }

        /// <summary>
        /// metoda wykonująca się co takt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerStartsPanel_Tick(object sender, EventArgs e)
        {
            //warunek poruszający pictureBoxem 
            counter++;
            if(counter%2 == 0)
            {
                pictureBoxMiraculum.Left += 20;
            }
            else
            {
                pictureBoxMiraculum.Left -= 20;
            }
        }

        private void buttonAdministrator_Click(object sender, EventArgs e)
        {
                formAdministratorPage = new FormAdministratorPage(connection, myBank);
                formAdministratorPage.Show();
          
        }
    }
}
