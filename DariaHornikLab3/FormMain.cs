using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariaHornikLab3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            SignIn sign = new SignIn(textBoxUserName.Text, textBoxPassword.Text);
            FormWarehouse formWarehouse = new FormWarehouse();

            if(sign.SignInWarehouse())
            {
                formWarehouse.Show();
            }
            else
            {
                MessageBox.Show("Nie udało się.");
            }


        }
    }
}
