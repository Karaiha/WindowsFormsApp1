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
    public partial class FormInteractiveMap : FormPattern
    {
        public FormInteractiveMap()
        {
            InitializeComponent();
        }

        private void pictureBoxPoint1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
        }

        private void pictureBoxPoint2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
        }

        private void pictureBoxPoint3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage3"];
        }

        private void pictureBoxPoint4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage4"];
        }

        private void pictureBoxPoint5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage5"];
        }

        private void pictureBoxPoint6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage6"];
        }

        private void pictureBoxPoint7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage7"];
        }

        private void pictureBoxPoint8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage8"];
        }

        private void FormInteractiveMap_FormClosing(object sender, FormClosingEventArgs e)
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
