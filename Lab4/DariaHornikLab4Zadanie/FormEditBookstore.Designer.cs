namespace DariaHornikLab4Zadanie
{
    partial class FormEditBookstore
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
            this.panelEditBookstore = new System.Windows.Forms.Panel();
            this.groupBoxEditBookstore = new System.Windows.Forms.GroupBox();
            this.buttonSaveNewBookstoreData = new System.Windows.Forms.Button();
            this.textBoxNewBookstoreOwner = new System.Windows.Forms.TextBox();
            this.textBoxNewBookstoreAddress = new System.Windows.Forms.TextBox();
            this.textBoxNewBookstoreName = new System.Windows.Forms.TextBox();
            this.panelEditBookstore.SuspendLayout();
            this.groupBoxEditBookstore.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEditBookstore
            // 
            this.panelEditBookstore.Controls.Add(this.groupBoxEditBookstore);
            this.panelEditBookstore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditBookstore.Location = new System.Drawing.Point(0, 0);
            this.panelEditBookstore.Name = "panelEditBookstore";
            this.panelEditBookstore.Size = new System.Drawing.Size(800, 450);
            this.panelEditBookstore.TabIndex = 0;
            // 
            // groupBoxEditBookstore
            // 
            this.groupBoxEditBookstore.BackgroundImage = global::Homework4.Properties.Resources.wallpaper_1614871_19201;
            this.groupBoxEditBookstore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxEditBookstore.Controls.Add(this.buttonSaveNewBookstoreData);
            this.groupBoxEditBookstore.Controls.Add(this.textBoxNewBookstoreOwner);
            this.groupBoxEditBookstore.Controls.Add(this.textBoxNewBookstoreAddress);
            this.groupBoxEditBookstore.Controls.Add(this.textBoxNewBookstoreName);
            this.groupBoxEditBookstore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEditBookstore.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEditBookstore.Name = "groupBoxEditBookstore";
            this.groupBoxEditBookstore.Size = new System.Drawing.Size(800, 450);
            this.groupBoxEditBookstore.TabIndex = 0;
            this.groupBoxEditBookstore.TabStop = false;
            // 
            // buttonSaveNewBookstoreData
            // 
            this.buttonSaveNewBookstoreData.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.buttonSaveNewBookstoreData.Location = new System.Drawing.Point(330, 270);
            this.buttonSaveNewBookstoreData.Name = "buttonSaveNewBookstoreData";
            this.buttonSaveNewBookstoreData.Size = new System.Drawing.Size(127, 31);
            this.buttonSaveNewBookstoreData.TabIndex = 3;
            this.buttonSaveNewBookstoreData.Text = "Zapisz";
            this.buttonSaveNewBookstoreData.UseVisualStyleBackColor = true;
            this.buttonSaveNewBookstoreData.Click += new System.EventHandler(this.buttonSaveNewBookstoreData_Click);
            // 
            // textBoxNewBookstoreOwner
            // 
            this.textBoxNewBookstoreOwner.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.textBoxNewBookstoreOwner.Location = new System.Drawing.Point(294, 197);
            this.textBoxNewBookstoreOwner.Name = "textBoxNewBookstoreOwner";
            this.textBoxNewBookstoreOwner.Size = new System.Drawing.Size(207, 27);
            this.textBoxNewBookstoreOwner.TabIndex = 2;
            this.textBoxNewBookstoreOwner.Text = "Nowy właściciel";
            // 
            // textBoxNewBookstoreAddress
            // 
            this.textBoxNewBookstoreAddress.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.textBoxNewBookstoreAddress.Location = new System.Drawing.Point(294, 150);
            this.textBoxNewBookstoreAddress.Name = "textBoxNewBookstoreAddress";
            this.textBoxNewBookstoreAddress.Size = new System.Drawing.Size(207, 27);
            this.textBoxNewBookstoreAddress.TabIndex = 1;
            this.textBoxNewBookstoreAddress.Text = "Nowy adres";
            // 
            // textBoxNewBookstoreName
            // 
            this.textBoxNewBookstoreName.Font = new System.Drawing.Font("Microsoft YaHei", 9.818182F);
            this.textBoxNewBookstoreName.Location = new System.Drawing.Point(294, 96);
            this.textBoxNewBookstoreName.Name = "textBoxNewBookstoreName";
            this.textBoxNewBookstoreName.Size = new System.Drawing.Size(207, 27);
            this.textBoxNewBookstoreName.TabIndex = 0;
            this.textBoxNewBookstoreName.Text = "Nowa nazwa";
            // 
            // FormEditBookstore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEditBookstore);
            this.Name = "FormEditBookstore";
            this.Text = "FormEditBookstore";
            this.panelEditBookstore.ResumeLayout(false);
            this.groupBoxEditBookstore.ResumeLayout(false);
            this.groupBoxEditBookstore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEditBookstore;
        private System.Windows.Forms.GroupBox groupBoxEditBookstore;
        private System.Windows.Forms.Button buttonSaveNewBookstoreData;
        private System.Windows.Forms.TextBox textBoxNewBookstoreOwner;
        private System.Windows.Forms.TextBox textBoxNewBookstoreAddress;
        private System.Windows.Forms.TextBox textBoxNewBookstoreName;
    }
}