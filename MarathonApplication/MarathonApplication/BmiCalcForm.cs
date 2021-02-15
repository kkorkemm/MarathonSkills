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
    public partial class BmiCalcForm : Form
    {
        public BmiCalcForm()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            double rost = Convert.ToDouble(RostText.Text) / 100.0;
            double ves = Convert.ToDouble(VesText.Text);

            double result = ves / (rost * rost);
            string diagnoz;

            if (result <= 18.5)
            {
                diagnoz = "Недостаточный";
            }
            else if (result <= 25)
            {
                diagnoz = "Здоровый";
            }
            else if (result <= 35)
            {
                diagnoz = "Избыточный";
            }
            else
            {
                diagnoz = "Ожирение";
            }

            BmiLabel.Text = Math.Round(result, 2).ToString();
            DiagnozLabel.Text = diagnoz;
            Diagnoz2Label.Text = diagnoz;
            BMItrackBar.Value = Convert.ToInt32(result);
        }
    }
}
