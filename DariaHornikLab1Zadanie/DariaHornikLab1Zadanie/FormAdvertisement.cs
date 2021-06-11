using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariaHornikLab1Zadanie
{
    public partial class FormAdvertisement : Form
    {
        /// <summary>
        /// konstruktor, tworzy obiekt 
        /// </summary>
        public FormAdvertisement()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void Formadvertisement_Load(object sender, EventArgs e)
        {

        }
    }
}
