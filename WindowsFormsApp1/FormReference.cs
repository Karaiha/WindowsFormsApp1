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
    public partial class FormReference : FormPattern
    {
        public FormReference()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FormReference_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
