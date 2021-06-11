namespace DariaHornikLab3Zadanie
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            this.textBoxCustomersName = new System.Windows.Forms.TextBox();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.textBoxCustomersSurname = new System.Windows.Forms.TextBox();
            this.textBoxCustomersLogin = new System.Windows.Forms.TextBox();
            this.textBoxCustomersPin = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.labelBanksName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCustomersName
            // 
            this.textBoxCustomersName.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.textBoxCustomersName.Location = new System.Drawing.Point(346, 122);
            this.textBoxCustomersName.Name = "textBoxCustomersName";
            this.textBoxCustomersName.Size = new System.Drawing.Size(176, 26);
            this.textBoxCustomersName.TabIndex = 0;
            this.textBoxCustomersName.Text = "Imie";
            this.textBoxCustomersName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.BackColor = System.Drawing.Color.Transparent;
            this.labelRegistration.Font = new System.Drawing.Font("Sitka Text", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRegistration.Location = new System.Drawing.Point(12, 59);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(192, 45);
            this.labelRegistration.TabIndex = 1;
            this.labelRegistration.Text = "Rejestracja";
            this.labelRegistration.Click += new System.EventHandler(this.labelRegistration_Click);
            // 
            // textBoxCustomersSurname
            // 
            this.textBoxCustomersSurname.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.textBoxCustomersSurname.Location = new System.Drawing.Point(346, 164);
            this.textBoxCustomersSurname.Name = "textBoxCustomersSurname";
            this.textBoxCustomersSurname.Size = new System.Drawing.Size(176, 26);
            this.textBoxCustomersSurname.TabIndex = 2;
            this.textBoxCustomersSurname.Text = "Nazwisko";
            this.textBoxCustomersSurname.TextChanged += new System.EventHandler(this.textBoxCustomersSurname_TextChanged);
            // 
            // textBoxCustomersLogin
            // 
            this.textBoxCustomersLogin.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.textBoxCustomersLogin.Location = new System.Drawing.Point(346, 209);
            this.textBoxCustomersLogin.Name = "textBoxCustomersLogin";
            this.textBoxCustomersLogin.Size = new System.Drawing.Size(176, 26);
            this.textBoxCustomersLogin.TabIndex = 3;
            this.textBoxCustomersLogin.Text = "Login";
            this.textBoxCustomersLogin.TextChanged += new System.EventHandler(this.textBoxCustomersLogin_TextChanged);
            // 
            // textBoxCustomersPin
            // 
            this.textBoxCustomersPin.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.textBoxCustomersPin.Location = new System.Drawing.Point(346, 256);
            this.textBoxCustomersPin.Name = "textBoxCustomersPin";
            this.textBoxCustomersPin.Size = new System.Drawing.Size(176, 26);
            this.textBoxCustomersPin.TabIndex = 4;
            this.textBoxCustomersPin.Text = "Pin";
            this.textBoxCustomersPin.TextChanged += new System.EventHandler(this.textBoxCustomersPin_TextChanged);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSignUp.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.buttonSignUp.Location = new System.Drawing.Point(307, 390);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(247, 36);
            this.buttonSignUp.TabIndex = 5;
            this.buttonSignUp.Text = "Zarejestruj";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // labelBanksName
            // 
            this.labelBanksName.AutoSize = true;
            this.labelBanksName.BackColor = System.Drawing.Color.Transparent;
            this.labelBanksName.Font = new System.Drawing.Font("Sitka Text", 28.14545F, System.Drawing.FontStyle.Bold);
            this.labelBanksName.Location = new System.Drawing.Point(-3, -3);
            this.labelBanksName.Name = "labelBanksName";
            this.labelBanksName.Size = new System.Drawing.Size(258, 62);
            this.labelBanksName.TabIndex = 6;
            this.labelBanksName.Text = "Miraculum";
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(841, 461);
            this.Controls.Add(this.labelBanksName);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.textBoxCustomersPin);
            this.Controls.Add(this.textBoxCustomersLogin);
            this.Controls.Add(this.textBoxCustomersSurname);
            this.Controls.Add(this.labelRegistration);
            this.Controls.Add(this.textBoxCustomersName);
            this.Name = "FormSignUp";
            this.Text = "Miraculum";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCustomersName;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.TextBox textBoxCustomersSurname;
        private System.Windows.Forms.TextBox textBoxCustomersLogin;
        private System.Windows.Forms.TextBox textBoxCustomersPin;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label labelBanksName;
    }
}