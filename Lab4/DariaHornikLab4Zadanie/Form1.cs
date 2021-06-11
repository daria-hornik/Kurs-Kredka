using DariaHornikLab4Zadanie;
using HomewDariaHornik.Lab4Zadanieork4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariaHornikLab4Zadanie
{

    public partial class FormMainPage : Form
    {
        private readonly Repositories.IBookstore<Models.Book> book;
        private readonly Repositories.IBookstore<Models.Address> address;
        private readonly Repositories.IBookstore<Models.Bookstore> bookstore;
        private readonly Repositories.IBookstore<Models.Client> client;
        private readonly Repositories.IBookstore<Models.Warehouse> warehous;


        private FormAddNewClient formNewClient;
        private FormAddNewBookstore formAddNewBookstore;
        private FormEditClient formEditClient;
        private FormEditBookstore formEditBookstore;
        private FormOrderInBookstore formOrderInBookstore;

        public FormMainPage()
        {
            InitializeComponent();
            book = new Repositories.BookstoreGeneric<Models.Book>();
            address = new Repositories.BookstoreGeneric<Models.Address>();
            bookstore = new Repositories.BookstoreGeneric<Models.Bookstore>();
            client = new Repositories.BookstoreGeneric<Models.Client>();
            warehous = new Repositories.BookstoreGeneric<Models.Warehouse>();
            LoadBookstores();
            LoadClients();

        }

        /// <summary>
        /// załadowanie klientów do grida
        /// </summary>
        private void LoadClients()
        {
            dataGridViewClientData.DataSource = client.GetAll();

        }

        /// <summary>
        /// załadowanie księgarni do grida
        /// </summary>
        private void LoadBookstores()
        {
            dataGridViewBookstoreData.DataSource = this.bookstore.GetAll();
        }


        /// <summary>
        /// reakcja na guzik dodaj nowego klienta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            formNewClient = new FormAddNewClient(client, address);
            formNewClient.Show();
        }


        /// <summary>
        /// usuwanie klienta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveClient_Click(object sender, EventArgs e)
        {
            var selectedClientIndex = Int32.Parse(dataGridViewClientData.SelectedRows[0].Cells[0].Value.ToString());
            var deleteClient = client.GetById(selectedClientIndex);
            var delectedAddress = address.GetById(selectedClientIndex);

            address.DeleteById(delectedAddress.Id_Address);
            address.Save();

            client.DeleteById(deleteClient.Id_Client);
            client.Save();
            LoadClients();
        }


        /// <summary>
        /// edycja klienta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(dataGridViewClientData.SelectedRows[0].Cells[0].Value.ToString());
            formEditClient = new FormEditClient(client, index);
            formEditClient.Show();
        }


        /// <summary>
        /// Dodanie nowej księgarni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBookstore_Click(object sender, EventArgs e)
        {
            formAddNewBookstore = new FormAddNewBookstore(bookstore);
            formAddNewBookstore.Show();
        }


        /// <summary>
        /// usunięcie księgarni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveBookstore_Click(object sender, EventArgs e)
        {
            var selectedBookstoreIndex = Int32.Parse(dataGridViewBookstoreData.SelectedRows[0].Cells[0].Value.ToString());
            var deleteBookstore = bookstore.GetById(selectedBookstoreIndex);

            bookstore.DeleteById(deleteBookstore.Id_Bookstore);
            bookstore.Save();
            LoadBookstores();
        }


        /// <summary>
        /// Zaktualizowanie danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefreshData_Click(object sender, EventArgs e)
        {
            LoadClients();
            LoadBookstores();
        }


        /// <summary>
        /// przejście do zakupów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmitOrderForThisPerson_Click(object sender, EventArgs e)
        {
            var selectedClientIndex = Int32.Parse(dataGridViewClientData.SelectedRows[0].Cells[0].Value.ToString());
            var selectedClient = client.GetById(selectedClientIndex);
            var selectedAddress = address.GetById(selectedClientIndex);
            
            formOrderInBookstore = new FormOrderInBookstore(warehous, book, selectedAddress, selectedClient);
            formOrderInBookstore.Show();
        }


        /// <summary>
        /// edycja księgarni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditBookstore_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(dataGridViewBookstoreData.SelectedRows[0].Cells[0].Value.ToString());
            formEditBookstore = new FormEditBookstore(bookstore, index);
            formEditBookstore.Show();
        }

       
    }
}
