namespace DariaHornikLab1Zadanie
{
    partial class FormAdvertisement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdvertisement));
            this.labelAdvertisement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAdvertisement
            // 
            this.labelAdvertisement.AutoSize = true;
            this.labelAdvertisement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelAdvertisement.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.labelAdvertisement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAdvertisement.Location = new System.Drawing.Point(400, 429);
            this.labelAdvertisement.Name = "labelAdvertisement";
            this.labelAdvertisement.Size = new System.Drawing.Size(429, 21);
            this.labelAdvertisement.TabIndex = 0;
            this.labelAdvertisement.Text = "Dzięki reklamom korzystasz z naszej aplikacji za darmo.";
            // 
            // FormAdvertisement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 459);
            this.Controls.Add(this.labelAdvertisement);
            this.Name = "FormAdvertisement";
            this.Text = "Reklama";
            this.Load += new System.EventHandler(this.Formadvertisement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdvertisement;
    }
}