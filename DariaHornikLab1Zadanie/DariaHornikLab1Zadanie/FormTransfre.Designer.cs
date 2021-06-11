namespace DariaHornikLab1Zadanie
{
    partial class FormTransfre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransfre));
            this.labelInsideTransfer = new System.Windows.Forms.Label();
            this.textBoxrecipientsNumber = new System.Windows.Forms.TextBox();
            this.textBoxTransferAmount = new System.Windows.Forms.TextBox();
            this.buttonMakeTransfer = new System.Windows.Forms.Button();
            this.labelBanksName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInsideTransfer
            // 
            this.labelInsideTransfer.AutoSize = true;
            this.labelInsideTransfer.BackColor = System.Drawing.Color.Transparent;
            this.labelInsideTransfer.Font = new System.Drawing.Font("Sitka Text", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInsideTransfer.Location = new System.Drawing.Point(12, 61);
            this.labelInsideTransfer.Name = "labelInsideTransfer";
            this.labelInsideTransfer.Size = new System.Drawing.Size(339, 45);
            this.labelInsideTransfer.TabIndex = 0;
            this.labelInsideTransfer.Text = "Przelew wewnętrzny";
            this.labelInsideTransfer.Click += new System.EventHandler(this.labelInsideTransfer_Click);
            // 
            // textBoxrecipientsNumber
            // 
            this.textBoxrecipientsNumber.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.textBoxrecipientsNumber.Location = new System.Drawing.Point(298, 144);
            this.textBoxrecipientsNumber.Name = "textBoxrecipientsNumber";
            this.textBoxrecipientsNumber.Size = new System.Drawing.Size(201, 26);
            this.textBoxrecipientsNumber.TabIndex = 1;
            this.textBoxrecipientsNumber.Text = "Numer konta odbiorcy";
            this.textBoxrecipientsNumber.TextChanged += new System.EventHandler(this.textBoxrecipientsLogin_TextChanged);
            // 
            // textBoxTransferAmount
            // 
            this.textBoxTransferAmount.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.textBoxTransferAmount.Location = new System.Drawing.Point(347, 195);
            this.textBoxTransferAmount.Name = "textBoxTransferAmount";
            this.textBoxTransferAmount.Size = new System.Drawing.Size(100, 26);
            this.textBoxTransferAmount.TabIndex = 2;
            this.textBoxTransferAmount.Text = "Kwota";
            // 
            // buttonMakeTransfer
            // 
            this.buttonMakeTransfer.BackColor = System.Drawing.SystemColors.Window;
            this.buttonMakeTransfer.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.buttonMakeTransfer.Location = new System.Drawing.Point(284, 402);
            this.buttonMakeTransfer.Name = "buttonMakeTransfer";
            this.buttonMakeTransfer.Size = new System.Drawing.Size(241, 31);
            this.buttonMakeTransfer.TabIndex = 3;
            this.buttonMakeTransfer.Text = "Wykonaj przelew";
            this.buttonMakeTransfer.UseVisualStyleBackColor = false;
            this.buttonMakeTransfer.Click += new System.EventHandler(this.buttonMakeTransfer_Click);
            // 
            // labelBanksName
            // 
            this.labelBanksName.AutoSize = true;
            this.labelBanksName.BackColor = System.Drawing.Color.Transparent;
            this.labelBanksName.Font = new System.Drawing.Font("Sitka Text", 28.14545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBanksName.Location = new System.Drawing.Point(-1, -1);
            this.labelBanksName.Name = "labelBanksName";
            this.labelBanksName.Size = new System.Drawing.Size(258, 62);
            this.labelBanksName.TabIndex = 4;
            this.labelBanksName.Text = "Miraculum";
            // 
            // FormTransfre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(841, 459);
            this.Controls.Add(this.labelBanksName);
            this.Controls.Add(this.buttonMakeTransfer);
            this.Controls.Add(this.textBoxTransferAmount);
            this.Controls.Add(this.textBoxrecipientsNumber);
            this.Controls.Add(this.labelInsideTransfer);
            this.Name = "FormTransfre";
            this.Text = "Miraculum";
            this.Load += new System.EventHandler(this.FormTransfre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInsideTransfer;
        private System.Windows.Forms.TextBox textBoxrecipientsNumber;
        private System.Windows.Forms.TextBox textBoxTransferAmount;
        private System.Windows.Forms.Button buttonMakeTransfer;
        private System.Windows.Forms.Label labelBanksName;
    }
}