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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void BMICalcBtn_Click(object sender, EventArgs e)
        {
            BmiCalcForm bmiCalc = new BmiCalcForm();
            bmiCalc.Show();
            Hide();
        }
    }
}
