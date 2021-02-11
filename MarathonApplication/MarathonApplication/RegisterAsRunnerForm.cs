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
    public partial class RegisterAsRunnerForm : Form
    {
        public RegisterAsRunnerForm()
        {
            InitializeComponent();
        }

        private void OldRunnerBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            foreach (Form form in Application.OpenForms.Cast<Form>())
                form.Hide();
            login.Show();

        }

        private void NewRunnerBtn_Click(object sender, EventArgs e)
        {
            RunnerRegistForm runnerRegistration = new RunnerRegistForm();
            foreach (Form form in Application.OpenForms.Cast<Form>())
                form.Hide();
            runnerRegistration.Show();

        }
    }
}
