
namespace GUI
{
    partial class frm_NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_quanlytaikhoan = new Guna.UI.WinForms.GunaButton();
            this.btn_caidat = new Guna.UI.WinForms.GunaButton();
            this.btn_thoat = new Guna.UI.WinForms.GunaButton();
            this.btn_quanlykho = new Guna.UI.WinForms.GunaButton();
            this.btn_lichsuhoadon = new Guna.UI.WinForms.GunaButton();
            this.btn_menu = new Guna.UI.WinForms.GunaButton();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.panel_body.Location = new System.Drawing.Point(127, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1220, 721);
            this.panel_body.TabIndex = 1;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.panel_menu.Controls.Add(this.pictureBox1);
            this.panel_menu.Controls.Add(this.btn_quanlytaikhoan);
            this.panel_menu.Controls.Add(this.btn_caidat);
            this.panel_menu.Controls.Add(this.btn_thoat);
            this.panel_menu.Controls.Add(this.btn_quanlykho);
            this.panel_menu.Controls.Add(this.btn_lichsuhoadon);
            this.panel_menu.Controls.Add(this.btn_menu);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(129, 721);
            this.panel_menu.TabIndex = 2;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logoFruit_removebg;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_quanlytaikhoan
            // 
            this.btn_quanlytaikhoan.AnimationHoverSpeed = 0.07F;
            this.btn_quanlytaikhoan.AnimationSpeed = 0.03F;
            this.btn_quanlytaikhoan.BackColor = System.Drawing.Color.Transparent;
            this.btn_quanlytaikhoan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(0)))));
            this.btn_quanlytaikhoan.BorderColor = System.Drawing.Color.Black;
            this.btn_quanlytaikhoan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_quanlytaikhoan.FocusedColor = System.Drawing.Color.Empty;
            this.btn_quanlytaikhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_quanlytaikhoan.ForeColor = System.Drawing.Color.White;
            this.btn_quanlytaikhoan.Image = global::GUI.Properties.Resources.quanlytaikhoan;
            this.btn_quanlytaikhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_quanlytaikhoan.ImageSize = new System.Drawing.Size(70, 70);
            this.btn_quanlytaikhoan.Location = new System.Drawing.Point(12, 512);
            this.btn_quanlytaikhoan.Name = "btn_quanlytaikhoan";
            this.btn_quanlytaikhoan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_quanlytaikhoan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_quanlytaikhoan.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_quanlytaikhoan.OnHoverImage = null;
            this.btn_quanlytaikhoan.OnPressedColor = System.Drawing.Color.Black;
            this.btn_quanlytaikhoan.Radius = 20;
            this.btn_quanlytaikhoan.Size = new System.Drawing.Size(99, 78);
            this.btn_quanlytaikhoan.TabIndex = 4;
            this.btn_quanlytaikhoan.Click += new System.EventHandler(this.gunaButton1_Click_1);
            // 
            // btn_caidat
            // 
            this.btn_caidat.AnimationHoverSpeed = 0.07F;
            this.btn_caidat.AnimationSpeed = 0.03F;
            this.btn_caidat.BackColor = System.Drawing.Color.Transparent;
            this.btn_caidat.BaseColor = System.Drawing.Color.Yellow;
            this.btn_caidat.BorderColor = System.Drawing.Color.Black;
            this.btn_caidat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_caidat.FocusedColor = System.Drawing.Color.Empty;
            this.btn_caidat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_caidat.ForeColor = System.Drawing.Color.Black;
            this.btn_caidat.Image = global::GUI.Properties.Resources.nhanvien;
            this.btn_caidat.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_caidat.Location = new System.Drawing.Point(-16, 131);
            this.btn_caidat.Name = "btn_caidat";
            this.btn_caidat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btn_caidat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_caidat.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_caidat.OnHoverImage = null;
            this.btn_caidat.OnPressedColor = System.Drawing.Color.Black;
            this.btn_caidat.Radius = 20;
            this.btn_caidat.Size = new System.Drawing.Size(142, 42);
            this.btn_caidat.TabIndex = 3;
            this.btn_caidat.Text = "Tên nhân viên";
            this.btn_caidat.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.AnimationHoverSpeed = 0.07F;
            this.btn_thoat.AnimationSpeed = 0.03F;
            this.btn_thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_thoat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(0)))));
            this.btn_thoat.BorderColor = System.Drawing.Color.Black;
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_thoat.FocusedColor = System.Drawing.Color.Empty;
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Image = global::GUI.Properties.Resources.dangxuat;
            this.btn_thoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_thoat.ImageSize = new System.Drawing.Size(100, 60);
            this.btn_thoat.Location = new System.Drawing.Point(12, 613);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_thoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_thoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_thoat.OnHoverImage = null;
            this.btn_thoat.OnPressedColor = System.Drawing.Color.Black;
            this.btn_thoat.Radius = 20;
            this.btn_thoat.Size = new System.Drawing.Size(99, 78);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click_1);
            // 
            // btn_quanlykho
            // 
            this.btn_quanlykho.AnimationHoverSpeed = 0.07F;
            this.btn_quanlykho.AnimationSpeed = 0.03F;
            this.btn_quanlykho.BackColor = System.Drawing.Color.Transparent;
            this.btn_quanlykho.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(0)))));
            this.btn_quanlykho.BorderColor = System.Drawing.Color.Black;
            this.btn_quanlykho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_quanlykho.FocusedColor = System.Drawing.Color.Empty;
            this.btn_quanlykho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_quanlykho.ForeColor = System.Drawing.Color.White;
            this.btn_quanlykho.Image = global::GUI.Properties.Resources.quanly;
            this.btn_quanlykho.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_quanlykho.ImageSize = new System.Drawing.Size(70, 70);
            this.btn_quanlykho.Location = new System.Drawing.Point(12, 415);
            this.btn_quanlykho.Name = "btn_quanlykho";
            this.btn_quanlykho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_quanlykho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_quanlykho.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_quanlykho.OnHoverImage = null;
            this.btn_quanlykho.OnPressedColor = System.Drawing.Color.Black;
            this.btn_quanlykho.Radius = 20;
            this.btn_quanlykho.Size = new System.Drawing.Size(99, 78);
            this.btn_quanlykho.TabIndex = 1;
            this.btn_quanlykho.Click += new System.EventHandler(this.btn_quanly_Click_1);
            // 
            // btn_lichsuhoadon
            // 
            this.btn_lichsuhoadon.AnimationHoverSpeed = 0.07F;
            this.btn_lichsuhoadon.AnimationSpeed = 0.03F;
            this.btn_lichsuhoadon.BackColor = System.Drawing.Color.Transparent;
            this.btn_lichsuhoadon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(0)))));
            this.btn_lichsuhoadon.BorderColor = System.Drawing.Color.Black;
            this.btn_lichsuhoadon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_lichsuhoadon.FocusedColor = System.Drawing.Color.Empty;
            this.btn_lichsuhoadon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_lichsuhoadon.ForeColor = System.Drawing.Color.White;
            this.btn_lichsuhoadon.Image = global::GUI.Properties.Resources.hoadon;
            this.btn_lichsuhoadon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_lichsuhoadon.ImageSize = new System.Drawing.Size(100, 50);
            this.btn_lichsuhoadon.Location = new System.Drawing.Point(12, 315);
            this.btn_lichsuhoadon.Name = "btn_lichsuhoadon";
            this.btn_lichsuhoadon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_lichsuhoadon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_lichsuhoadon.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_lichsuhoadon.OnHoverImage = null;
            this.btn_lichsuhoadon.OnPressedColor = System.Drawing.Color.Black;
            this.btn_lichsuhoadon.Radius = 20;
            this.btn_lichsuhoadon.Size = new System.Drawing.Size(99, 78);
            this.btn_lichsuhoadon.TabIndex = 1;
            this.btn_lichsuhoadon.Click += new System.EventHandler(this.btn_lichsuhoadon_Click_1);
            // 
            // btn_menu
            // 
            this.btn_menu.AnimationHoverSpeed = 0.07F;
            this.btn_menu.AnimationSpeed = 0.03F;
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(0)))));
            this.btn_menu.BorderColor = System.Drawing.Color.Black;
            this.btn_menu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_menu.FocusedColor = System.Drawing.Color.Empty;
            this.btn_menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Image = global::GUI.Properties.Resources.banhang;
            this.btn_menu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_menu.ImageSize = new System.Drawing.Size(100, 70);
            this.btn_menu.Location = new System.Drawing.Point(12, 204);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_menu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_menu.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_menu.OnHoverImage = null;
            this.btn_menu.OnPressedColor = System.Drawing.Color.Black;
            this.btn_menu.Radius = 20;
            this.btn_menu.Size = new System.Drawing.Size(99, 78);
            this.btn_menu.TabIndex = 0;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click_1);
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            this.Click += new System.EventHandler(this.frm_NhanVien_Click);
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel_menu;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton btn_menu;
        private Guna.UI.WinForms.GunaButton btn_lichsuhoadon;
        private Guna.UI.WinForms.GunaButton btn_thoat;
        private Guna.UI.WinForms.GunaButton btn_quanlykho;
        private Guna.UI.WinForms.GunaButton btn_caidat;
        private Guna.UI.WinForms.GunaButton btn_quanlytaikhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}