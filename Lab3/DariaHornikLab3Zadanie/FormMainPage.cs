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
    internal partial class FormMainPage : Form
    {
        //pola klasy
        int clock = 15;
        Bank myBank;
        Customer myCustomer;
        int secondsCounter = 0;

        /// <summary>
        /// konstruktor klasy, odpowiada za zainicjalizowanie obiektu
        /// </summary>
        /// <param name="bank"></param>
        /// <param name="customer"></param>
        public FormMainPage(Bank bank, Customer customer)
        {
            InitializeComponent();
            myBank = bank;
            myCustomer = customer;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        /// <summary>
        /// metoda wykonująca podane działania co jeden takt komputera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //zmniejszanie zmiennej clock, odpowiadjącej za czas sesji, co 1 minute
            if(secondsCounter == 60)
            {
                clock--;
                labelClock.Text = "Do końca sesji pozostało: "+ clock.ToString()+" minut.";
                //warunek sprawdający czy czas sesji się już nie skończył, jeśli tak, wylogowuje użytkownika 
                if (clock == -1)
                {
                    MessageBox.Show("Czas sesji minął, zostałeś wylogowany.");
                    this.Close();
                }

                //ostrzezenie, ze pozostało mało czasu, messageBox czy przedłużyć sesje 
                else if (clock == 2)
                {
                    string message = "Pozostała ci minuta, do końca sesji, czy chcesz przedłużyć swoją obecność na naszej stronie.";
                    if (MessageBox.Show(message, "Nowa sesja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        clock = 15;
                        labelClock.Text = "Do końca sesji pozostało: " + clock.ToString() + " minut.";
                        timerClock.Start();
                    }
                }

                //pojawiająca sie w 5 minucie reklama, żeby utrudnic użytkownikowi życie 
                else if (clock == 5)
                {
                    FormAdvertisement formAdvertisement = new FormAdvertisement();
                    formAdvertisement.Show();
                }
                
                secondsCounter = 0;
            }
          
            //ustawienie zakresu paska postępu (od 0 do 15 min) i zwiekszanie go 
            progressBarTimetoEnd.Maximum = 900;
            progressBarTimetoEnd.Minimum = 0;
            progressBarTimetoEnd.Increment(1);
          
            

           // warunek odpowiadający za poruszanie się consolek
            if(secondsCounter % 2 == 0)
            {
                labelAccountsBallance.Left += 10;
                buttonRefreshData.Left += 10;
                buttonBankOffer.Left -= 10;
                buttonTransfer.Left += 10;
                buttonLog.Left -= 10;
            }
            else
            {
                labelAccountsBallance.Left -= 10;
                buttonRefreshData.Left -= 10;
                buttonBankOffer.Left += 10;
                buttonTransfer.Left -= 10;
                buttonLog.Left += 10;
            }
            secondsCounter++;
        }

        /// <summary>
        /// metoda aktywująca forme, consolki i zminne w stani początkowy
        /// </summary>
        private void FormMainPage_Load(object sender, EventArgs e)
        {
            labelBanksData.Text = myBank.name;
            labelDatasOwner.Text = myCustomer.CustomersData();
            labelMoney.Text = myCustomer.accountBalance.ToString()+ " zł";
            labelClock.Text = "Do końca sesji pozostało: " + clock.ToString() + " minut.";
            timerClock.Start();
        }

        private void labelClock_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBarTimetoEnd_Click(object sender, EventArgs e)
        {
           
        }

        private void labelOwnersData_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Metoda wyświetlająca w labelu dane użytkownika 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDatasOwner_Click(object sender, EventArgs e)
        {
            ///pobranie informacji od Klienta i zapisanie ich w labelu 
            labelDatasOwner.Text ="Twoje dane: \n"+ myCustomer.CustomersData();
        }

        private void labelMoney_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// kliknięcie w guzik powoduje otwarcie nowego okna, w którym będzie można wyonać przelew
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            //stworzenie nowego obiektu FormTransfer i wyświetlenie go 
            FormTransfre formTransfre = new FormTransfre(myCustomer, myBank);
            formTransfre.Show();
        }

        /// <summary>
        /// kliknięcie w guzik powoduje otwarcie nowego okna, w którym możemy doładować sobie jednorazowo(w czasie sesji) konto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBankOffer_Click(object sender, EventArgs e)
        {
            //stworzenie nowego obiektu FormTransfer i wyświetlenie go 
            FormTopUpAccount formTopUpAccount = new FormTopUpAccount(myCustomer, myBank.connection);
            formTopUpAccount.Show();
            //zablokowanie guzika
            buttonBankOffer.Enabled = false;
        }

       
        /// <summary>
        /// guzik wylogowujący
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBlik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// kliknięcie w guzik powoduje zaktualizowanie danych o stanie konta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefreshData_Click(object sender, EventArgs e)
        {
            labelMoney.Text = myCustomer.accountBalance.ToString()+" zł";
        }

        private void labelClock_Click_1(object sender, EventArgs e)
        {

        }
    }
}
