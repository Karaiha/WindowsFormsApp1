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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            FormCalculations calcForm = new FormCalculations();

            calcForm.Owner = this;
            calcForm.Show();
            this.Hide();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            FormAuth authForm = new FormAuth();

            authForm.Owner = this;
            authForm.Show();
            this.Hide();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            FormRegistration regForm = new FormRegistration();

            regForm.Owner = this;
            regForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInfo infForm = new FormInfo();

            infForm.Owner = this;
            infForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Подтверждение закрытия", "Вы уверены, что хотите закрыть приложение?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Подтверждение закрытия?", "Вы уверены что хотите закрыть приложение?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formdlin speedForm = new Formdlin();

            speedForm.Owner = this;
            speedForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormInteractiveMap interactForm = new FormInteractiveMap();

            interactForm.Owner = this;
            interactForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BMICalcForm bmiForm = new BMICalcForm();

            bmiForm.Owner = this;
            bmiForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BMRCalcForm bmrForm = new BMRCalcForm();

            bmrForm.Owner = this;
            bmrForm.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Подтверждение закрытия?", "Вы уверены что хотите закрыть приложение?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuth authForm = new FormAuth();

            authForm.Owner = this;
            authForm.Show();
            this.Hide();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistration regForm = new FormRegistration();

            regForm.Owner = this;
            regForm.Show();
            this.Hide();
        }

        private void информацияОМарафонеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo infForm = new FormInfo();

            infForm.Owner = this;
            infForm.Show();
            this.Hide();
        }

        private void bMIКалькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BMICalcForm bmiForm = new BMICalcForm();

            bmiForm.Owner = this;
            bmiForm.Show();
            this.Hide();
        }

        private void вычисленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculations calcForm = new FormCalculations();

            calcForm.Owner = this;
            calcForm.Show();
            this.Hide();
        }

        private void насколькоДолгийМарафонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formdlin speedForm = new Formdlin();

            speedForm.Owner = this;
            speedForm.Show();
            this.Hide();
        }

        private void интерактивнаяКартаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInteractiveMap interactForm = new FormInteractiveMap();

            interactForm.Owner = this;
            interactForm.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void картаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInteractiveMap interactForm = new FormInteractiveMap();

            interactForm.Owner = this;
            interactForm.Show();
            this.Hide();
        }

        private void информацияОМарафонеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormInfo infForm = new FormInfo();

            infForm.Owner = this;
            infForm.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAbout aboutForm = new FormAbout();

            aboutForm.Owner = this;
            aboutForm.Show();
            this.Hide();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReference refForm = new FormReference();

            refForm.Owner = this;
            refForm.Show();
            this.Hide();
        }
    }
}
