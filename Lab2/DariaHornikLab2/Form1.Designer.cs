namespace DariaHornikLab2
{
    partial class FormAplication
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
            this.NewVehicle = new System.Windows.Forms.GroupBox();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxYearOfProduction = new System.Windows.Forms.TextBox();
            this.textBoxVehicleNumber = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelYearOfProduction = new System.Windows.Forms.Label();
            this.labelVehicleNumber = new System.Windows.Forms.Label();
            this.radioButtonBus = new System.Windows.Forms.RadioButton();
            this.radioButtonTram = new System.Windows.Forms.RadioButton();
            this.labelAboutMe = new System.Windows.Forms.Label();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.buttonPantographUp = new System.Windows.Forms.Button();
            this.buttonRefuel = new System.Windows.Forms.Button();
            this.buttonStopVehicle = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPantographDown = new System.Windows.Forms.Button();
            this.buttonBell = new System.Windows.Forms.Button();
            this.buttonStartVehicle = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.labelActualModelDescription = new System.Windows.Forms.Label();
            this.labelActualYearDescription = new System.Windows.Forms.Label();
            this.labelActualNumberDescription = new System.Windows.Forms.Label();
            this.labelActualVehicleDescription = new System.Windows.Forms.Label();
            this.labelActualName = new System.Windows.Forms.Label();
            this.labelActualYearOfProduction = new System.Windows.Forms.Label();
            this.labelActualVehicleNumber = new System.Windows.Forms.Label();
            this.labelActualVehicle = new System.Windows.Forms.Label();
            this.NewVehicle.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewVehicle
            // 
            this.NewVehicle.Controls.Add(this.buttonAddVehicle);
            this.NewVehicle.Controls.Add(this.textBoxName);
            this.NewVehicle.Controls.Add(this.textBoxYearOfProduction);
            this.NewVehicle.Controls.Add(this.textBoxVehicleNumber);
            this.NewVehicle.Controls.Add(this.labelName);
            this.NewVehicle.Controls.Add(this.labelYearOfProduction);
            this.NewVehicle.Controls.Add(this.labelVehicleNumber);
            this.NewVehicle.Controls.Add(this.radioButtonBus);
            this.NewVehicle.Controls.Add(this.radioButtonTram);
            this.NewVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewVehicle.Location = new System.Drawing.Point(13, 69);
            this.NewVehicle.Name = "NewVehicle";
            this.NewVehicle.Size = new System.Drawing.Size(408, 286);
            this.NewVehicle.TabIndex = 0;
            this.NewVehicle.TabStop = false;
            this.NewVehicle.Text = "Utwórz nowy pojazd";
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.AutoSize = true;
            this.buttonAddVehicle.Location = new System.Drawing.Point(161, 230);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(152, 30);
            this.buttonAddVehicle.TabIndex = 8;
            this.buttonAddVehicle.Text = "Dodaj nowy pojazd";
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(125, 138);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 24);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxYearOfProduction
            // 
            this.textBoxYearOfProduction.Location = new System.Drawing.Point(125, 105);
            this.textBoxYearOfProduction.Name = "textBoxYearOfProduction";
            this.textBoxYearOfProduction.Size = new System.Drawing.Size(100, 24);
            this.textBoxYearOfProduction.TabIndex = 6;
            // 
            // textBoxVehicleNumber
            // 
            this.textBoxVehicleNumber.Location = new System.Drawing.Point(125, 74);
            this.textBoxVehicleNumber.Name = "textBoxVehicleNumber";
            this.textBoxVehicleNumber.Size = new System.Drawing.Size(100, 24);
            this.textBoxVehicleNumber.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 142);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 20);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Model";
            // 
            // labelYearOfProduction
            // 
            this.labelYearOfProduction.AutoSize = true;
            this.labelYearOfProduction.Location = new System.Drawing.Point(10, 109);
            this.labelYearOfProduction.Name = "labelYearOfProduction";
            this.labelYearOfProduction.Size = new System.Drawing.Size(109, 20);
            this.labelYearOfProduction.TabIndex = 3;
            this.labelYearOfProduction.Text = "Rok produkcji ";
            // 
            // labelVehicleNumber
            // 
            this.labelVehicleNumber.AutoSize = true;
            this.labelVehicleNumber.Location = new System.Drawing.Point(12, 78);
            this.labelVehicleNumber.Name = "labelVehicleNumber";
            this.labelVehicleNumber.Size = new System.Drawing.Size(85, 20);
            this.labelVehicleNumber.TabIndex = 2;
            this.labelVehicleNumber.Text = "Nr pojazdu";
            // 
            // radioButtonBus
            // 
            this.radioButtonBus.AutoSize = true;
            this.radioButtonBus.Location = new System.Drawing.Point(312, 32);
            this.radioButtonBus.Name = "radioButtonBus";
            this.radioButtonBus.Size = new System.Drawing.Size(87, 24);
            this.radioButtonBus.TabIndex = 1;
            this.radioButtonBus.Text = "Autobus";
            this.radioButtonBus.UseVisualStyleBackColor = true;
            // 
            // radioButtonTram
            // 
            this.radioButtonTram.AutoSize = true;
            this.radioButtonTram.Checked = true;
            this.radioButtonTram.Location = new System.Drawing.Point(4, 23);
            this.radioButtonTram.Name = "radioButtonTram";
            this.radioButtonTram.Size = new System.Drawing.Size(86, 24);
            this.radioButtonTram.TabIndex = 0;
            this.radioButtonTram.TabStop = true;
            this.radioButtonTram.Text = "Tramwaj";
            this.radioButtonTram.UseVisualStyleBackColor = true;
            // 
            // labelAboutMe
            // 
            this.labelAboutMe.AutoSize = true;
            this.labelAboutMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAboutMe.Location = new System.Drawing.Point(13, 13);
            this.labelAboutMe.Name = "labelAboutMe";
            this.labelAboutMe.Size = new System.Drawing.Size(97, 20);
            this.labelAboutMe.TabIndex = 1;
            this.labelAboutMe.Text = "Daria Hornik";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.buttonPantographUp);
            this.groupBoxList.Controls.Add(this.buttonRefuel);
            this.groupBoxList.Controls.Add(this.buttonStopVehicle);
            this.groupBoxList.Controls.Add(this.buttonNext);
            this.groupBoxList.Controls.Add(this.buttonPantographDown);
            this.groupBoxList.Controls.Add(this.buttonBell);
            this.groupBoxList.Controls.Add(this.buttonStartVehicle);
            this.groupBoxList.Controls.Add(this.buttonPrevious);
            this.groupBoxList.Controls.Add(this.labelActualModelDescription);
            this.groupBoxList.Controls.Add(this.labelActualYearDescription);
            this.groupBoxList.Controls.Add(this.labelActualNumberDescription);
            this.groupBoxList.Controls.Add(this.labelActualVehicleDescription);
            this.groupBoxList.Controls.Add(this.labelActualName);
            this.groupBoxList.Controls.Add(this.labelActualYearOfProduction);
            this.groupBoxList.Controls.Add(this.labelActualVehicleNumber);
            this.groupBoxList.Controls.Add(this.labelActualVehicle);
            this.groupBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxList.Location = new System.Drawing.Point(427, 79);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(330, 364);
            this.groupBoxList.TabIndex = 2;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Lista obiektów";
            // 
            // buttonPantographUp
            // 
            this.buttonPantographUp.AutoSize = true;
            this.buttonPantographUp.Location = new System.Drawing.Point(201, 322);
            this.buttonPantographUp.Name = "buttonPantographUp";
            this.buttonPantographUp.Size = new System.Drawing.Size(157, 30);
            this.buttonPantographUp.TabIndex = 15;
            this.buttonPantographUp.Text = "Podnieść pantograf";
            this.buttonPantographUp.UseVisualStyleBackColor = true;
            this.buttonPantographUp.Click += new System.EventHandler(this.buttonPantographUp_Click);
            // 
            // buttonRefuel
            // 
            this.buttonRefuel.AutoSize = true;
            this.buttonRefuel.Location = new System.Drawing.Point(201, 271);
            this.buttonRefuel.Name = "buttonRefuel";
            this.buttonRefuel.Size = new System.Drawing.Size(132, 30);
            this.buttonRefuel.TabIndex = 14;
            this.buttonRefuel.Text = "Zatankuj pojazd";
            this.buttonRefuel.UseVisualStyleBackColor = true;
            this.buttonRefuel.Click += new System.EventHandler(this.buttonRefuel_Click);
            // 
            // buttonStopVehicle
            // 
            this.buttonStopVehicle.AutoSize = true;
            this.buttonStopVehicle.Location = new System.Drawing.Point(201, 220);
            this.buttonStopVehicle.Name = "buttonStopVehicle";
            this.buttonStopVehicle.Size = new System.Drawing.Size(137, 30);
            this.buttonStopVehicle.TabIndex = 13;
            this.buttonStopVehicle.Text = "zatrzymaj pojazd";
            this.buttonStopVehicle.UseVisualStyleBackColor = true;
            this.buttonStopVehicle.Click += new System.EventHandler(this.buttonStopVehicle_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.AutoSize = true;
            this.buttonNext.Location = new System.Drawing.Point(201, 178);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(147, 30);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "Następny element";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPantographDown
            // 
            this.buttonPantographDown.AutoSize = true;
            this.buttonPantographDown.Location = new System.Drawing.Point(16, 322);
            this.buttonPantographDown.Name = "buttonPantographDown";
            this.buttonPantographDown.Size = new System.Drawing.Size(138, 30);
            this.buttonPantographDown.TabIndex = 11;
            this.buttonPantographDown.Text = "Opuść pantograf";
            this.buttonPantographDown.UseVisualStyleBackColor = true;
            this.buttonPantographDown.Click += new System.EventHandler(this.buttonPantographDown_Click);
            // 
            // buttonBell
            // 
            this.buttonBell.AutoSize = true;
            this.buttonBell.Location = new System.Drawing.Point(16, 271);
            this.buttonBell.Name = "buttonBell";
            this.buttonBell.Size = new System.Drawing.Size(167, 30);
            this.buttonBell.TabIndex = 10;
            this.buttonBell.Text = "Zadzwoń dzwonkiem";
            this.buttonBell.UseVisualStyleBackColor = true;
            this.buttonBell.Click += new System.EventHandler(this.buttonBell_Click);
            // 
            // buttonStartVehicle
            // 
            this.buttonStartVehicle.AutoSize = true;
            this.buttonStartVehicle.Location = new System.Drawing.Point(16, 230);
            this.buttonStartVehicle.Name = "buttonStartVehicle";
            this.buttonStartVehicle.Size = new System.Drawing.Size(129, 30);
            this.buttonStartVehicle.TabIndex = 9;
            this.buttonStartVehicle.Text = "Rusz pojazdem";
            this.buttonStartVehicle.UseVisualStyleBackColor = true;
            this.buttonStartVehicle.Click += new System.EventHandler(this.buttonStartVehicle_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.AutoSize = true;
            this.buttonPrevious.Location = new System.Drawing.Point(0, 178);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(151, 30);
            this.buttonPrevious.TabIndex = 8;
            this.buttonPrevious.Text = "Poprzedni element";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // labelActualModelDescription
            // 
            this.labelActualModelDescription.AutoSize = true;
            this.labelActualModelDescription.Location = new System.Drawing.Point(197, 132);
            this.labelActualModelDescription.Name = "labelActualModelDescription";
            this.labelActualModelDescription.Size = new System.Drawing.Size(18, 20);
            this.labelActualModelDescription.TabIndex = 7;
            this.labelActualModelDescription.Text = "#";
            // 
            // labelActualYearDescription
            // 
            this.labelActualYearDescription.AutoSize = true;
            this.labelActualYearDescription.Location = new System.Drawing.Point(197, 99);
            this.labelActualYearDescription.Name = "labelActualYearDescription";
            this.labelActualYearDescription.Size = new System.Drawing.Size(18, 20);
            this.labelActualYearDescription.TabIndex = 6;
            this.labelActualYearDescription.Text = "#";
            // 
            // labelActualNumberDescription
            // 
            this.labelActualNumberDescription.AutoSize = true;
            this.labelActualNumberDescription.Location = new System.Drawing.Point(197, 68);
            this.labelActualNumberDescription.Name = "labelActualNumberDescription";
            this.labelActualNumberDescription.Size = new System.Drawing.Size(18, 20);
            this.labelActualNumberDescription.TabIndex = 5;
            this.labelActualNumberDescription.Text = "#";
            // 
            // labelActualVehicleDescription
            // 
            this.labelActualVehicleDescription.AutoSize = true;
            this.labelActualVehicleDescription.Location = new System.Drawing.Point(174, 32);
            this.labelActualVehicleDescription.Name = "labelActualVehicleDescription";
            this.labelActualVehicleDescription.Size = new System.Drawing.Size(18, 20);
            this.labelActualVehicleDescription.TabIndex = 4;
            this.labelActualVehicleDescription.Text = "#";
            // 
            // labelActualName
            // 
            this.labelActualName.AutoSize = true;
            this.labelActualName.Location = new System.Drawing.Point(7, 132);
            this.labelActualName.Name = "labelActualName";
            this.labelActualName.Size = new System.Drawing.Size(56, 20);
            this.labelActualName.TabIndex = 3;
            this.labelActualName.Text = "Model:";
            // 
            // labelActualYearOfProduction
            // 
            this.labelActualYearOfProduction.AutoSize = true;
            this.labelActualYearOfProduction.Location = new System.Drawing.Point(6, 99);
            this.labelActualYearOfProduction.Name = "labelActualYearOfProduction";
            this.labelActualYearOfProduction.Size = new System.Drawing.Size(105, 20);
            this.labelActualYearOfProduction.TabIndex = 2;
            this.labelActualYearOfProduction.Text = "Rok produkcji";
            // 
            // labelActualVehicleNumber
            // 
            this.labelActualVehicleNumber.AutoSize = true;
            this.labelActualVehicleNumber.Location = new System.Drawing.Point(6, 68);
            this.labelActualVehicleNumber.Name = "labelActualVehicleNumber";
            this.labelActualVehicleNumber.Size = new System.Drawing.Size(85, 20);
            this.labelActualVehicleNumber.TabIndex = 1;
            this.labelActualVehicleNumber.Text = "Nr pojazdu";
            // 
            // labelActualVehicle
            // 
            this.labelActualVehicle.AutoSize = true;
            this.labelActualVehicle.Location = new System.Drawing.Point(7, 32);
            this.labelActualVehicle.Name = "labelActualVehicle";
            this.labelActualVehicle.Size = new System.Drawing.Size(121, 20);
            this.labelActualVehicle.TabIndex = 0;
            this.labelActualVehicle.Text = "Aktualny pojazd";
            // 
            // FormAplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.labelAboutMe);
            this.Controls.Add(this.NewVehicle);
            this.Name = "FormAplication";
            this.Text = "Aplikacja MPK";
            this.Load += new System.EventHandler(this.FormNAme_Load);
            this.NewVehicle.ResumeLayout(false);
            this.NewVehicle.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox NewVehicle;
        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxYearOfProduction;
        private System.Windows.Forms.TextBox textBoxVehicleNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelYearOfProduction;
        private System.Windows.Forms.Label labelVehicleNumber;
        private System.Windows.Forms.RadioButton radioButtonBus;
        private System.Windows.Forms.RadioButton radioButtonTram;
        private System.Windows.Forms.Label labelAboutMe;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.Button buttonPantographUp;
        private System.Windows.Forms.Button buttonRefuel;
        private System.Windows.Forms.Button buttonStopVehicle;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPantographDown;
        private System.Windows.Forms.Button buttonBell;
        private System.Windows.Forms.Button buttonStartVehicle;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Label labelActualModelDescription;
        private System.Windows.Forms.Label labelActualYearDescription;
        private System.Windows.Forms.Label labelActualNumberDescription;
        private System.Windows.Forms.Label labelActualVehicleDescription;
        private System.Windows.Forms.Label labelActualName;
        private System.Windows.Forms.Label labelActualYearOfProduction;
        private System.Windows.Forms.Label labelActualVehicleNumber;
        private System.Windows.Forms.Label labelActualVehicle;
    }
}

