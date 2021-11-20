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
    public partial class Formdlin : FormPattern
    {
        public Formdlin()
        {
            InitializeComponent();
        }
        private void DescAndPic(Label lab, PictureBox picB, string desc)
        {
            labelTitlePic.Text = lab.Text;
            pictureBox1.Image = picB.Image;
            labelDesc.Text = desc;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DescAndPic(label7, pictureBox6, "");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Formdlin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void Formdlin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DescAndPic(label3, pictureBox2, "Максимальная скорость F1 Car - 345 km/h. Это займёт примерно 7 минут чтобы завершить 42km.");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DescAndPic(label4, pictureBox3, "");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DescAndPic(label5, pictureBox4, "");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DescAndPic(label6, pictureBox5, "");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DescAndPic(label8, pictureBox7, "");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DescAndPic(label9, pictureBox8, "");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DescAndPic(label10, pictureBox9, "");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            DescAndPic(label11, pictureBox10, "");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            DescAndPic(label12, pictureBox11, "");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            DescAndPic(label13, pictureBox12, "");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            DescAndPic(label14, pictureBox13, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
