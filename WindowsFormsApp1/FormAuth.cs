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
    public partial class FormAuth : FormPattern
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {

        }

        private void FormAuth_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
