namespace EntityFrameworkLab4
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewJumpers = new System.Windows.Forms.DataGridView();
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.labelAllJumpers = new System.Windows.Forms.Label();
            this.labelAllCountries = new System.Windows.Forms.Label();
            this.labelJumperFirstName = new System.Windows.Forms.Label();
            this.labelJumperLastName = new System.Windows.Forms.Label();
            this.labelJumperBirthdate = new System.Windows.Forms.Label();
            this.labelJumperCountryId = new System.Windows.Forms.Label();
            this.dateTimePickerJumper = new System.Windows.Forms.DateTimePicker();
            this.textBoxJumperFirstName = new System.Windows.Forms.TextBox();
            this.textBoxJumperLastName = new System.Windows.Forms.TextBox();
            this.textBoxJumperCountryId = new System.Windows.Forms.TextBox();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.labelCountryRecord = new System.Windows.Forms.Label();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.textBoxCountryRecord = new System.Windows.Forms.TextBox();
            this.buttonJumperAdd = new System.Windows.Forms.Button();
            this.buttonCountryAdd = new System.Windows.Forms.Button();
            this.buttonJumperDelete = new System.Windows.Forms.Button();
            this.buttonJumperUpdate = new System.Windows.Forms.Button();
            this.buttonJumperShow = new System.Windows.Forms.Button();
            this.buttonCountryShow = new System.Windows.Forms.Button();
            this.buttonCountryUpdate = new System.Windows.Forms.Button();
            this.buttonCountryDelete = new System.Windows.Forms.Button();
            this.buttonJumperSaveChanges = new System.Windows.Forms.Button();
            this.textBoxUpdateCountryId = new System.Windows.Forms.TextBox();
            this.textBoxUpdateJumperLastName = new System.Windows.Forms.TextBox();
            this.textBoxUpdateJumperFirstName = new System.Windows.Forms.TextBox();
            this.dateTimePickerUpdateJumper = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUpdateJumperId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelXDDD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJumpers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewJumpers
            // 
            this.dataGridViewJumpers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJumpers.Location = new System.Drawing.Point(9, 239);
            this.dataGridViewJumpers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewJumpers.Name = "dataGridViewJumpers";
            this.dataGridViewJumpers.RowTemplate.Height = 24;
            this.dataGridViewJumpers.Size = new System.Drawing.Size(355, 231);
            this.dataGridViewJumpers.TabIndex = 0;
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Location = new System.Drawing.Point(381, 239);
            this.dataGridViewCountries.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.RowTemplate.Height = 24;
            this.dataGridViewCountries.Size = new System.Drawing.Size(355, 232);
            this.dataGridViewCountries.TabIndex = 1;
            // 
            // labelAllJumpers
            // 
            this.labelAllJumpers.AutoSize = true;
            this.labelAllJumpers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAllJumpers.Location = new System.Drawing.Point(87, 213);
            this.labelAllJumpers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAllJumpers.Name = "labelAllJumpers";
            this.labelAllJumpers.Size = new System.Drawing.Size(217, 26);
            this.labelAllJumpers.TabIndex = 2;
            this.labelAllJumpers.Text = "Wszyscy skoczkowie";
            // 
            // labelAllCountries
            // 
            this.labelAllCountries.AutoSize = true;
            this.labelAllCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAllCountries.Location = new System.Drawing.Point(496, 206);
            this.labelAllCountries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAllCountries.Name = "labelAllCountries";
            this.labelAllCountries.Size = new System.Drawing.Size(164, 26);
            this.labelAllCountries.TabIndex = 3;
            this.labelAllCountries.Text = "Wszystkie kraje";
            // 
            // labelJumperFirstName
            // 
            this.labelJumperFirstName.AutoSize = true;
            this.labelJumperFirstName.Location = new System.Drawing.Point(42, 13);
            this.labelJumperFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJumperFirstName.Name = "labelJumperFirstName";
            this.labelJumperFirstName.Size = new System.Drawing.Size(26, 13);
            this.labelJumperFirstName.TabIndex = 4;
            this.labelJumperFirstName.Text = "Imię";
            // 
            // labelJumperLastName
            // 
            this.labelJumperLastName.AutoSize = true;
            this.labelJumperLastName.Location = new System.Drawing.Point(16, 41);
            this.labelJumperLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJumperLastName.Name = "labelJumperLastName";
            this.labelJumperLastName.Size = new System.Drawing.Size(53, 13);
            this.labelJumperLastName.TabIndex = 5;
            this.labelJumperLastName.Text = "Nazwisko";
            // 
            // labelJumperBirthdate
            // 
            this.labelJumperBirthdate.AutoSize = true;
            this.labelJumperBirthdate.Location = new System.Drawing.Point(0, 76);
            this.labelJumperBirthdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJumperBirthdate.Name = "labelJumperBirthdate";
            this.labelJumperBirthdate.Size = new System.Drawing.Size(67, 13);
            this.labelJumperBirthdate.TabIndex = 6;
            this.labelJumperBirthdate.Text = "Data urodzin";
            // 
            // labelJumperCountryId
            // 
            this.labelJumperCountryId.AutoSize = true;
            this.labelJumperCountryId.Location = new System.Drawing.Point(26, 106);
            this.labelJumperCountryId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJumperCountryId.Name = "labelJumperCountryId";
            this.labelJumperCountryId.Size = new System.Drawing.Size(42, 13);
            this.labelJumperCountryId.TabIndex = 7;
            this.labelJumperCountryId.Text = "Id kraju";
            // 
            // dateTimePickerJumper
            // 
            this.dateTimePickerJumper.Location = new System.Drawing.Point(92, 76);
            this.dateTimePickerJumper.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerJumper.Name = "dateTimePickerJumper";
            this.dateTimePickerJumper.Size = new System.Drawing.Size(126, 20);
            this.dateTimePickerJumper.TabIndex = 8;
            // 
            // textBoxJumperFirstName
            // 
            this.textBoxJumperFirstName.Location = new System.Drawing.Point(92, 11);
            this.textBoxJumperFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJumperFirstName.Name = "textBoxJumperFirstName";
            this.textBoxJumperFirstName.Size = new System.Drawing.Size(126, 20);
            this.textBoxJumperFirstName.TabIndex = 9;
            // 
            // textBoxJumperLastName
            // 
            this.textBoxJumperLastName.Location = new System.Drawing.Point(92, 41);
            this.textBoxJumperLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJumperLastName.Name = "textBoxJumperLastName";
            this.textBoxJumperLastName.Size = new System.Drawing.Size(126, 20);
            this.textBoxJumperLastName.TabIndex = 10;
            // 
            // textBoxJumperCountryId
            // 
            this.textBoxJumperCountryId.Location = new System.Drawing.Point(92, 106);
            this.textBoxJumperCountryId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJumperCountryId.Name = "textBoxJumperCountryId";
            this.textBoxJumperCountryId.Size = new System.Drawing.Size(126, 20);
            this.textBoxJumperCountryId.TabIndex = 11;
            // 
            // labelCountryName
            // 
            this.labelCountryName.AutoSize = true;
            this.labelCountryName.Location = new System.Drawing.Point(4, 7);
            this.labelCountryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(66, 13);
            this.labelCountryName.TabIndex = 12;
            this.labelCountryName.Text = "Nazwa kraju";
            // 
            // labelCountryRecord
            // 
            this.labelCountryRecord.AutoSize = true;
            this.labelCountryRecord.Location = new System.Drawing.Point(1, 50);
            this.labelCountryRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountryRecord.Name = "labelCountryRecord";
            this.labelCountryRecord.Size = new System.Drawing.Size(68, 13);
            this.labelCountryRecord.TabIndex = 13;
            this.labelCountryRecord.Text = "Rekord kraju";
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(100, 7);
            this.textBoxCountryName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(122, 20);
            this.textBoxCountryName.TabIndex = 14;
            // 
            // textBoxCountryRecord
            // 
            this.textBoxCountryRecord.Location = new System.Drawing.Point(100, 50);
            this.textBoxCountryRecord.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCountryRecord.Name = "textBoxCountryRecord";
            this.textBoxCountryRecord.Size = new System.Drawing.Size(122, 20);
            this.textBoxCountryRecord.TabIndex = 15;
            // 
            // buttonJumperAdd
            // 
            this.buttonJumperAdd.Location = new System.Drawing.Point(92, 142);
            this.buttonJumperAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonJumperAdd.Name = "buttonJumperAdd";
            this.buttonJumperAdd.Size = new System.Drawing.Size(124, 19);
            this.buttonJumperAdd.TabIndex = 16;
            this.buttonJumperAdd.Text = "Dodaj skoczka";
            this.buttonJumperAdd.UseVisualStyleBackColor = true;
            this.buttonJumperAdd.Click += new System.EventHandler(this.buttonJumperAdd_Click);
            // 
            // buttonCountryAdd
            // 
            this.buttonCountryAdd.Location = new System.Drawing.Point(100, 89);
            this.buttonCountryAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCountryAdd.Name = "buttonCountryAdd";
            this.buttonCountryAdd.Size = new System.Drawing.Size(122, 19);
            this.buttonCountryAdd.TabIndex = 17;
            this.buttonCountryAdd.Text = "Dodaj kraj";
            this.buttonCountryAdd.UseVisualStyleBackColor = true;
            this.buttonCountryAdd.Click += new System.EventHandler(this.buttonCountryAdd_Click);
            // 
            // buttonJumperDelete
            // 
            this.buttonJumperDelete.Location = new System.Drawing.Point(9, 474);
            this.buttonJumperDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonJumperDelete.Name = "buttonJumperDelete";
            this.buttonJumperDelete.Size = new System.Drawing.Size(112, 24);
            this.buttonJumperDelete.TabIndex = 18;
            this.buttonJumperDelete.Text = "Usuń skoczka";
            this.buttonJumperDelete.UseVisualStyleBackColor = true;
            this.buttonJumperDelete.Click += new System.EventHandler(this.buttonJumperDelete_Click);
            // 
            // buttonJumperUpdate
            // 
            this.buttonJumperUpdate.Location = new System.Drawing.Point(126, 474);
            this.buttonJumperUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonJumperUpdate.Name = "buttonJumperUpdate";
            this.buttonJumperUpdate.Size = new System.Drawing.Size(110, 24);
            this.buttonJumperUpdate.TabIndex = 19;
            this.buttonJumperUpdate.Text = "Edytuj skoczka";
            this.buttonJumperUpdate.UseVisualStyleBackColor = true;
            this.buttonJumperUpdate.Click += new System.EventHandler(this.buttonJumperUpdate_Click);
            // 
            // buttonJumperShow
            // 
            this.buttonJumperShow.Location = new System.Drawing.Point(241, 474);
            this.buttonJumperShow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonJumperShow.Name = "buttonJumperShow";
            this.buttonJumperShow.Size = new System.Drawing.Size(123, 24);
            this.buttonJumperShow.TabIndex = 20;
            this.buttonJumperShow.Text = "Wyświetl Kraj";
            this.buttonJumperShow.UseVisualStyleBackColor = true;
            this.buttonJumperShow.Click += new System.EventHandler(this.buttonJumperShow_Click);
            // 
            // buttonCountryShow
            // 
            this.buttonCountryShow.Location = new System.Drawing.Point(594, 474);
            this.buttonCountryShow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCountryShow.Name = "buttonCountryShow";
            this.buttonCountryShow.Size = new System.Drawing.Size(143, 24);
            this.buttonCountryShow.TabIndex = 23;
            this.buttonCountryShow.Text = "Wyświetl ilość skoczków";
            this.buttonCountryShow.UseVisualStyleBackColor = true;
            this.buttonCountryShow.Click += new System.EventHandler(this.buttonCountryShow_Click);
            // 
            // buttonCountryUpdate
            // 
            this.buttonCountryUpdate.Location = new System.Drawing.Point(500, 474);
            this.buttonCountryUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCountryUpdate.Name = "buttonCountryUpdate";
            this.buttonCountryUpdate.Size = new System.Drawing.Size(90, 24);
            this.buttonCountryUpdate.TabIndex = 22;
            this.buttonCountryUpdate.Text = "Edytuj kraj";
            this.buttonCountryUpdate.UseVisualStyleBackColor = true;
            this.buttonCountryUpdate.Click += new System.EventHandler(this.buttonCountryUpdate_Click);
            // 
            // buttonCountryDelete
            // 
            this.buttonCountryDelete.Location = new System.Drawing.Point(382, 474);
            this.buttonCountryDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCountryDelete.Name = "buttonCountryDelete";
            this.buttonCountryDelete.Size = new System.Drawing.Size(112, 24);
            this.buttonCountryDelete.TabIndex = 21;
            this.buttonCountryDelete.Text = "Usuń kraj";
            this.buttonCountryDelete.UseVisualStyleBackColor = true;
            this.buttonCountryDelete.Click += new System.EventHandler(this.buttonCountryDelete_Click);
            // 
            // buttonJumperSaveChanges
            // 
            this.buttonJumperSaveChanges.Location = new System.Drawing.Point(148, 181);
            this.buttonJumperSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.buttonJumperSaveChanges.Name = "buttonJumperSaveChanges";
            this.buttonJumperSaveChanges.Size = new System.Drawing.Size(124, 19);
            this.buttonJumperSaveChanges.TabIndex = 32;
            this.buttonJumperSaveChanges.Text = "Zapisz zmiany";
            this.buttonJumperSaveChanges.UseVisualStyleBackColor = true;
            this.buttonJumperSaveChanges.Click += new System.EventHandler(this.buttonJumperSaveChanges_Click);
            // 
            // textBoxUpdateCountryId
            // 
            this.textBoxUpdateCountryId.Location = new System.Drawing.Point(148, 148);
            this.textBoxUpdateCountryId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUpdateCountryId.Name = "textBoxUpdateCountryId";
            this.textBoxUpdateCountryId.Size = new System.Drawing.Size(126, 20);
            this.textBoxUpdateCountryId.TabIndex = 31;
            // 
            // textBoxUpdateJumperLastName
            // 
            this.textBoxUpdateJumperLastName.Location = new System.Drawing.Point(148, 82);
            this.textBoxUpdateJumperLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUpdateJumperLastName.Name = "textBoxUpdateJumperLastName";
            this.textBoxUpdateJumperLastName.Size = new System.Drawing.Size(126, 20);
            this.textBoxUpdateJumperLastName.TabIndex = 30;
            // 
            // textBoxUpdateJumperFirstName
            // 
            this.textBoxUpdateJumperFirstName.Location = new System.Drawing.Point(148, 41);
            this.textBoxUpdateJumperFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUpdateJumperFirstName.Name = "textBoxUpdateJumperFirstName";
            this.textBoxUpdateJumperFirstName.Size = new System.Drawing.Size(126, 20);
            this.textBoxUpdateJumperFirstName.TabIndex = 29;
            // 
            // dateTimePickerUpdateJumper
            // 
            this.dateTimePickerUpdateJumper.Location = new System.Drawing.Point(148, 116);
            this.dateTimePickerUpdateJumper.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerUpdateJumper.Name = "dateTimePickerUpdateJumper";
            this.dateTimePickerUpdateJumper.Size = new System.Drawing.Size(126, 20);
            this.dateTimePickerUpdateJumper.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Id kraju";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Data urodzin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Imię";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxUpdateJumperId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonJumperSaveChanges);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxUpdateJumperLastName);
            this.panel1.Controls.Add(this.textBoxUpdateCountryId);
            this.panel1.Controls.Add(this.textBoxUpdateJumperFirstName);
            this.panel1.Controls.Add(this.dateTimePickerUpdateJumper);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(26, 556);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 211);
            this.panel1.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Id";
            // 
            // textBoxUpdateJumperId
            // 
            this.textBoxUpdateJumperId.Location = new System.Drawing.Point(148, 2);
            this.textBoxUpdateJumperId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUpdateJumperId.Name = "textBoxUpdateJumperId";
            this.textBoxUpdateJumperId.Size = new System.Drawing.Size(126, 20);
            this.textBoxUpdateJumperId.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonJumperAdd);
            this.panel2.Controls.Add(this.textBoxJumperCountryId);
            this.panel2.Controls.Add(this.textBoxJumperLastName);
            this.panel2.Controls.Add(this.textBoxJumperFirstName);
            this.panel2.Controls.Add(this.dateTimePickerJumper);
            this.panel2.Controls.Add(this.labelJumperCountryId);
            this.panel2.Controls.Add(this.labelJumperBirthdate);
            this.panel2.Controls.Add(this.labelJumperLastName);
            this.panel2.Controls.Add(this.labelJumperFirstName);
            this.panel2.Location = new System.Drawing.Point(7, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 170);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonCountryAdd);
            this.panel3.Controls.Add(this.textBoxCountryRecord);
            this.panel3.Controls.Add(this.textBoxCountryName);
            this.panel3.Controls.Add(this.labelCountryRecord);
            this.panel3.Controls.Add(this.labelCountryName);
            this.panel3.Location = new System.Drawing.Point(349, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 118);
            this.panel3.TabIndex = 35;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.29091F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(349, 139);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(208, 37);
            this.labelName.TabIndex = 36;
            this.labelName.Text = "Daria Hornik";
            // 
            // labelXDDD
            // 
            this.labelXDDD.AutoSize = true;
            this.labelXDDD.Location = new System.Drawing.Point(397, 585);
            this.labelXDDD.Name = "labelXDDD";
            this.labelXDDD.Size = new System.Drawing.Size(35, 13);
            this.labelXDDD.TabIndex = 37;
            this.labelXDDD.Text = "label6";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(745, 776);
            this.Controls.Add(this.labelXDDD);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonCountryShow);
            this.Controls.Add(this.buttonCountryUpdate);
            this.Controls.Add(this.buttonCountryDelete);
            this.Controls.Add(this.buttonJumperShow);
            this.Controls.Add(this.buttonJumperUpdate);
            this.Controls.Add(this.buttonJumperDelete);
            this.Controls.Add(this.labelAllCountries);
            this.Controls.Add(this.labelAllJumpers);
            this.Controls.Add(this.dataGridViewCountries);
            this.Controls.Add(this.dataGridViewJumpers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJumpers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJumpers;
        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.Label labelAllJumpers;
        private System.Windows.Forms.Label labelAllCountries;
        private System.Windows.Forms.Label labelJumperFirstName;
        private System.Windows.Forms.Label labelJumperLastName;
        private System.Windows.Forms.Label labelJumperBirthdate;
        private System.Windows.Forms.Label labelJumperCountryId;
        private System.Windows.Forms.DateTimePicker dateTimePickerJumper;
        private System.Windows.Forms.TextBox textBoxJumperFirstName;
        private System.Windows.Forms.TextBox textBoxJumperLastName;
        private System.Windows.Forms.TextBox textBoxJumperCountryId;
        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.Label labelCountryRecord;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.TextBox textBoxCountryRecord;
        private System.Windows.Forms.Button buttonJumperAdd;
        private System.Windows.Forms.Button buttonCountryAdd;
        private System.Windows.Forms.Button buttonJumperDelete;
        private System.Windows.Forms.Button buttonJumperUpdate;
        private System.Windows.Forms.Button buttonJumperShow;
        private System.Windows.Forms.Button buttonCountryShow;
        private System.Windows.Forms.Button buttonCountryUpdate;
        private System.Windows.Forms.Button buttonCountryDelete;
        private System.Windows.Forms.Button buttonJumperSaveChanges;
        private System.Windows.Forms.TextBox textBoxUpdateCountryId;
        private System.Windows.Forms.TextBox textBoxUpdateJumperLastName;
        private System.Windows.Forms.TextBox textBoxUpdateJumperFirstName;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpdateJumper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUpdateJumperId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelXDDD;
    }
}

