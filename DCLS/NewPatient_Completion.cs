﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCLS
{
    public partial class NewPatient_Completion : Form
    {
        public NewPatient_Completion()
        {
            InitializeComponent();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_GoToLogCreation_Click(object sender, EventArgs e)
        {
            var Window = new NewLog();
            Window.Show();
        }
    }
}
