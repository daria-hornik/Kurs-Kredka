namespace DariaHornikLab3Zadanie
{
    partial class FormStartPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartPanel));
            this.labelBanksName = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.pictureBoxMiraculum = new System.Windows.Forms.PictureBox();
            this.timerStartsPanel = new System.Windows.Forms.Timer(this.components);
            this.buttonAdministrator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiraculum)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBanksName
            // 
            this.labelBanksName.AllowDrop = true;
            this.labelBanksName.AutoSize = true;
            this.labelBanksName.BackColor = System.Drawing.Color.Transparent;
            this.labelBanksName.Font = new System.Drawing.Font("Sitka Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBanksName.Location = new System.Drawing.Point(0, -2);
            this.labelBanksName.Name = "labelBanksName";
            this.labelBanksName.Size = new System.Drawing.Size(331, 79);
            this.labelBanksName.TabIndex = 0;
            this.labelBanksName.Text = "Miraculum\r\n";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.White;
            this.textBoxLogin.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(326, 170);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(180, 26);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.Text = "Login";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.textBoxPassword.Location = new System.Drawing.Point(326, 219);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(180, 26);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "Hasło";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignIn.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.buttonSignIn.Location = new System.Drawing.Point(353, 267);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(124, 29);
            this.buttonSignIn.TabIndex = 3;
            this.buttonSignIn.Text = "Zaloguj";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSignUp.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.buttonSignUp.Location = new System.Drawing.Point(648, 403);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(151, 37);
            this.buttonSignUp.TabIndex = 4;
            this.buttonSignUp.Text = "Zarejestruj";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // pictureBoxMiraculum
            // 
            this.pictureBoxMiraculum.BackColor = System.Drawing.Color.White;
            this.pictureBoxMiraculum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMiraculum.BackgroundImage")));
            this.pictureBoxMiraculum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMiraculum.Location = new System.Drawing.Point(668, 44);
            this.pictureBoxMiraculum.Name = "pictureBoxMiraculum";
            this.pictureBoxMiraculum.Size = new System.Drawing.Size(74, 70);
            this.pictureBoxMiraculum.TabIndex = 5;
            this.pictureBoxMiraculum.TabStop = false;
            // 
            // timerStartsPanel
            // 
            this.timerStartsPanel.Interval = 1000;
            this.timerStartsPanel.Tick += new System.EventHandler(this.timerStartsPanel_Tick);
            // 
            // buttonAdministrator
            // 
            this.buttonAdministrator.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAdministrator.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.buttonAdministrator.Location = new System.Drawing.Point(599, -2);
            this.buttonAdministrator.Name = "buttonAdministrator";
            this.buttonAdministrator.Size = new System.Drawing.Size(144, 27);
            this.buttonAdministrator.TabIndex = 6;
            this.buttonAdministrator.Text = "Administrator";
            this.buttonAdministrator.UseVisualStyleBackColor = false;
            this.buttonAdministrator.Click += new System.EventHandler(this.buttonAdministrator_Click);
            // 
            // FormStartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(842, 462);
            this.Controls.Add(this.buttonAdministrator);
            this.Controls.Add(this.pictureBoxMiraculum);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelBanksName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormStartPanel";
            this.Text = "Miraculum";
            this.Load += new System.EventHandler(this.FormStartPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiraculum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBanksName;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.PictureBox pictureBoxMiraculum;
        private System.Windows.Forms.Timer timerStartsPanel;
        private System.Windows.Forms.Button buttonAdministrator;
    }
}

