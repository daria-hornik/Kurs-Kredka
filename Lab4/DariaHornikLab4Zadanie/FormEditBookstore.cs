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
    internal partial class FormEditBookstore : Form
    {
        DariaHornikLab4Zadanie.Repositories.IBookstore<DariaHornikLab4Zadanie.Models.Bookstore> bookstore;
        private int index;
        public FormEditBookstore(DariaHornikLab4Zadanie.Repositories.IBookstore<DariaHornikLab4Zadanie.Models.Bookstore> _bookstore, int _index)
        {
            InitializeComponent();
            bookstore = _bookstore;
            index = _index;
        }

        /// <summary>
        /// zapisanie edycji księgarni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveNewBookstoreData_Click(object sender, EventArgs e)
        {
            var editedBookstore = bookstore.GetById(index);
            editedBookstore.name = textBoxNewBookstoreName.Text;
            editedBookstore.address = textBoxNewBookstoreAddress.Text;
            editedBookstore.owner = textBoxNewBookstoreOwner.Text;

            bookstore.Update(editedBookstore);
            bookstore.Save();
            this.Close();
        }
    }
}
