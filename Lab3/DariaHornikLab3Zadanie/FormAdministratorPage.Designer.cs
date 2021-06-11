namespace DariaHornikLab3Zadanie
{
    partial class FormAdministratorPage
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
            this.dataGridViewCustomersData = new System.Windows.Forms.DataGridView();
            this.panelCustomersData = new System.Windows.Forms.Panel();
            this.groupBoxAdministratorOption = new System.Windows.Forms.GroupBox();
            this.buttonAcceptRemovingAccount = new System.Windows.Forms.Button();
            this.textBoxNumberRemovingAccount = new System.Windows.Forms.TextBox();
            this.buttonRemoveAccount = new System.Windows.Forms.Button();
            this.panelSignUpForAdministrator = new System.Windows.Forms.Panel();
            this.maskedTextBoxAdministratorPassword = new System.Windows.Forms.MaskedTextBox();
            this.buttonNextPageForAdministrator = new System.Windows.Forms.Button();
            this.textBoxAdministratorLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomersData)).BeginInit();
            this.panelCustomersData.SuspendLayout();
            this.groupBoxAdministratorOption.SuspendLayout();
            this.panelSignUpForAdministrator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCustomersData
            // 
            this.dataGridViewCustomersData.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewCustomersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomersData.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewCustomersData.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewCustomersData.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomersData.Name = "dataGridViewCustomersData";
            this.dataGridViewCustomersData.Size = new System.Drawing.Size(800, 294);
            this.dataGridViewCustomersData.TabIndex = 0;
            // 
            // panelCustomersData
            // 
            this.panelCustomersData.BackColor = System.Drawing.Color.Transparent;
            this.panelCustomersData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCustomersData.Controls.Add(this.groupBoxAdministratorOption);
            this.panelCustomersData.Controls.Add(this.dataGridViewCustomersData);
            this.panelCustomersData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomersData.Location = new System.Drawing.Point(0, 0);
            this.panelCustomersData.Name = "panelCustomersData";
            this.panelCustomersData.Size = new System.Drawing.Size(800, 450);
            this.panelCustomersData.TabIndex = 1;
            this.panelCustomersData.Visible = false;
            // 
            // groupBoxAdministratorOption
            // 
            this.groupBoxAdministratorOption.Controls.Add(this.buttonAcceptRemovingAccount);
            this.groupBoxAdministratorOption.Controls.Add(this.textBoxNumberRemovingAccount);
            this.groupBoxAdministratorOption.Controls.Add(this.buttonRemoveAccount);
            this.groupBoxAdministratorOption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxAdministratorOption.Location = new System.Drawing.Point(0, 300);
            this.groupBoxAdministratorOption.Name = "groupBoxAdministratorOption";
            this.groupBoxAdministratorOption.Size = new System.Drawing.Size(800, 150);
            this.groupBoxAdministratorOption.TabIndex = 1;
            this.groupBoxAdministratorOption.TabStop = false;
            // 
            // buttonAcceptRemovingAccount
            // 
            this.buttonAcceptRemovingAccount.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAcceptRemovingAccount.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.buttonAcceptRemovingAccount.Location = new System.Drawing.Point(271, 61);
            this.buttonAcceptRemovingAccount.Name = "buttonAcceptRemovingAccount";
            this.buttonAcceptRemovingAccount.Size = new System.Drawing.Size(130, 28);
            this.buttonAcceptRemovingAccount.TabIndex = 3;
            this.buttonAcceptRemovingAccount.Text = "Potwierdź";
            this.buttonAcceptRemovingAccount.UseVisualStyleBackColor = false;
            this.buttonAcceptRemovingAccount.Visible = false;
            this.buttonAcceptRemovingAccount.Click += new System.EventHandler(this.buttonAcceptRemovingAccount_Click);
            // 
            // textBoxNumberRemovingAccount
            // 
            this.textBoxNumberRemovingAccount.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.textBoxNumberRemovingAccount.Location = new System.Drawing.Point(7, 63);
            this.textBoxNumberRemovingAccount.Name = "textBoxNumberRemovingAccount";
            this.textBoxNumberRemovingAccount.Size = new System.Drawing.Size(214, 26);
            this.textBoxNumberRemovingAccount.TabIndex = 1;
            this.textBoxNumberRemovingAccount.Text = "Numer usuwanego konta";
            this.textBoxNumberRemovingAccount.Visible = false;
            // 
            // buttonRemoveAccount
            // 
            this.buttonRemoveAccount.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRemoveAccount.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.buttonRemoveAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRemoveAccount.Location = new System.Drawing.Point(7, 19);
            this.buttonRemoveAccount.Name = "buttonRemoveAccount";
            this.buttonRemoveAccount.Size = new System.Drawing.Size(123, 27);
            this.buttonRemoveAccount.TabIndex = 0;
            this.buttonRemoveAccount.Text = "Usuń konto";
            this.buttonRemoveAccount.UseVisualStyleBackColor = false;
            this.buttonRemoveAccount.Click += new System.EventHandler(this.buttonRemoveAccount_Click);
            // 
            // panelSignUpForAdministrator
            // 
            this.panelSignUpForAdministrator.BackColor = System.Drawing.Color.Transparent;
            this.panelSignUpForAdministrator.Controls.Add(this.maskedTextBoxAdministratorPassword);
            this.panelSignUpForAdministrator.Controls.Add(this.buttonNextPageForAdministrator);
            this.panelSignUpForAdministrator.Controls.Add(this.textBoxAdministratorLogin);
            this.panelSignUpForAdministrator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSignUpForAdministrator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelSignUpForAdministrator.Location = new System.Drawing.Point(0, 0);
            this.panelSignUpForAdministrator.Name = "panelSignUpForAdministrator";
            this.panelSignUpForAdministrator.Size = new System.Drawing.Size(800, 450);
            this.panelSignUpForAdministrator.TabIndex = 2;
            // 
            // maskedTextBoxAdministratorPassword
            // 
            this.maskedTextBoxAdministratorPassword.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxAdministratorPassword.Location = new System.Drawing.Point(299, 158);
            this.maskedTextBoxAdministratorPassword.Name = "maskedTextBoxAdministratorPassword";
            this.maskedTextBoxAdministratorPassword.Size = new System.Drawing.Size(180, 26);
            this.maskedTextBoxAdministratorPassword.TabIndex = 3;
            this.maskedTextBoxAdministratorPassword.Text = "Hasło administrarora";
            // 
            // buttonNextPageForAdministrator
            // 
            this.buttonNextPageForAdministrator.BackColor = System.Drawing.SystemColors.Window;
            this.buttonNextPageForAdministrator.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.buttonNextPageForAdministrator.Location = new System.Drawing.Point(311, 224);
            this.buttonNextPageForAdministrator.Name = "buttonNextPageForAdministrator";
            this.buttonNextPageForAdministrator.Size = new System.Drawing.Size(149, 26);
            this.buttonNextPageForAdministrator.TabIndex = 2;
            this.buttonNextPageForAdministrator.Text = "Przejdź dalej";
            this.buttonNextPageForAdministrator.UseVisualStyleBackColor = false;
            this.buttonNextPageForAdministrator.Click += new System.EventHandler(this.buttonNextPageForAdministrator_Click);
            // 
            // textBoxAdministratorLogin
            // 
            this.textBoxAdministratorLogin.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.textBoxAdministratorLogin.Location = new System.Drawing.Point(299, 98);
            this.textBoxAdministratorLogin.Name = "textBoxAdministratorLogin";
            this.textBoxAdministratorLogin.Size = new System.Drawing.Size(180, 26);
            this.textBoxAdministratorLogin.TabIndex = 0;
            this.textBoxAdministratorLogin.Text = "Login administratora";
            // 
            // FormAdministratorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DariaHornikLab3Zadanie.Properties.Resources.acf5de11a9b94f3b369e84e28f859aa4;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSignUpForAdministrator);
            this.Controls.Add(this.panelCustomersData);
            this.Name = "FormAdministratorPage";
            this.Text = "FormAdministratorPage";
            this.Load += new System.EventHandler(this.FormAdministratorPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomersData)).EndInit();
            this.panelCustomersData.ResumeLayout(false);
            this.groupBoxAdministratorOption.ResumeLayout(false);
            this.groupBoxAdministratorOption.PerformLayout();
            this.panelSignUpForAdministrator.ResumeLayout(false);
            this.panelSignUpForAdministrator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomersData;
        private System.Windows.Forms.Panel panelCustomersData;
        private System.Windows.Forms.Panel panelSignUpForAdministrator;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAdministratorPassword;
        private System.Windows.Forms.Button buttonNextPageForAdministrator;
        private System.Windows.Forms.TextBox textBoxAdministratorLogin;
        private System.Windows.Forms.GroupBox groupBoxAdministratorOption;
        private System.Windows.Forms.Button buttonRemoveAccount;
        private System.Windows.Forms.Button buttonAcceptRemovingAccount;
        private System.Windows.Forms.TextBox textBoxNumberRemovingAccount;
    }
}