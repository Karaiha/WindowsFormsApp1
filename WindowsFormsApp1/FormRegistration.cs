﻿using System;
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
    public partial class FormRegistration : FormPattern
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }

        private void FormRegistration_FormClosing(object sender, FormClosingEventArgs e)
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
