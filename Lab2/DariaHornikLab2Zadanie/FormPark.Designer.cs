namespace DariaHornikLab2Zadanie
{
    partial class FormPark
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelPark = new System.Windows.Forms.Panel();
            this.labelAmountOfCoins = new System.Windows.Forms.Label();
            this.labelCounterCoins = new System.Windows.Forms.Label();
            this.buttonGetOutOfThePArk = new System.Windows.Forms.Button();
            this.pictureBoxFreeMoney = new System.Windows.Forms.PictureBox();
            this.timerForMoney = new System.Windows.Forms.Timer(this.components);
            this.panelPark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFreeMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPark
            // 
            this.panelPark.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPark.BackgroundImage = global::DariaHornikLab2Zadanie.Properties.Resources.park;
            this.panelPark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPark.Controls.Add(this.labelAmountOfCoins);
            this.panelPark.Controls.Add(this.labelCounterCoins);
            this.panelPark.Controls.Add(this.buttonGetOutOfThePArk);
            this.panelPark.Controls.Add(this.pictureBoxFreeMoney);
            this.panelPark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelPark.Location = new System.Drawing.Point(0, 0);
            this.panelPark.Name = "panelPark";
            this.panelPark.Size = new System.Drawing.Size(800, 449);
            this.panelPark.TabIndex = 0;
            // 
            // labelAmountOfCoins
            // 
            this.labelAmountOfCoins.AutoSize = true;
            this.labelAmountOfCoins.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelAmountOfCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelAmountOfCoins.Location = new System.Drawing.Point(13, 49);
            this.labelAmountOfCoins.Name = "labelAmountOfCoins";
            this.labelAmountOfCoins.Size = new System.Drawing.Size(15, 16);
            this.labelAmountOfCoins.TabIndex = 2;
            this.labelAmountOfCoins.Text = "0";
            // 
            // labelCounterCoins
            // 
            this.labelCounterCoins.AutoSize = true;
            this.labelCounterCoins.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCounterCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelCounterCoins.Location = new System.Drawing.Point(13, 20);
            this.labelCounterCoins.Name = "labelCounterCoins";
            this.labelCounterCoins.Size = new System.Drawing.Size(114, 16);
            this.labelCounterCoins.TabIndex = 1;
            this.labelCounterCoins.Text = "Złapane monety: ";
            // 
            // buttonGetOutOfThePArk
            // 
            this.buttonGetOutOfThePArk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGetOutOfThePArk.AutoSize = true;
            this.buttonGetOutOfThePArk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGetOutOfThePArk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonGetOutOfThePArk.Location = new System.Drawing.Point(674, 11);
            this.buttonGetOutOfThePArk.Name = "buttonGetOutOfThePArk";
            this.buttonGetOutOfThePArk.Size = new System.Drawing.Size(75, 26);
            this.buttonGetOutOfThePArk.TabIndex = 0;
            this.buttonGetOutOfThePArk.Text = "Wyjdz";
            this.buttonGetOutOfThePArk.UseVisualStyleBackColor = false;
            this.buttonGetOutOfThePArk.Click += new System.EventHandler(this.buttonGetOutOfThePArk_Click);
            // 
            // pictureBoxFreeMoney
            // 
            this.pictureBoxFreeMoney.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFreeMoney.BackgroundImage = global::DariaHornikLab2Zadanie.Properties.Resources.coin;
            this.pictureBoxFreeMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFreeMoney.Location = new System.Drawing.Point(54, 304);
            this.pictureBoxFreeMoney.Name = "pictureBoxFreeMoney";
            this.pictureBoxFreeMoney.Size = new System.Drawing.Size(84, 58);
            this.pictureBoxFreeMoney.TabIndex = 0;
            this.pictureBoxFreeMoney.TabStop = false;
            this.pictureBoxFreeMoney.Click += new System.EventHandler(this.pictureBoxFreeMoney_Click);
            // 
            // timerForMoney
            // 
            this.timerForMoney.Interval = 800;
            this.timerForMoney.Tick += new System.EventHandler(this.timerForMoney_Tick);
            // 
            // FormPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.panelPark);
            this.Name = "FormPark";
            this.Text = "Park";
            this.Load += new System.EventHandler(this.FormPark_Load);
            this.panelPark.ResumeLayout(false);
            this.panelPark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFreeMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPark;
        private System.Windows.Forms.Button buttonGetOutOfThePArk;
        private System.Windows.Forms.PictureBox pictureBoxFreeMoney;
        private System.Windows.Forms.Timer timerForMoney;
        private System.Windows.Forms.Label labelAmountOfCoins;
        private System.Windows.Forms.Label labelCounterCoins;
    }
}