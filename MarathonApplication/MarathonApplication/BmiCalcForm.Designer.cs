
namespace MarathonApplication
{
    partial class BmiCalcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BmiCalcForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RostText = new System.Windows.Forms.TextBox();
            this.VesText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.BMItrackBar = new System.Windows.Forms.TrackBar();
            this.BmiLabel = new System.Windows.Forms.Label();
            this.DiagnozLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Diagnoz2Label = new System.Windows.Forms.Label();
            this.footer1 = new MarathonApplication.Footer();
            this.header1 = new MarathonApplication.Header();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BMItrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(341, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "BMI калькулятор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Информация о том что такое BMI \r\nи как калькулятор работает";
            // 
            // RostText
            // 
            this.RostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RostText.Location = new System.Drawing.Point(170, 431);
            this.RostText.Name = "RostText";
            this.RostText.Size = new System.Drawing.Size(147, 35);
            this.RostText.TabIndex = 6;
            // 
            // VesText
            // 
            this.VesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VesText.Location = new System.Drawing.Point(170, 481);
            this.VesText.Name = "VesText";
            this.VesText.Size = new System.Drawing.Size(147, 35);
            this.VesText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(66, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Рост: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(77, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вес: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(337, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "см";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(337, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "кг";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcBtn.Location = new System.Drawing.Point(57, 563);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(206, 52);
            this.CalcBtn.TabIndex = 13;
            this.CalcBtn.Text = "Рассчитать";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(286, 563);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(163, 52);
            this.CancelBtn.TabIndex = 14;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // BMItrackBar
            // 
            this.BMItrackBar.Enabled = false;
            this.BMItrackBar.Location = new System.Drawing.Point(563, 481);
            this.BMItrackBar.Maximum = 50;
            this.BMItrackBar.Name = "BMItrackBar";
            this.BMItrackBar.Size = new System.Drawing.Size(399, 69);
            this.BMItrackBar.TabIndex = 15;
            // 
            // BmiLabel
            // 
            this.BmiLabel.AutoSize = true;
            this.BmiLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BmiLabel.Location = new System.Drawing.Point(715, 431);
            this.BmiLabel.Name = "BmiLabel";
            this.BmiLabel.Size = new System.Drawing.Size(0, 29);
            this.BmiLabel.TabIndex = 16;
            // 
            // DiagnozLabel
            // 
            this.DiagnozLabel.AutoSize = true;
            this.DiagnozLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiagnozLabel.Location = new System.Drawing.Point(714, 553);
            this.DiagnozLabel.Name = "DiagnozLabel";
            this.DiagnozLabel.Size = new System.Drawing.Size(0, 29);
            this.DiagnozLabel.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Diagnoz2Label
            // 
            this.Diagnoz2Label.AutoSize = true;
            this.Diagnoz2Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Diagnoz2Label.Location = new System.Drawing.Point(49, 223);
            this.Diagnoz2Label.Name = "Diagnoz2Label";
            this.Diagnoz2Label.Size = new System.Drawing.Size(0, 29);
            this.Diagnoz2Label.TabIndex = 21;
            // 
            // footer1
            // 
            this.footer1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Location = new System.Drawing.Point(0, 670);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1079, 62);
            this.footer1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1079, 92);
            this.header1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Diagnoz2Label);
            this.panel1.Location = new System.Drawing.Point(763, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 266);
            this.panel1.TabIndex = 20;
            // 
            // BmiCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DiagnozLabel);
            this.Controls.Add(this.BmiLabel);
            this.Controls.Add(this.BMItrackBar);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VesText);
            this.Controls.Add(this.RostText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.header1);
            this.Name = "BmiCalcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2016 – BMI calculator";
            ((System.ComponentModel.ISupportInitialize)(this.BMItrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Header header1;
        private Footer footer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RostText;
        private System.Windows.Forms.TextBox VesText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TrackBar BMItrackBar;
        private System.Windows.Forms.Label BmiLabel;
        private System.Windows.Forms.Label DiagnozLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Diagnoz2Label;
        private System.Windows.Forms.Panel panel1;
    }
}