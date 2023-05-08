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
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            btn_quanlykho.Visible = true;
        }

        private void frm_NhanVien_Click(object sender, EventArgs e)
        {

        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void lb_title_Click(object sender, EventArgs e)
        {

        }

        private void btn_quanly_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_quanlytaikhoan());
        }

        private void btn_menu_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_menu());
        }

        private void btn_lichsuhoadon_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_lichsuhoadon());
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_quanly_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Kho());
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_quanlytaikhoan());
        }
    }
}
