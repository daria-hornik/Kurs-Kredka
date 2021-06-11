namespace DariaHornikLab4Zadanie
{
    partial class FormAddNewBookstore
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
            this.textBoxBookstoreName = new System.Windows.Forms.TextBox();
            this.textBoxBookstoreAddress = new System.Windows.Forms.TextBox();
            this.textBoxBookstoreOwner = new System.Windows.Forms.TextBox();
            this.buttonAddNewBookstore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBookstoreName
            // 
            this.textBoxBookstoreName.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.textBoxBookstoreName.Location = new System.Drawing.Point(245, 106);
            this.textBoxBookstoreName.Name = "textBoxBookstoreName";
            this.textBoxBookstoreName.Size = new System.Drawing.Size(192, 27);
            this.textBoxBookstoreName.TabIndex = 0;
            this.textBoxBookstoreName.Text = "Nazwa";
            // 
            // textBoxBookstoreAddress
            // 
            this.textBoxBookstoreAddress.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.textBoxBookstoreAddress.Location = new System.Drawing.Point(245, 164);
            this.textBoxBookstoreAddress.Name = "textBoxBookstoreAddress";
            this.textBoxBookstoreAddress.Size = new System.Drawing.Size(192, 27);
            this.textBoxBookstoreAddress.TabIndex = 1;
            this.textBoxBookstoreAddress.Text = "Adres";
            // 
            // textBoxBookstoreOwner
            // 
            this.textBoxBookstoreOwner.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.textBoxBookstoreOwner.Location = new System.Drawing.Point(245, 229);
            this.textBoxBookstoreOwner.Name = "textBoxBookstoreOwner";
            this.textBoxBookstoreOwner.Size = new System.Drawing.Size(192, 27);
            this.textBoxBookstoreOwner.TabIndex = 2;
            this.textBoxBookstoreOwner.Text = "Właściciel";
            // 
            // buttonAddNewBookstore
            // 
            this.buttonAddNewBookstore.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.buttonAddNewBookstore.Location = new System.Drawing.Point(288, 291);
            this.buttonAddNewBookstore.Name = "buttonAddNewBookstore";
            this.buttonAddNewBookstore.Size = new System.Drawing.Size(95, 32);
            this.buttonAddNewBookstore.TabIndex = 3;
            this.buttonAddNewBookstore.Text = "Dodaj";
            this.buttonAddNewBookstore.UseVisualStyleBackColor = true;
            this.buttonAddNewBookstore.Click += new System.EventHandler(this.buttonAddNewBookstore_Click_1);
            // 
            // FormAddNewBookstore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homework4.Properties.Resources.wallpaper_1614871_19201;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddNewBookstore);
            this.Controls.Add(this.textBoxBookstoreOwner);
            this.Controls.Add(this.textBoxBookstoreAddress);
            this.Controls.Add(this.textBoxBookstoreName);
            this.Name = "FormAddNewBookstore";
            this.Text = "FormAddNewBookstore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBookstoreName;
        private System.Windows.Forms.TextBox textBoxBookstoreAddress;
        private System.Windows.Forms.TextBox textBoxBookstoreOwner;
        private System.Windows.Forms.Button buttonAddNewBookstore;
    }
}