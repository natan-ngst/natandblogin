﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectDB
{
    public partial class Akun : Form
    {
        public Akun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR_akun1.SetParameterValue("akun_user", txtUsername.Text);
            crystalReportViewer1.ReportSource = CR_akun1;
            crystalReportViewer1.Refresh();
        }
    }
}
