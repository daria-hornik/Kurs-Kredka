namespace DariaHornikLab3Zadanie
{
    partial class FormTopUpAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTopUpAccount));
            this.labelTopUp = new System.Windows.Forms.Label();
            this.textBoxTopUpAccount = new System.Windows.Forms.TextBox();
            this.buttonTopUpAccount = new System.Windows.Forms.Button();
            this.labelBanksName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTopUp
            // 
            this.labelTopUp.AutoSize = true;
            this.labelTopUp.BackColor = System.Drawing.Color.Transparent;
            this.labelTopUp.Font = new System.Drawing.Font("Sitka Text", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTopUp.Location = new System.Drawing.Point(12, 59);
            this.labelTopUp.Name = "labelTopUp";
            this.labelTopUp.Size = new System.Drawing.Size(334, 45);
            this.labelTopUp.TabIndex = 0;
            this.labelTopUp.Text = "Doładuj swoje konto";
            // 
            // textBoxTopUpAccount
            // 
            this.textBoxTopUpAccount.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.textBoxTopUpAccount.Location = new System.Drawing.Point(327, 146);
            this.textBoxTopUpAccount.Name = "textBoxTopUpAccount";
            this.textBoxTopUpAccount.Size = new System.Drawing.Size(117, 26);
            this.textBoxTopUpAccount.TabIndex = 1;
            this.textBoxTopUpAccount.Text = "Kwota";
            this.textBoxTopUpAccount.TextChanged += new System.EventHandler(this.textBoxTopUpAccount_TextChanged);
            // 
            // buttonTopUpAccount
            // 
            this.buttonTopUpAccount.BackColor = System.Drawing.SystemColors.Window;
            this.buttonTopUpAccount.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.buttonTopUpAccount.Location = new System.Drawing.Point(312, 204);
            this.buttonTopUpAccount.Name = "buttonTopUpAccount";
            this.buttonTopUpAccount.Size = new System.Drawing.Size(148, 31);
            this.buttonTopUpAccount.TabIndex = 2;
            this.buttonTopUpAccount.Text = "Doładuj";
            this.buttonTopUpAccount.UseVisualStyleBackColor = false;
            this.buttonTopUpAccount.Click += new System.EventHandler(this.buttonTopUpAccount_Click);
            // 
            // labelBanksName
            // 
            this.labelBanksName.AutoSize = true;
            this.labelBanksName.BackColor = System.Drawing.Color.Transparent;
            this.labelBanksName.Font = new System.Drawing.Font("Sitka Text", 28.14545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBanksName.Location = new System.Drawing.Point(-1, -3);
            this.labelBanksName.Name = "labelBanksName";
            this.labelBanksName.Size = new System.Drawing.Size(258, 62);
            this.labelBanksName.TabIndex = 3;
            this.labelBanksName.Text = "Miraculum";
            // 
            // FormTopUpAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(841, 462);
            this.Controls.Add(this.labelBanksName);
            this.Controls.Add(this.buttonTopUpAccount);
            this.Controls.Add(this.textBoxTopUpAccount);
            this.Controls.Add(this.labelTopUp);
            this.Name = "FormTopUpAccount";
            this.Text = "Miraculum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTopUp;
        private System.Windows.Forms.TextBox textBoxTopUpAccount;
        private System.Windows.Forms.Button buttonTopUpAccount;
        private System.Windows.Forms.Label labelBanksName;
    }
}