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
    public partial class LoginButton : UserControl
    {
        public LoginButton()
        {
            InitializeComponent();
        }

        public void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            foreach (Form form in Application.OpenForms.Cast<Form>())
                form.Hide();
            login.Show();
        }
    }
}
