﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Kho : Form
    {
        public frm_Kho()
        {
            InitializeComponent();
        }

        private void frm_caidat_Load(object sender, EventArgs e)
        {

        }

        private void btn_them_kho_Click(object sender, EventArgs e)
        {
            frm_themtraicay themtraicay = new frm_themtraicay();
            themtraicay.Show();
        }
    }
}
