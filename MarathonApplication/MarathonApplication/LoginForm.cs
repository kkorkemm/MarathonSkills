using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarathonApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            EmailText.Clear();
            EmailText.Focus();
            PasswordText.Clear();
        }

        private void LoginBtn2_Click(object sender, EventArgs e)
        {
            TestRegisterForm testRegister = new TestRegisterForm();
            testRegister.Show();
        }
    }
}
