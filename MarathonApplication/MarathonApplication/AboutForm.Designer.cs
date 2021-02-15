
namespace MarathonApplication
{
    partial class AboutForm
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
            this.header1 = new MarathonApplication.Header();
            this.footer1 = new MarathonApplication.Footer();
            this.label1 = new System.Windows.Forms.Label();
            this.AboutMarBtn = new System.Windows.Forms.Button();
            this.HowLongBtn = new System.Windows.Forms.Button();
            this.OldResultsBtn = new System.Windows.Forms.Button();
            this.ListOrgBtn = new System.Windows.Forms.Button();
            this.BMICalcBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(999, 92);
            this.header1.TabIndex = 0;
            // 
            // footer1
            // 
            this.footer1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Location = new System.Drawing.Point(0, 604);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(999, 62);
            this.footer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(241, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Подробная информация";
            // 
            // AboutMarBtn
            // 
            this.AboutMarBtn.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutMarBtn.Location = new System.Drawing.Point(111, 233);
            this.AboutMarBtn.Name = "AboutMarBtn";
            this.AboutMarBtn.Size = new System.Drawing.Size(345, 85);
            this.AboutMarBtn.TabIndex = 11;
            this.AboutMarBtn.Text = "Marathon Skills 2016";
            this.AboutMarBtn.UseVisualStyleBackColor = true;
            // 
            // HowLongBtn
            // 
            this.HowLongBtn.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HowLongBtn.Location = new System.Drawing.Point(529, 233);
            this.HowLongBtn.Name = "HowLongBtn";
            this.HowLongBtn.Size = new System.Drawing.Size(345, 85);
            this.HowLongBtn.TabIndex = 12;
            this.HowLongBtn.Text = "Насколько долгий марафон\r\n";
            this.HowLongBtn.UseVisualStyleBackColor = true;
            // 
            // OldResultsBtn
            // 
            this.OldResultsBtn.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldResultsBtn.Location = new System.Drawing.Point(111, 336);
            this.OldResultsBtn.Name = "OldResultsBtn";
            this.OldResultsBtn.Size = new System.Drawing.Size(345, 85);
            this.OldResultsBtn.TabIndex = 13;
            this.OldResultsBtn.Text = "Предыдущие результаты";
            this.OldResultsBtn.UseVisualStyleBackColor = true;
            // 
            // ListOrgBtn
            // 
            this.ListOrgBtn.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOrgBtn.Location = new System.Drawing.Point(529, 336);
            this.ListOrgBtn.Name = "ListOrgBtn";
            this.ListOrgBtn.Size = new System.Drawing.Size(345, 85);
            this.ListOrgBtn.TabIndex = 14;
            this.ListOrgBtn.Text = "Список благотворительных организаций";
            this.ListOrgBtn.UseVisualStyleBackColor = true;
            // 
            // BMICalcBtn
            // 
            this.BMICalcBtn.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMICalcBtn.Location = new System.Drawing.Point(111, 440);
            this.BMICalcBtn.Name = "BMICalcBtn";
            this.BMICalcBtn.Size = new System.Drawing.Size(345, 85);
            this.BMICalcBtn.TabIndex = 15;
            this.BMICalcBtn.Text = "BMI калькулятор";
            this.BMICalcBtn.UseVisualStyleBackColor = true;
            this.BMICalcBtn.Click += new System.EventHandler(this.BMICalcBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(529, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 85);
            this.button1.TabIndex = 16;
            this.button1.Text = "BMR калькулятор";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BMICalcBtn);
            this.Controls.Add(this.ListOrgBtn);
            this.Controls.Add(this.OldResultsBtn);
            this.Controls.Add(this.HowLongBtn);
            this.Controls.Add(this.AboutMarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.header1);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2016 – Find out more information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Header header1;
        private Footer footer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AboutMarBtn;
        private System.Windows.Forms.Button HowLongBtn;
        private System.Windows.Forms.Button OldResultsBtn;
        private System.Windows.Forms.Button ListOrgBtn;
        private System.Windows.Forms.Button BMICalcBtn;
        private System.Windows.Forms.Button button1;
    }
}