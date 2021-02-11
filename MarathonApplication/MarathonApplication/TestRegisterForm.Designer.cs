
namespace MarathonApplication
{
    partial class TestRegisterForm
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
            this.RegAsRunnerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegAsSponsorBtn = new System.Windows.Forms.Button();
            this.RegAsOrgBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegAsRunnerBtn
            // 
            this.RegAsRunnerBtn.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegAsRunnerBtn.Location = new System.Drawing.Point(292, 183);
            this.RegAsRunnerBtn.Name = "RegAsRunnerBtn";
            this.RegAsRunnerBtn.Size = new System.Drawing.Size(235, 70);
            this.RegAsRunnerBtn.TabIndex = 0;
            this.RegAsRunnerBtn.Text = "Бегун";
            this.RegAsRunnerBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(159, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "ТОЛЬКО ДЛЯ ТЕСТИРОВАНИЯ!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(174, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "Под каким пользователем вы хотите\r\n войти в систему?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegAsSponsorBtn
            // 
            this.RegAsSponsorBtn.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegAsSponsorBtn.Location = new System.Drawing.Point(292, 259);
            this.RegAsSponsorBtn.Name = "RegAsSponsorBtn";
            this.RegAsSponsorBtn.Size = new System.Drawing.Size(235, 70);
            this.RegAsSponsorBtn.TabIndex = 3;
            this.RegAsSponsorBtn.Text = "Координатор";
            this.RegAsSponsorBtn.UseVisualStyleBackColor = true;
            // 
            // RegAsOrgBtn
            // 
            this.RegAsOrgBtn.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegAsOrgBtn.Location = new System.Drawing.Point(292, 335);
            this.RegAsOrgBtn.Name = "RegAsOrgBtn";
            this.RegAsOrgBtn.Size = new System.Drawing.Size(235, 70);
            this.RegAsOrgBtn.TabIndex = 4;
            this.RegAsOrgBtn.Text = "Организатор";
            this.RegAsOrgBtn.UseVisualStyleBackColor = true;
            // 
            // TestRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegAsOrgBtn);
            this.Controls.Add(this.RegAsSponsorBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegAsRunnerBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestRegisterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegAsRunnerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegAsSponsorBtn;
        private System.Windows.Forms.Button RegAsOrgBtn;
    }
}