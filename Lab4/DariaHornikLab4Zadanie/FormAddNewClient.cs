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
    internal partial class FormAddNewClient : Form
    {
        DariaHornikLab4Zadanie.Repositories.IBookstore<DariaHornikLab4Zadanie.Models.Client> client;
        DariaHornikLab4Zadanie.Repositories.IBookstore<DariaHornikLab4Zadanie.Models.Address> address;
        public FormAddNewClient(DariaHornikLab4Zadanie.Repositories.IBookstore<DariaHornikLab4Zadanie.Models.Client> _client, DariaHornikLab4Zadanie.Repositories.IBookstore<DariaHornikLab4Zadanie.Models.Address> _address)
        {
            InitializeComponent();
            client = _client;
            address = _address;
        }

        /// <summary>
        /// dodanie klienta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNewClient_Click(object sender, EventArgs e)
        {
            string _street = textBoxClientAddresStreet.Text;
            int _number = Int32.Parse(textBoxClientAddresHouseNumber.Text);
            int _zipcode = Int32.Parse(textBoxClientAddresZipCode.Text);
            string _city = textBoxClientAddressCity.Text;

            DariaHornikLab4Zadanie.Models.Address newAddress = new DariaHornikLab4Zadanie.Models.Address
            {
                street = _street,
                houseNumber = _number,
                ZipCode = _zipcode,
                city = _city
            };
            

            string _name = textBoxClientName.Text;
            string _surname = textBoxClientSurname.Text;
            DateTime _birthData = Convert.ToDateTime(textBoxClientBirthData.Text);

            DariaHornikLab4Zadanie.Models.Client newClient= new DariaHornikLab4Zadanie.Models.Client
            {
                name = _name,
                surname = _surname,
                birthData = _birthData,
                address = newAddress
            };

          newAddress.client = newClient;

            address.Save();
            client.Create(newClient);
            client.Save();
            
            this.Close();
        }
    }
}
