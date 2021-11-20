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
    public partial class BMICalcForm : FormPattern
    {
        int height;
        int weight;
        float index;
        int sex = 0;
        public BMICalcForm()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (sex != 0)
            {
                textBoxHeight.Text = Int32.Parse(textBoxHeight.Text) < 50 ? "50" : textBoxHeight.Text;
                textBoxWeight.Text = Int32.Parse(textBoxWeight.Text) < 5 ? "5" : textBoxWeight.Text;
                height = Int32.Parse(textBoxHeight.Text);
                weight = Int32.Parse(textBoxWeight.Text);

                index = weight / ((height / 100) ^ 2);
                labelBMIresultNum.Text = "" + index;
                trackBarIndex.Value = (int) (index > 50 ? 50 : index);
                if ((index >= 0) && (index < 18.5)) 
                { 
                    labelBMIresultText.Text = "Недостаточный";
                    pictureBoxResult.Image = Properties.Resources.small as Image;
                } else if ((index >= 18.5) && (index < 25))
                {
                    labelBMIresultText.Text = "Здоровый";
                    pictureBoxResult.Image = Properties.Resources.normal as Image;
                }
                else if ((index >= 25) && (index < 30))
                {
                    labelBMIresultText.Text = "Избыточный";
                    pictureBoxResult.Image = Properties.Resources.fat as Image;
                }
                else if (index >= 30)
                {
                    labelBMIresultText.Text = "Ожирение";
                    pictureBoxResult.Image = Properties.Resources.fattest as Image;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sex = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sex = 2;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void BMICalcForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
