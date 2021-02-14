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

            runnerRegistration.runnerBindingSource.AddNew();

        }

        private void runnerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.runnerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void RegisterAsRunnerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Runner". При необходимости она может быть перемещена или удалена.
            this.runnerTableAdapter.Fill(this.dataSet1.Runner);

        }
    }
}
