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
    public partial class BMRCalcForm : FormPattern
    {
        int height;
        int weight;
        int age;
        int sex = 0;
        float bmr;
        public BMRCalcForm()
        {
            InitializeComponent();
        }

        private void pictureBoxMale_Click(object sender, EventArgs e)
        {
            sex = 1;
        }

        private void pictureBoxFemale_Click(object sender, EventArgs e)
        {
            sex = 2;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            height = Int32.Parse(textBoxHeight.Text);
            weight = Int32.Parse(textBoxWeight.Text);
            age = Int32.Parse(textBoxAge.Text);
            switch (sex) 
            {
                case 1:
                    bmr = (float) (66 + (13.7 * weight) + (5 * height) - (6.8 * age));
                    setBMR();
                    break;
                case 2:
                    bmr = (float) (65 + (9.6 * weight) + (1.8 * height) - (4.7 * age));
                    setBMR();
                    break;
            }
        }

        void setBMR() 
        {
            labelYourBMR.Text = "" + bmr;
            labelInactive.Text = "" + (bmr * 1.2);
            labelLowActivity.Text = "" + (bmr * 1.375);
            labelAverageActivity.Text = "" + (bmr * 1.55);
            labelHighActivity.Text = "" + (bmr * 1.725);
            labelMaximumActivity.Text = "" + (bmr * 1.9);
        }

        private void BMRCalcForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
