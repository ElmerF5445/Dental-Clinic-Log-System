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
    public partial class SearchPatient : Form
    {
        public SearchPatient()
        {
            InitializeComponent();
        }

        private void Button_Entry_Delete_Click(object sender, EventArgs e)
        {
            var Window = new SearchPatient_Delete_Confirmation();
            Window.ShowDialog();
        }

        private void Button_Entry_Load_Click(object sender, EventArgs e)
        {
            var Window = new ViewPatientProfile();
            Window.ShowDialog();
        }
    }
}
