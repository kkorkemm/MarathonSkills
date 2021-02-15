
namespace MarathonApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ForRunnerBtn = new System.Windows.Forms.Button();
            this.ForSponsorBtn = new System.Windows.Forms.Button();
            this.ForKnowBtn = new System.Windows.Forms.Button();
            this.loginButton1 = new MarathonApplication.LoginButton();
            this.footer1 = new MarathonApplication.Footer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1314, 296);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1314, 252);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Verdana", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1314, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARATHON SKILLS 2016";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(0, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1314, 103);
            this.label2.TabIndex = 1;
            this.label2.Text = "Москва, Россия\r\nсреда 21 октября 2016\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForRunnerBtn
            // 
            this.ForRunnerBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForRunnerBtn.Location = new System.Drawing.Point(391, 334);
            this.ForRunnerBtn.Name = "ForRunnerBtn";
            this.ForRunnerBtn.Size = new System.Drawing.Size(517, 74);
            this.ForRunnerBtn.TabIndex = 3;
            this.ForRunnerBtn.Text = "Я хочу стать бегуном";
            this.ForRunnerBtn.UseVisualStyleBackColor = true;
            this.ForRunnerBtn.Click += new System.EventHandler(this.ForRunnerBtn_Click);
            // 
            // ForSponsorBtn
            // 
            this.ForSponsorBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForSponsorBtn.Location = new System.Drawing.Point(391, 430);
            this.ForSponsorBtn.Name = "ForSponsorBtn";
            this.ForSponsorBtn.Size = new System.Drawing.Size(517, 74);
            this.ForSponsorBtn.TabIndex = 4;
            this.ForSponsorBtn.Text = "Я хочу стать спонсором бегуна";
            this.ForSponsorBtn.UseVisualStyleBackColor = true;
            this.ForSponsorBtn.Click += new System.EventHandler(this.ForSponsorBtn_Click);
            // 
            // ForKnowBtn
            // 
            this.ForKnowBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForKnowBtn.Location = new System.Drawing.Point(391, 526);
            this.ForKnowBtn.Name = "ForKnowBtn";
            this.ForKnowBtn.Size = new System.Drawing.Size(517, 74);
            this.ForKnowBtn.TabIndex = 5;
            this.ForKnowBtn.Text = "Я хочу узнать больше о событии";
            this.ForKnowBtn.UseVisualStyleBackColor = true;
            this.ForKnowBtn.Click += new System.EventHandler(this.ForKnowBtn_Click);
            // 
            // loginButton1
            // 
            this.loginButton1.Location = new System.Drawing.Point(1033, 535);
            this.loginButton1.Name = "loginButton1";
            this.loginButton1.Size = new System.Drawing.Size(187, 65);
            this.loginButton1.TabIndex = 8;
            // 
            // footer1
            // 
            this.footer1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Location = new System.Drawing.Point(0, 768);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1314, 62);
            this.footer1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 830);
            this.Controls.Add(this.loginButton1);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.ForKnowBtn);
            this.Controls.Add(this.ForSponsorBtn);
            this.Controls.Add(this.ForRunnerBtn);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2016";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ForRunnerBtn;
        private System.Windows.Forms.Button ForSponsorBtn;
        private System.Windows.Forms.Button ForKnowBtn;
        private Footer footer1;
        private LoginButton loginButton1;
    }
}

