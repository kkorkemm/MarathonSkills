﻿using System;
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
    public partial class RunnerRegistForm : Form
    {
        public RunnerRegistForm()
        {
            InitializeComponent();
        }

        private void runnerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            runnerBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void RunnerRegistForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Runner". При необходимости она может быть перемещена или удалена.
        }

        private void registBtn_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (passwordTextBox.Text != passwordVerText.Text)
            {
                isValid = false;
                MessageBox.Show("Пароли не совпадают");
            }

            if (isValid)
            {
                runnerBindingSource.EndEdit();
                runnerTableAdapter.Update(dataSet1);


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void PhotoShowBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.png; *.jpeg; *.jpg) | *.png; *.jpeg; *.jpg | AllFiles(*.*) | *.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Photo.Image = new Bitmap(fileDialog.FileName);
                PhotoText.Text = fileDialog.SafeFileName;
            }
        }
    }
}
