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
    internal partial class FormAddNewBookstore : Form
    {
        DariaHornikLab4Zadanie.Repositories.IBookstore<DariaHornikLab4Zadanie.Models.Bookstore> bookstore;

        public FormAddNewBookstore(DariaHornikLab4Zadanie.Repositories.IBookstore<DariaHornikLab4Zadanie.Models.Bookstore> _bookstore)
        {
            InitializeComponent();
            bookstore = _bookstore;
        }


        /// <summary>
        /// dodanie księgarni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNewBookstore_Click_1(object sender, EventArgs e)
        {
            string _name = textBoxBookstoreName.Text;
            string _address = textBoxBookstoreAddress.Text;
            string _owner = textBoxBookstoreOwner.Text;

            DariaHornikLab4Zadanie.Models.Bookstore newBookstore = new DariaHornikLab4Zadanie.Models.Bookstore
            {
                name = _name,
                address = _address,
                owner = _owner
            };

            bookstore.Create(newBookstore);
            bookstore.Save();
            this.Close();
        }
    }
}
