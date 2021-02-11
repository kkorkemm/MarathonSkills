
namespace MarathonApplication
{
    partial class RegisterAsRunnerForm
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
            this.loginButton1 = new MarathonApplication.LoginButton();
            this.OldRunnerBtn = new System.Windows.Forms.Button();
            this.NewRunnerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1162, 92);
            this.header1.TabIndex = 0;
            // 
            // footer1
            // 
            this.footer1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Location = new System.Drawing.Point(0, 495);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1162, 62);
            this.footer1.TabIndex = 1;
            // 
            // loginButton1
            // 
            this.loginButton1.Location = new System.Drawing.Point(483, 388);
            this.loginButton1.Name = "loginButton1";
            this.loginButton1.Size = new System.Drawing.Size(187, 65);
            this.loginButton1.TabIndex = 2;
            // 
            // OldRunnerBtn
            // 
            this.OldRunnerBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldRunnerBtn.Location = new System.Drawing.Point(364, 124);
            this.OldRunnerBtn.Name = "OldRunnerBtn";
            this.OldRunnerBtn.Size = new System.Drawing.Size(421, 92);
            this.OldRunnerBtn.TabIndex = 3;
            this.OldRunnerBtn.Text = "Я участвовал ранее";
            this.OldRunnerBtn.UseVisualStyleBackColor = true;
            this.OldRunnerBtn.Click += new System.EventHandler(this.OldRunnerBtn_Click);
            // 
            // NewRunnerBtn
            // 
            this.NewRunnerBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRunnerBtn.Location = new System.Drawing.Point(364, 243);
            this.NewRunnerBtn.Name = "NewRunnerBtn";
            this.NewRunnerBtn.Size = new System.Drawing.Size(421, 92);
            this.NewRunnerBtn.TabIndex = 4;
            this.NewRunnerBtn.Text = "Я новый участник";
            this.NewRunnerBtn.UseVisualStyleBackColor = true;
            this.NewRunnerBtn.Click += new System.EventHandler(this.NewRunnerBtn_Click);
            // 
            // RegisterAsRunnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 557);
            this.Controls.Add(this.NewRunnerBtn);
            this.Controls.Add(this.OldRunnerBtn);
            this.Controls.Add(this.loginButton1);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.header1);
            this.Name = "RegisterAsRunnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2016 – Register as a runner";
            this.ResumeLayout(false);

        }

        #endregion

        private Header header1;
        private Footer footer1;
        private LoginButton loginButton1;
        private System.Windows.Forms.Button OldRunnerBtn;
        private System.Windows.Forms.Button NewRunnerBtn;
    }
}