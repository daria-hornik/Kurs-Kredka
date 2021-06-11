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
    internal partial class FormOrderInBookstore : Form
    {
        DariaHornikLab4Zadanie.Repositories.IBookstore<DariaHornikLab4Zadanie.Models.Warehouse> warehouse;
        DariaHornikLab4Zadanie.Repositories.IBookstore<DariaHornikLab4Zadanie.Models.Book> books;
        DariaHornikLab4Zadanie.Models.Client client;
        DariaHornikLab4Zadanie.Models.Address address;
        DariaHornikLab4Zadanie.Models.Warehouse ware;


        public FormOrderInBookstore(DariaHornikLab4Zadanie.Repositories.IBookstore<DariaHornikLab4Zadanie.Models.Warehouse> _warehouse, DariaHornikLab4Zadanie.Repositories.IBookstore<DariaHornikLab4Zadanie.Models.Book> _books, DariaHornikLab4Zadanie.Models.Address _address, DariaHornikLab4Zadanie.Models.Client _client)
        {
            InitializeComponent();
            warehouse = _warehouse;
            books = _books;
            address = _address;
            client = _client;
            LoadBooks();
        }

        /// <summary>
        /// aktualizacja nowych danych
        /// </summary>
        private void LoadBooks()
        {
            foreach(var x in warehouse.GetAll())
            {
                x.book = books.GetById(x.Id_Ware);
            }
            dataGridViewOrderInBookstore.DataSource = warehouse.GetAll();
        }

        /// <summary>
        /// kupno książki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrderInBookstore_Click(object sender, EventArgs e)
        {
            var selectedBookIndex = Int32.Parse(dataGridViewOrderInBookstore.SelectedRows[0].Cells[0].Value.ToString());
            var selectedBook = books.GetById(selectedBookIndex);
            List<DariaHornikLab4Zadanie.Models.Warehouse> list = warehouse.GetAll();
            foreach(var x in list)
             {
                 if(x.Id_Ware == selectedBookIndex)
                 {
                     ware = x;
                    ware.Id_Ware = x.Id_Ware;
                    ware.numberOfItems = x.numberOfItems--;
                    ware.book = x.book;
                 }
             }
            ware.numberOfItems--;
            books.Update(selectedBook);
            MessageBox.Show("Złożono zamówienie " + GetInformationAboutOrder());
        }


        /// <summary>
        /// aktualizacja danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefreshBookstore_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        /// <summary>
        /// zwrocenie informacji o zamówieniu
        /// </summary>
        /// <returns></returns>
        private string GetInformationAboutOrder()
        {
            return client.name + " " + client.surname + ", " + address.GetInformations();
        }

        /// <summary>
        /// reakcja na guzik sprzedaz książki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyToBookstore_Click(object sender, EventArgs e)
        {
            textBoxBookName.Visible = true;
            textBoxBookAutor.Visible = true;
            textBoxBookDate.Visible = true;
            textBoxBookLanguage.Visible = true;
            buttonAcceptSales.Visible = true;
            textBoxNumberOfItem.Visible = true;
        }


        /// <summary>
        /// sprzedaz ksiązki 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAcceptOrder_Click(object sender, EventArgs e)
        {
            string _title = textBoxBookName.Text;
            var _author = textBoxBookAutor.Text;
            var _language = textBoxBookLanguage.Text;
            var _date = Convert.ToDateTime(textBoxBookDate.Text);
            var numberOfItem = Int32.Parse(textBoxNumberOfItem.Text);

            DariaHornikLab4Zadanie.Models.Book newAddress = new DariaHornikLab4Zadanie.Models.Book
            {
                title = _title,
                author = _author,
                language = _language,
                releaseData = _date
            };
            newAddress.warehouse = new DariaHornikLab4Zadanie.Models.Warehouse { numberOfItems = numberOfItem, book = newAddress };
            books.Create(newAddress);
            books.Save();
            textBoxBookName.Visible = false;
            textBoxBookAutor.Visible = false;
            textBoxBookDate.Visible = false;
            textBoxBookLanguage.Visible = false;
            buttonAcceptSales.Visible = false;
            textBoxNumberOfItem.Visible = false;
            MessageBox.Show("Gratuluję, twoja ksiązka została wydana");
        }
    }
}
