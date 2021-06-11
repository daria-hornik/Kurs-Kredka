namespace DariaHornikLab1
{
    partial class FormMain
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
            this.labelDaria = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonObraz = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.textBoxCount2 = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.buttonNewWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDaria
            // 
            this.labelDaria.AutoSize = true;
            this.labelDaria.Font = new System.Drawing.Font("Microsoft Tai Le", 26.18182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelDaria.Location = new System.Drawing.Point(259, 18);
            this.labelDaria.Name = "labelDaria";
            this.labelDaria.Size = new System.Drawing.Size(249, 52);
            this.labelDaria.TabIndex = 0;
            this.labelDaria.Text = "Daria Hornik";
            this.labelDaria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonColor.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 26.18182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonColor.Location = new System.Drawing.Point(457, 342);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(283, 73);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonObraz
            // 
            this.buttonObraz.Location = new System.Drawing.Point(0, 0);
            this.buttonObraz.Name = "buttonObraz";
            this.buttonObraz.Size = new System.Drawing.Size(75, 23);
            this.buttonObraz.TabIndex = 6;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCount.Location = new System.Drawing.Point(59, 138);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(132, 35);
            this.textBoxCount.TabIndex = 3;
            this.textBoxCount.Text = "liczba1";
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // buttonCount
            // 
            this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCount.Location = new System.Drawing.Point(226, 179);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(123, 35);
            this.buttonCount.TabIndex = 4;
            this.buttonCount.Text = "policz";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // textBoxCount2
            // 
            this.textBoxCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCount2.Location = new System.Drawing.Point(59, 179);
            this.textBoxCount2.Name = "textBoxCount2";
            this.textBoxCount2.Size = new System.Drawing.Size(132, 35);
            this.textBoxCount2.TabIndex = 5;
            this.textBoxCount2.Text = "liczba2";
            this.textBoxCount2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(59, 370);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(87, 29);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerCount
            // 
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Location = new System.Drawing.Point(59, 290);
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(87, 30);
            this.buttonNewWindow.TabIndex = 8;
            this.buttonNewWindow.Text = "nowe okno";
            this.buttonNewWindow.UseVisualStyleBackColor = true;
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNewWindow);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxCount2);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonObraz);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.labelDaria);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDaria;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonObraz;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox textBoxCount2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.Button buttonNewWindow;
    }
}

