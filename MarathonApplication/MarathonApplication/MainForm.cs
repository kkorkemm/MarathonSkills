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
    public partial class MainForm : Form
    {
      
        public MainForm()
        {
            InitializeComponent();
        }

        private void ForRunnerBtn_Click(object sender, EventArgs e)
        {
            RegisterAsRunnerForm runner = new RegisterAsRunnerForm();
            runner.Show();
            Hide();
        }

        private void ForSponsorBtn_Click(object sender, EventArgs e)
        {

        }

        private void ForKnowBtn_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
            Hide();
        }


    }
}
