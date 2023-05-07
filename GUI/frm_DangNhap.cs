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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muon dùng chức năng quản lý thì tài khoản phải là quản lý . Này đang test nên ông cứ vào cái form nhân viên rồi sửa lại phần load là đc nha !!!", "Thông Báo");
            frm_NhanVien nhanvien = new frm_NhanVien();
            nhanvien.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
