namespace DariaHornikLab3Zadanie
{
    partial class FormMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPage));
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.labelClock = new System.Windows.Forms.Label();
            this.progressBarTimetoEnd = new System.Windows.Forms.ProgressBar();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.buttonBankOffer = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.labelBanksData = new System.Windows.Forms.Label();
            this.labelDatasOwner = new System.Windows.Forms.Label();
            this.labelAccountsBallance = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.buttonRefreshData = new System.Windows.Forms.Button();
            this.toolTipTopUp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.BackColor = System.Drawing.Color.Transparent;
            this.labelClock.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.labelClock.Location = new System.Drawing.Point(562, 42);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(47, 21);
            this.labelClock.TabIndex = 0;
            this.labelClock.Text = "Time";
            this.labelClock.Click += new System.EventHandler(this.labelClock_Click_1);
            // 
            // progressBarTimetoEnd
            // 
            this.progressBarTimetoEnd.BackColor = System.Drawing.Color.Yellow;
            this.progressBarTimetoEnd.Location = new System.Drawing.Point(566, 26);
            this.progressBarTimetoEnd.Maximum = 15;
            this.progressBarTimetoEnd.Name = "progressBarTimetoEnd";
            this.progressBarTimetoEnd.Size = new System.Drawing.Size(263, 13);
            this.progressBarTimetoEnd.TabIndex = 1;
            this.progressBarTimetoEnd.Click += new System.EventHandler(this.progressBarTimetoEnd_Click);
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackColor = System.Drawing.SystemColors.Window;
            this.buttonTransfer.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.buttonTransfer.Location = new System.Drawing.Point(640, 359);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(190, 28);
            this.buttonTransfer.TabIndex = 2;
            this.buttonTransfer.Text = "Przelew";
            this.buttonTransfer.UseVisualStyleBackColor = false;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // buttonBankOffer
            // 
            this.buttonBankOffer.BackColor = System.Drawing.SystemColors.Window;
            this.buttonBankOffer.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.buttonBankOffer.Location = new System.Drawing.Point(640, 311);
            this.buttonBankOffer.Name = "buttonBankOffer";
            this.buttonBankOffer.Size = new System.Drawing.Size(191, 28);
            this.buttonBankOffer.TabIndex = 3;
            this.buttonBankOffer.Text = "Doładuj swoje konto";
            this.toolTipTopUp.SetToolTip(this.buttonBankOffer, "Możesz użyc tej funkcji tylko raz podczas sesji.");
            this.buttonBankOffer.UseVisualStyleBackColor = false;
            this.buttonBankOffer.Click += new System.EventHandler(this.buttonBankOffer_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.SystemColors.Window;
            this.buttonLog.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.buttonLog.Location = new System.Drawing.Point(640, 408);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(189, 28);
            this.buttonLog.TabIndex = 4;
            this.buttonLog.Text = "Wyloguj";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonBlik_Click);
            // 
            // labelBanksData
            // 
            this.labelBanksData.AutoSize = true;
            this.labelBanksData.BackColor = System.Drawing.Color.Transparent;
            this.labelBanksData.Font = new System.Drawing.Font("Sitka Text", 28.14545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBanksData.Location = new System.Drawing.Point(0, -4);
            this.labelBanksData.Name = "labelBanksData";
            this.labelBanksData.Size = new System.Drawing.Size(93, 62);
            this.labelBanksData.TabIndex = 5;
            this.labelBanksData.Text = "lab";
            this.labelBanksData.Click += new System.EventHandler(this.labelOwnersData_Click);
            // 
            // labelDatasOwner
            // 
            this.labelDatasOwner.AutoSize = true;
            this.labelDatasOwner.BackColor = System.Drawing.Color.Transparent;
            this.labelDatasOwner.Font = new System.Drawing.Font("Sitka Text", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatasOwner.Location = new System.Drawing.Point(35, 244);
            this.labelDatasOwner.Name = "labelDatasOwner";
            this.labelDatasOwner.Size = new System.Drawing.Size(63, 30);
            this.labelDatasOwner.TabIndex = 6;
            this.labelDatasOwner.Text = "Dane";
            this.labelDatasOwner.Click += new System.EventHandler(this.labelDatasOwner_Click);
            // 
            // labelAccountsBallance
            // 
            this.labelAccountsBallance.AutoSize = true;
            this.labelAccountsBallance.BackColor = System.Drawing.Color.Transparent;
            this.labelAccountsBallance.Font = new System.Drawing.Font("Sitka Text", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAccountsBallance.Location = new System.Drawing.Point(316, 101);
            this.labelAccountsBallance.Name = "labelAccountsBallance";
            this.labelAccountsBallance.Size = new System.Drawing.Size(150, 30);
            this.labelAccountsBallance.TabIndex = 7;
            this.labelAccountsBallance.Text = "Saldo konta: ";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelMoney.Font = new System.Drawing.Font("Sitka Text", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMoney.Location = new System.Drawing.Point(342, 158);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(84, 35);
            this.labelMoney.TabIndex = 8;
            this.labelMoney.Text = "label1";
            this.labelMoney.Click += new System.EventHandler(this.labelMoney_Click);
            // 
            // buttonRefreshData
            // 
            this.buttonRefreshData.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRefreshData.Font = new System.Drawing.Font("Sitka Text", 9.818181F, System.Drawing.FontStyle.Bold);
            this.buttonRefreshData.Location = new System.Drawing.Point(641, 262);
            this.buttonRefreshData.Name = "buttonRefreshData";
            this.buttonRefreshData.Size = new System.Drawing.Size(190, 28);
            this.buttonRefreshData.TabIndex = 9;
            this.buttonRefreshData.Text = "Odśwież";
            this.buttonRefreshData.UseVisualStyleBackColor = false;
            this.buttonRefreshData.Click += new System.EventHandler(this.buttonRefreshData_Click);
            // 
            // toolTipTopUp
            // 
            this.toolTipTopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolTipTopUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolTipTopUp.OwnerDraw = true;
            this.toolTipTopUp.ShowAlways = true;
            this.toolTipTopUp.Tag = "";
            this.toolTipTopUp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(841, 460);
            this.Controls.Add(this.buttonRefreshData);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelAccountsBallance);
            this.Controls.Add(this.labelDatasOwner);
            this.Controls.Add(this.labelBanksData);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonBankOffer);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.progressBarTimetoEnd);
            this.Controls.Add(this.labelClock);
            this.Name = "FormMainPage";
            this.Text = "Miraculum";
            this.Load += new System.EventHandler(this.FormMainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.ProgressBar progressBarTimetoEnd;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Button buttonBankOffer;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Label labelBanksData;
        private System.Windows.Forms.Label labelDatasOwner;
        private System.Windows.Forms.Label labelAccountsBallance;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Button buttonRefreshData;
        public System.Windows.Forms.ToolTip toolTipTopUp;
    }
}