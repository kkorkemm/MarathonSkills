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
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            foreach (Form form in Application.OpenForms.Cast<Form>())
                form.Hide();
            main.Show();
        }
    }
}
