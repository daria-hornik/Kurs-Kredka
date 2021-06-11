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
    internal partial class FormEditClient : Form
    {
        DariaHornikLab4Zadanie.Repositories.IBookstore<DariaHornikLab4Zadanie.Models.Client> client;
        int index;

        public FormEditClient(DariaHornikLab4Zadanie.Repositories.IBookstore<DariaHornikLab4Zadanie.Models.Client> _client, int _index)
        {
            InitializeComponent();
            client = _client;
            index = _index;
        }

        /// <summary>
        /// Zapisanie nowych danych 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveNewClientData_Click(object sender, EventArgs e)
        { 
            var editedClient = client.GetById(index);
            editedClient.name = textBoxNewClientName.Text;
            editedClient.surname = textBoxNewClientSurname.Text;
            editedClient.birthData = Convert.ToDateTime(textBoxNewBirthDateClient.Text);

            client.Update(editedClient);
            client.Save();
            this.Close();
        }
    }
}
