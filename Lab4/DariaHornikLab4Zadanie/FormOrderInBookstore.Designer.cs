namespace DariaHornikLab4Zadanie
{
    partial class FormOrderInBookstore
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
            this.tableLayoutPanelOrderInBookstore = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewOrderInBookstore = new System.Windows.Forms.DataGridView();
            this.groupBoxOrderInBookstore = new System.Windows.Forms.GroupBox();
            this.buttonSellBook = new System.Windows.Forms.Button();
            this.buttonRefreshBookstore = new System.Windows.Forms.Button();
            this.buttonOrderInBookstore = new System.Windows.Forms.Button();
            this.groupBoxSellBook = new System.Windows.Forms.GroupBox();
            this.textBoxNumberOfItem = new System.Windows.Forms.TextBox();
            this.buttonAcceptSales = new System.Windows.Forms.Button();
            this.textBoxBookDate = new System.Windows.Forms.TextBox();
            this.textBoxBookLanguage = new System.Windows.Forms.TextBox();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.textBoxBookAutor = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelOrderInBookstore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderInBookstore)).BeginInit();
            this.groupBoxOrderInBookstore.SuspendLayout();
            this.groupBoxSellBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelOrderInBookstore
            // 
            this.tableLayoutPanelOrderInBookstore.BackgroundImage = global::Homework4.Properties.Resources.wallpaper_1614871_19201;
            this.tableLayoutPanelOrderInBookstore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanelOrderInBookstore.ColumnCount = 3;
            this.tableLayoutPanelOrderInBookstore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.73529F));
            this.tableLayoutPanelOrderInBookstore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.26471F));
            this.tableLayoutPanelOrderInBookstore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanelOrderInBookstore.Controls.Add(this.dataGridViewOrderInBookstore, 1, 1);
            this.tableLayoutPanelOrderInBookstore.Controls.Add(this.groupBoxOrderInBookstore, 1, 2);
            this.tableLayoutPanelOrderInBookstore.Controls.Add(this.groupBoxSellBook, 2, 1);
            this.tableLayoutPanelOrderInBookstore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOrderInBookstore.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelOrderInBookstore.Name = "tableLayoutPanelOrderInBookstore";
            this.tableLayoutPanelOrderInBookstore.RowCount = 3;
            this.tableLayoutPanelOrderInBookstore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.89324F));
            this.tableLayoutPanelOrderInBookstore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.10676F));
            this.tableLayoutPanelOrderInBookstore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanelOrderInBookstore.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelOrderInBookstore.TabIndex = 0;
            // 
            // dataGridViewOrderInBookstore
            // 
            this.dataGridViewOrderInBookstore.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewOrderInBookstore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderInBookstore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrderInBookstore.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewOrderInBookstore.Location = new System.Drawing.Point(143, 87);
            this.dataGridViewOrderInBookstore.Name = "dataGridViewOrderInBookstore";
            this.dataGridViewOrderInBookstore.Size = new System.Drawing.Size(398, 191);
            this.dataGridViewOrderInBookstore.TabIndex = 0;
            // 
            // groupBoxOrderInBookstore
            // 
            this.groupBoxOrderInBookstore.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxOrderInBookstore.Controls.Add(this.buttonSellBook);
            this.groupBoxOrderInBookstore.Controls.Add(this.buttonRefreshBookstore);
            this.groupBoxOrderInBookstore.Controls.Add(this.buttonOrderInBookstore);
            this.groupBoxOrderInBookstore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOrderInBookstore.Location = new System.Drawing.Point(143, 284);
            this.groupBoxOrderInBookstore.Name = "groupBoxOrderInBookstore";
            this.groupBoxOrderInBookstore.Size = new System.Drawing.Size(398, 163);
            this.groupBoxOrderInBookstore.TabIndex = 1;
            this.groupBoxOrderInBookstore.TabStop = false;
            // 
            // buttonSellBook
            // 
            this.buttonSellBook.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSellBook.Font = new System.Drawing.Font("Microsoft YaHei", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSellBook.Location = new System.Drawing.Point(239, 33);
            this.buttonSellBook.Name = "buttonSellBook";
            this.buttonSellBook.Size = new System.Drawing.Size(143, 35);
            this.buttonSellBook.TabIndex = 2;
            this.buttonSellBook.Text = "Sprzedaj książke";
            this.buttonSellBook.UseVisualStyleBackColor = false;
            this.buttonSellBook.Click += new System.EventHandler(this.buttonBuyToBookstore_Click);
            // 
            // buttonRefreshBookstore
            // 
            this.buttonRefreshBookstore.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRefreshBookstore.Font = new System.Drawing.Font("Microsoft YaHei", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefreshBookstore.Location = new System.Drawing.Point(131, 33);
            this.buttonRefreshBookstore.Name = "buttonRefreshBookstore";
            this.buttonRefreshBookstore.Size = new System.Drawing.Size(100, 35);
            this.buttonRefreshBookstore.TabIndex = 1;
            this.buttonRefreshBookstore.Text = "Odśwież";
            this.buttonRefreshBookstore.UseVisualStyleBackColor = false;
            this.buttonRefreshBookstore.Click += new System.EventHandler(this.buttonRefreshBookstore_Click);
            // 
            // buttonOrderInBookstore
            // 
            this.buttonOrderInBookstore.BackColor = System.Drawing.SystemColors.Window;
            this.buttonOrderInBookstore.Font = new System.Drawing.Font("Microsoft YaHei", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOrderInBookstore.Location = new System.Drawing.Point(13, 33);
            this.buttonOrderInBookstore.Name = "buttonOrderInBookstore";
            this.buttonOrderInBookstore.Size = new System.Drawing.Size(100, 35);
            this.buttonOrderInBookstore.TabIndex = 0;
            this.buttonOrderInBookstore.Text = "Zamów";
            this.buttonOrderInBookstore.UseVisualStyleBackColor = false;
            this.buttonOrderInBookstore.Click += new System.EventHandler(this.buttonOrderInBookstore_Click);
            // 
            // groupBoxSellBook
            // 
            this.groupBoxSellBook.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSellBook.Controls.Add(this.textBoxNumberOfItem);
            this.groupBoxSellBook.Controls.Add(this.buttonAcceptSales);
            this.groupBoxSellBook.Controls.Add(this.textBoxBookDate);
            this.groupBoxSellBook.Controls.Add(this.textBoxBookLanguage);
            this.groupBoxSellBook.Controls.Add(this.textBoxBookName);
            this.groupBoxSellBook.Controls.Add(this.textBoxBookAutor);
            this.groupBoxSellBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSellBook.Location = new System.Drawing.Point(547, 87);
            this.groupBoxSellBook.Name = "groupBoxSellBook";
            this.groupBoxSellBook.Size = new System.Drawing.Size(250, 191);
            this.groupBoxSellBook.TabIndex = 2;
            this.groupBoxSellBook.TabStop = false;
            // 
            // textBoxNumberOfItem
            // 
            this.textBoxNumberOfItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumberOfItem.Location = new System.Drawing.Point(0, 135);
            this.textBoxNumberOfItem.Name = "textBoxNumberOfItem";
            this.textBoxNumberOfItem.Size = new System.Drawing.Size(110, 26);
            this.textBoxNumberOfItem.TabIndex = 7;
            this.textBoxNumberOfItem.Text = "Nakład";
            this.textBoxNumberOfItem.Visible = false;
            // 
            // buttonAcceptSales
            // 
            this.buttonAcceptSales.Font = new System.Drawing.Font("Microsoft YaHei", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAcceptSales.Location = new System.Drawing.Point(160, 135);
            this.buttonAcceptSales.Name = "buttonAcceptSales";
            this.buttonAcceptSales.Size = new System.Drawing.Size(78, 27);
            this.buttonAcceptSales.TabIndex = 5;
            this.buttonAcceptSales.Text = "Ok";
            this.buttonAcceptSales.UseVisualStyleBackColor = true;
            this.buttonAcceptSales.Visible = false;
            this.buttonAcceptSales.Click += new System.EventHandler(this.buttonAcceptOrder_Click);
            // 
            // textBoxBookDate
            // 
            this.textBoxBookDate.Font = new System.Drawing.Font("Microsoft YaHei", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBookDate.Location = new System.Drawing.Point(0, 99);
            this.textBoxBookDate.Name = "textBoxBookDate";
            this.textBoxBookDate.Size = new System.Drawing.Size(110, 26);
            this.textBoxBookDate.TabIndex = 6;
            this.textBoxBookDate.Text = "Data premiery";
            this.textBoxBookDate.Visible = false;
            // 
            // textBoxBookLanguage
            // 
            this.textBoxBookLanguage.Font = new System.Drawing.Font("Microsoft YaHei", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBookLanguage.Location = new System.Drawing.Point(0, 66);
            this.textBoxBookLanguage.Name = "textBoxBookLanguage";
            this.textBoxBookLanguage.Size = new System.Drawing.Size(110, 26);
            this.textBoxBookLanguage.TabIndex = 5;
            this.textBoxBookLanguage.Text = "Język wydania";
            this.textBoxBookLanguage.Visible = false;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Font = new System.Drawing.Font("Microsoft YaHei", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBookName.Location = new System.Drawing.Point(0, 0);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(110, 26);
            this.textBoxBookName.TabIndex = 3;
            this.textBoxBookName.Text = "Imie";
            this.textBoxBookName.Visible = false;
            // 
            // textBoxBookAutor
            // 
            this.textBoxBookAutor.Font = new System.Drawing.Font("Microsoft YaHei", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBookAutor.Location = new System.Drawing.Point(0, 33);
            this.textBoxBookAutor.Name = "textBoxBookAutor";
            this.textBoxBookAutor.Size = new System.Drawing.Size(110, 26);
            this.textBoxBookAutor.TabIndex = 4;
            this.textBoxBookAutor.Text = "Nazwisko";
            this.textBoxBookAutor.Visible = false;
            // 
            // FormOrderInBookstore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelOrderInBookstore);
            this.Name = "FormOrderInBookstore";
            this.Text = "FormOrderInBookstore";
            this.tableLayoutPanelOrderInBookstore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderInBookstore)).EndInit();
            this.groupBoxOrderInBookstore.ResumeLayout(false);
            this.groupBoxSellBook.ResumeLayout(false);
            this.groupBoxSellBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOrderInBookstore;
        private System.Windows.Forms.DataGridView dataGridViewOrderInBookstore;
        private System.Windows.Forms.GroupBox groupBoxOrderInBookstore;
        private System.Windows.Forms.Button buttonRefreshBookstore;
        private System.Windows.Forms.Button buttonOrderInBookstore;
        private System.Windows.Forms.Button buttonSellBook;
        private System.Windows.Forms.Button buttonAcceptSales;
        private System.Windows.Forms.TextBox textBoxBookAutor;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.GroupBox groupBoxSellBook;
        private System.Windows.Forms.TextBox textBoxBookDate;
        private System.Windows.Forms.TextBox textBoxBookLanguage;
        private System.Windows.Forms.TextBox textBoxNumberOfItem;
    }
}