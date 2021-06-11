using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariaHornikLab2Zadanie
{
    internal partial class FormPark : Form
    {
        PetOwner petOwner;
        int counterCoins = 0;

        public FormPark(PetOwner _petOwner)
        {
            InitializeComponent();
            petOwner = _petOwner;
        }

        private void buttonGetOutOfThePArk_Click(object sender, EventArgs e)
        {
            timerForMoney.Stop();
            this.Visible = false;
        }

        private void pictureBoxFreeMoney_Click(object sender, EventArgs e)
        {
            counterCoins++;
            labelAmountOfCoins.Text = counterCoins.ToString();
            petOwner.money += 10;
            pictureBoxFreeMoney.Visible = false;
            Thread.Sleep(3000);
            pictureBoxFreeMoney.Visible = true;
        }

        private void timerForMoney_Tick(object sender, EventArgs e)
        {
            int width = this.Width;
            int height = this.Height;
            pictureBoxFreeMoney.Location = new Point((pictureBoxFreeMoney.Location.X + 1000)%width, (pictureBoxFreeMoney.Location.Y+2000)&height);
         
        }

        private void FormPark_Load(object sender, EventArgs e)
        {
            timerForMoney.Start();
        }
    }
}
