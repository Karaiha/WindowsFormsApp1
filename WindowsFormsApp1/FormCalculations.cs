using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCalculations : FormPattern
    {
        BindingList<string> list = new BindingList<string>();
        public FormCalculations()
        {
            InitializeComponent();
            list.Add("Мужской");
            list.Add("женский");
            comboBoxTown.DataSource = list;
        }
        private void FormCalculations_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {
            labelDate.Text = dateTimePickerBirth.Value.ToString("MMM");
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            TimeSpan diap = DateTime.Now - dateTimePickerBirth.Value;
            int age = DateTime.Now.Year - dateTimePickerBirth.Value.Year;
            string sss = string.Format("{0} лет \n{1} дней \n{2} часов \n{3} минут", age.ToString(), diap.TotalDays.ToString("0."), diap.TotalHours.ToString("0."), diap.TotalMinutes.ToString("0."));

            MessageBox.Show(sss);
        }

        private void buttonOutCB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxTown.SelectedValue.ToString());
        }

        private void buttonAddCB_Click(object sender, EventArgs e)
        {
            list.Add(textBoxCB.Text);
            textBoxCB.Text = "";
        }

        private void buttonCleanCB_Click(object sender, EventArgs e)
        {
            list.Clear();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            if (!checkBoxReg.Checked)
            {
                MessageBox.Show("Вы не согласились с уловиями регистрации!");
            }
            else
            {
                MessageBox.Show("Спасибо за согласие!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void radioButtonMale_Click(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
            {
                pictureBoxSex.Image = Properties.Resources.MaleCrab as Image;
            }
            else
            {
                pictureBoxSex.Image = Properties.Resources.FemaleCrab as Image;
            }
        }

        private void radioButtonFemale_Click(object sender, EventArgs e)
        {
            if (radioButtonFemale.Checked)
            {
                pictureBoxSex.Image = Properties.Resources.FemaleCrab as Image;
            }
            else
            {
                pictureBoxSex.Image = Properties.Resources.MaleCrab as Image;
            }
        }

        private void FormCalculations_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
