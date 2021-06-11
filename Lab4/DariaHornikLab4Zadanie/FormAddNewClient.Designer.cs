namespace DariaHornikLab4Zadanie
{
    partial class FormAddNewClient
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
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxClientSurname = new System.Windows.Forms.TextBox();
            this.textBoxClientBirthData = new System.Windows.Forms.TextBox();
            this.textBoxClientAddresStreet = new System.Windows.Forms.TextBox();
            this.textBoxClientAddresHouseNumber = new System.Windows.Forms.TextBox();
            this.textBoxClientAddresZipCode = new System.Windows.Forms.TextBox();
            this.textBoxClientAddressCity = new System.Windows.Forms.TextBox();
            this.buttonAddNewClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.textBoxClientName.Location = new System.Drawing.Point(146, 129);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(164, 27);
            this.textBoxClientName.TabIndex = 0;
            this.textBoxClientName.Text = "Imię";
            // 
            // textBoxClientSurname
            // 
            this.textBoxClientSurname.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.textBoxClientSurname.Location = new System.Drawing.Point(146, 177);
            this.textBoxClientSurname.Name = "textBoxClientSurname";
            this.textBoxClientSurname.Size = new System.Drawing.Size(164, 27);
            this.textBoxClientSurname.TabIndex = 1;
            this.textBoxClientSurname.Text = "Nazwisko";
            // 
            // textBoxClientBirthData
            // 
            this.textBoxClientBirthData.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.textBoxClientBirthData.Location = new System.Drawing.Point(146, 224);
            this.textBoxClientBirthData.Name = "textBoxClientBirthData";
            this.textBoxClientBirthData.Size = new System.Drawing.Size(164, 27);
            this.textBoxClientBirthData.TabIndex = 2;
            this.textBoxClientBirthData.Text = "Data urodzenia";
            // 
            // textBoxClientAddresStreet
            // 
            this.textBoxClientAddresStreet.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.textBoxClientAddresStreet.Location = new System.Drawing.Point(425, 129);
            this.textBoxClientAddresStreet.Name = "textBoxClientAddresStreet";
            this.textBoxClientAddresStreet.Size = new System.Drawing.Size(100, 27);
            this.textBoxClientAddresStreet.TabIndex = 3;
            this.textBoxClientAddresStreet.Text = "ulica";
            // 
            // textBoxClientAddresHouseNumber
            // 
            this.textBoxClientAddresHouseNumber.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.textBoxClientAddresHouseNumber.Location = new System.Drawing.Point(557, 129);
            this.textBoxClientAddresHouseNumber.Name = "textBoxClientAddresHouseNumber";
            this.textBoxClientAddresHouseNumber.Size = new System.Drawing.Size(49, 27);
            this.textBoxClientAddresHouseNumber.TabIndex = 4;
            this.textBoxClientAddresHouseNumber.Text = "nr";
            // 
            // textBoxClientAddresZipCode
            // 
            this.textBoxClientAddresZipCode.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.textBoxClientAddresZipCode.Location = new System.Drawing.Point(425, 177);
            this.textBoxClientAddresZipCode.Name = "textBoxClientAddresZipCode";
            this.textBoxClientAddresZipCode.Size = new System.Drawing.Size(181, 27);
            this.textBoxClientAddresZipCode.TabIndex = 5;
            this.textBoxClientAddresZipCode.Text = "kod pocztowy";
            // 
            // textBoxClientAddressCity
            // 
            this.textBoxClientAddressCity.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.textBoxClientAddressCity.Location = new System.Drawing.Point(425, 224);
            this.textBoxClientAddressCity.Name = "textBoxClientAddressCity";
            this.textBoxClientAddressCity.Size = new System.Drawing.Size(181, 27);
            this.textBoxClientAddressCity.TabIndex = 6;
            this.textBoxClientAddressCity.Text = "miasto";
            // 
            // buttonAddNewClient
            // 
            this.buttonAddNewClient.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAddNewClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddNewClient.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.buttonAddNewClient.Location = new System.Drawing.Point(306, 315);
            this.buttonAddNewClient.Name = "buttonAddNewClient";
            this.buttonAddNewClient.Size = new System.Drawing.Size(124, 29);
            this.buttonAddNewClient.TabIndex = 7;
            this.buttonAddNewClient.Text = "Dodaj";
            this.buttonAddNewClient.UseVisualStyleBackColor = false;
            this.buttonAddNewClient.Click += new System.EventHandler(this.buttonAddNewClient_Click);
            // 
            // FormAddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homework4.Properties.Resources.wallpaper_1614871_19201;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddNewClient);
            this.Controls.Add(this.textBoxClientAddressCity);
            this.Controls.Add(this.textBoxClientAddresZipCode);
            this.Controls.Add(this.textBoxClientAddresHouseNumber);
            this.Controls.Add(this.textBoxClientAddresStreet);
            this.Controls.Add(this.textBoxClientBirthData);
            this.Controls.Add(this.textBoxClientSurname);
            this.Controls.Add(this.textBoxClientName);
            this.Name = "FormAddNewClient";
            this.Text = "FormAddNewClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxClientSurname;
        private System.Windows.Forms.TextBox textBoxClientBirthData;
        private System.Windows.Forms.TextBox textBoxClientAddresStreet;
        private System.Windows.Forms.TextBox textBoxClientAddresHouseNumber;
        private System.Windows.Forms.TextBox textBoxClientAddresZipCode;
        private System.Windows.Forms.TextBox textBoxClientAddressCity;
        private System.Windows.Forms.Button buttonAddNewClient;
    }
}