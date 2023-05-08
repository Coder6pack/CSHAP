using System;
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
    public partial class frm_quanlytaikhoan : Form
    {
        public frm_quanlytaikhoan()
        {
            InitializeComponent();
        }

        private void frm_quanly_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_them_nhanvien_Click(object sender, EventArgs e)
        {
            frm_themmoinhanvien themnhanvien = new frm_themmoinhanvien();
            themnhanvien.Show();
        }
    }
}
