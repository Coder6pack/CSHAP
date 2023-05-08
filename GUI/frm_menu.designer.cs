
namespace GUI
{
    partial class frm_menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thanhtoan = new Guna.UI.WinForms.GunaButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_xoamon = new Guna.UI.WinForms.GunaButton();
            this.btn_themmon = new Guna.UI.WinForms.GunaButton();
            this.numer_soluong_menu = new System.Windows.Forms.NumericUpDown();
            this.list_giohang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptb_menu = new System.Windows.Forms.PictureBox();
            this.txt_tenkhachhang_menu = new System.Windows.Forms.TextBox();
            this.txt_manhanvien_menu = new System.Windows.Forms.TextBox();
            this.txt_dongia_menu = new System.Windows.Forms.TextBox();
            this.txt_TC_menu = new System.Windows.Forms.TextBox();
            this.txt_tennhanvien_menu = new System.Windows.Forms.TextBox();
            this.txt_sdt_menu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date_menu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_menu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numer_soluong_menu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btn_thanhtoan);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(609, 582);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 137);
            this.panel1.TabIndex = 4;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.AnimationHoverSpeed = 0.07F;
            this.btn_thanhtoan.AnimationSpeed = 0.03F;
            this.btn_thanhtoan.BackColor = System.Drawing.Color.Transparent;
            this.btn_thanhtoan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(0)))));
            this.btn_thanhtoan.BorderColor = System.Drawing.Color.Black;
            this.btn_thanhtoan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_thanhtoan.FocusedColor = System.Drawing.Color.Empty;
            this.btn_thanhtoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_thanhtoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_thanhtoan.Image = null;
            this.btn_thanhtoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_thanhtoan.ImageSize = new System.Drawing.Size(70, 70);
            this.btn_thanhtoan.Location = new System.Drawing.Point(501, 3);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_thanhtoan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_thanhtoan.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_thanhtoan.OnHoverImage = null;
            this.btn_thanhtoan.OnPressedColor = System.Drawing.Color.Black;
            this.btn_thanhtoan.Radius = 20;
            this.btn_thanhtoan.Size = new System.Drawing.Size(93, 57);
            this.btn_thanhtoan.TabIndex = 11;
            this.btn_thanhtoan.Text = "Thanh Toán";
            this.btn_thanhtoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(402, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "0,0 đ";
            // 
            // btn_xoamon
            // 
            this.btn_xoamon.AnimationHoverSpeed = 0.07F;
            this.btn_xoamon.AnimationSpeed = 0.03F;
            this.btn_xoamon.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoamon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(0)))));
            this.btn_xoamon.BorderColor = System.Drawing.Color.Black;
            this.btn_xoamon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xoamon.FocusedColor = System.Drawing.Color.Empty;
            this.btn_xoamon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoamon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_xoamon.Image = null;
            this.btn_xoamon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xoamon.ImageSize = new System.Drawing.Size(70, 70);
            this.btn_xoamon.Location = new System.Drawing.Point(280, 171);
            this.btn_xoamon.Name = "btn_xoamon";
            this.btn_xoamon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_xoamon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xoamon.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xoamon.OnHoverImage = null;
            this.btn_xoamon.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xoamon.Radius = 20;
            this.btn_xoamon.Size = new System.Drawing.Size(80, 50);
            this.btn_xoamon.TabIndex = 9;
            this.btn_xoamon.Text = "Xóa";
            this.btn_xoamon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_themmon
            // 
            this.btn_themmon.AnimationHoverSpeed = 0.07F;
            this.btn_themmon.AnimationSpeed = 0.03F;
            this.btn_themmon.BackColor = System.Drawing.Color.Transparent;
            this.btn_themmon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(0)))));
            this.btn_themmon.BorderColor = System.Drawing.Color.Black;
            this.btn_themmon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_themmon.FocusedColor = System.Drawing.Color.Empty;
            this.btn_themmon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_themmon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_themmon.Image = null;
            this.btn_themmon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_themmon.ImageSize = new System.Drawing.Size(70, 70);
            this.btn_themmon.Location = new System.Drawing.Point(182, 171);
            this.btn_themmon.Name = "btn_themmon";
            this.btn_themmon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_themmon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_themmon.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_themmon.OnHoverImage = null;
            this.btn_themmon.OnPressedColor = System.Drawing.Color.Black;
            this.btn_themmon.Radius = 20;
            this.btn_themmon.Size = new System.Drawing.Size(79, 50);
            this.btn_themmon.TabIndex = 8;
            this.btn_themmon.Text = "Thêm món";
            this.btn_themmon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numer_soluong_menu
            // 
            this.numer_soluong_menu.Location = new System.Drawing.Point(110, 189);
            this.numer_soluong_menu.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numer_soluong_menu.Name = "numer_soluong_menu";
            this.numer_soluong_menu.Size = new System.Drawing.Size(43, 20);
            this.numer_soluong_menu.TabIndex = 3;
            this.numer_soluong_menu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // list_giohang
            // 
            this.list_giohang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.list_giohang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.list_giohang.FullRowSelect = true;
            this.list_giohang.GridLines = true;
            this.list_giohang.HideSelection = false;
            this.list_giohang.Location = new System.Drawing.Point(5, 241);
            this.list_giohang.Name = "list_giohang";
            this.list_giohang.Size = new System.Drawing.Size(564, 329);
            this.list_giohang.TabIndex = 5;
            this.list_giohang.UseCompatibleStateImageBehavior = false;
            this.list_giohang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Tên trái cây";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 0;
            this.columnHeader4.Text = "STT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ptb_menu);
            this.panel2.Controls.Add(this.txt_tenkhachhang_menu);
            this.panel2.Controls.Add(this.txt_manhanvien_menu);
            this.panel2.Controls.Add(this.txt_dongia_menu);
            this.panel2.Controls.Add(this.txt_TC_menu);
            this.panel2.Controls.Add(this.txt_tennhanvien_menu);
            this.panel2.Controls.Add(this.txt_sdt_menu);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.date_menu);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_xoamon);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_themmon);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numer_soluong_menu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.list_giohang);
            this.panel2.Location = new System.Drawing.Point(644, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 573);
            this.panel2.TabIndex = 6;
            // 
            // ptb_menu
            // 
            this.ptb_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_menu.Location = new System.Drawing.Point(432, 94);
            this.ptb_menu.Name = "ptb_menu";
            this.ptb_menu.Size = new System.Drawing.Size(127, 127);
            this.ptb_menu.TabIndex = 21;
            this.ptb_menu.TabStop = false;
            // 
            // txt_tenkhachhang_menu
            // 
            this.txt_tenkhachhang_menu.Location = new System.Drawing.Point(383, 9);
            this.txt_tenkhachhang_menu.Name = "txt_tenkhachhang_menu";
            this.txt_tenkhachhang_menu.Size = new System.Drawing.Size(186, 20);
            this.txt_tenkhachhang_menu.TabIndex = 20;
            // 
            // txt_manhanvien_menu
            // 
            this.txt_manhanvien_menu.Location = new System.Drawing.Point(383, 35);
            this.txt_manhanvien_menu.Name = "txt_manhanvien_menu";
            this.txt_manhanvien_menu.Size = new System.Drawing.Size(186, 20);
            this.txt_manhanvien_menu.TabIndex = 19;
            // 
            // txt_dongia_menu
            // 
            this.txt_dongia_menu.Location = new System.Drawing.Point(383, 61);
            this.txt_dongia_menu.Name = "txt_dongia_menu";
            this.txt_dongia_menu.Size = new System.Drawing.Size(186, 20);
            this.txt_dongia_menu.TabIndex = 18;
            // 
            // txt_TC_menu
            // 
            this.txt_TC_menu.Location = new System.Drawing.Point(110, 127);
            this.txt_TC_menu.Name = "txt_TC_menu";
            this.txt_TC_menu.Size = new System.Drawing.Size(163, 20);
            this.txt_TC_menu.TabIndex = 17;
            // 
            // txt_tennhanvien_menu
            // 
            this.txt_tennhanvien_menu.Location = new System.Drawing.Point(110, 38);
            this.txt_tennhanvien_menu.Name = "txt_tennhanvien_menu";
            this.txt_tennhanvien_menu.Size = new System.Drawing.Size(163, 20);
            this.txt_tennhanvien_menu.TabIndex = 16;
            // 
            // txt_sdt_menu
            // 
            this.txt_sdt_menu.Location = new System.Drawing.Point(110, 9);
            this.txt_sdt_menu.Name = "txt_sdt_menu";
            this.txt_sdt_menu.Size = new System.Drawing.Size(163, 20);
            this.txt_sdt_menu.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(328, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Đơn giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(49, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(295, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã nhân viên:";
            // 
            // date_menu
            // 
            this.date_menu.Location = new System.Drawing.Point(110, 67);
            this.date_menu.Name = "date_menu";
            this.date_menu.Size = new System.Drawing.Size(163, 20);
            this.date_menu.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(279, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(49, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(55, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số điện thoại:";
            // 
            // grid_menu
            // 
            this.grid_menu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.grid_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.grid_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.grid_menu.Location = new System.Drawing.Point(0, 0);
            this.grid_menu.Name = "grid_menu";
            this.grid_menu.Size = new System.Drawing.Size(643, 719);
            this.grid_menu.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Trái Cây";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Trái Cây";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hạn Sử Dụng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Trạng Thái";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Hình";
            this.Column6.Name = "Column6";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giảm giá";
            this.columnHeader5.Width = 100;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1217, 719);
            this.Controls.Add(this.grid_menu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numer_soluong_menu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numer_soluong_menu;
        private Guna.UI.WinForms.GunaButton btn_thanhtoan;
        private Guna.UI.WinForms.GunaButton btn_xoamon;
        private Guna.UI.WinForms.GunaButton btn_themmon;
        private System.Windows.Forms.ListView list_giohang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptb_menu;
        private System.Windows.Forms.TextBox txt_tenkhachhang_menu;
        private System.Windows.Forms.TextBox txt_manhanvien_menu;
        private System.Windows.Forms.TextBox txt_dongia_menu;
        private System.Windows.Forms.TextBox txt_TC_menu;
        private System.Windows.Forms.TextBox txt_tennhanvien_menu;
        private System.Windows.Forms.TextBox txt_sdt_menu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_menu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_menu;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}