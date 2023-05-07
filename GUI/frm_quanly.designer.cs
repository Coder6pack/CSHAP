
namespace GUI
{
    partial class frm_quanly
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.kho = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_timkiem = new Guna.UI.WinForms.GunaButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_xoa_kho = new Guna.UI.WinForms.GunaButton();
            this.btn_sua_kho = new Guna.UI.WinForms.GunaButton();
            this.btn_them_kho = new Guna.UI.WinForms.GunaButton();
            this.grid_kho = new System.Windows.Forms.DataGridView();
            this.nhanvien = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_xoa_nhanvien = new Guna.UI.WinForms.GunaButton();
            this.btn_sua_nhanvien = new Guna.UI.WinForms.GunaButton();
            this.btn_them_nhanvien = new Guna.UI.WinForms.GunaButton();
            this.grid_nhanvien = new System.Windows.Forms.DataGridView();
            this.thongke = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.kho.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_kho)).BeginInit();
            this.nhanvien.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_nhanvien)).BeginInit();
            this.thongke.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 561);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.kho);
            this.tabControl1.Controls.Add(this.nhanvien);
            this.tabControl1.Controls.Add(this.thongke);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 555);
            this.tabControl1.TabIndex = 0;
            // 
            // kho
            // 
            this.kho.Controls.Add(this.panel4);
            this.kho.Controls.Add(this.panel3);
            this.kho.Controls.Add(this.panel2);
            this.kho.Controls.Add(this.grid_kho);
            this.kho.Location = new System.Drawing.Point(4, 22);
            this.kho.Name = "kho";
            this.kho.Padding = new System.Windows.Forms.Padding(3);
            this.kho.Size = new System.Drawing.Size(949, 529);
            this.kho.TabIndex = 0;
            this.kho.Text = "Kho";
            this.kho.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(465, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 453);
            this.panel4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh mục:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.btn_timkiem);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(465, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 66);
            this.panel3.TabIndex = 5;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.AnimationHoverSpeed = 0.07F;
            this.btn_timkiem.AnimationSpeed = 0.03F;
            this.btn_timkiem.BackColor = System.Drawing.Color.Transparent;
            this.btn_timkiem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btn_timkiem.BorderColor = System.Drawing.Color.Black;
            this.btn_timkiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_timkiem.FocusedColor = System.Drawing.Color.Empty;
            this.btn_timkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_timkiem.Image = global::GUI.Properties.Resources.timkiem;
            this.btn_timkiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_timkiem.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_timkiem.Location = new System.Drawing.Point(314, 6);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_timkiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_timkiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_timkiem.OnHoverImage = null;
            this.btn_timkiem.OnPressedColor = System.Drawing.Color.Black;
            this.btn_timkiem.Radius = 20;
            this.btn_timkiem.Size = new System.Drawing.Size(61, 60);
            this.btn_timkiem.TabIndex = 5;
            this.btn_timkiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btn_xoa_kho);
            this.panel2.Controls.Add(this.btn_sua_kho);
            this.panel2.Controls.Add(this.btn_them_kho);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 66);
            this.panel2.TabIndex = 4;
            // 
            // btn_xoa_kho
            // 
            this.btn_xoa_kho.AnimationHoverSpeed = 0.07F;
            this.btn_xoa_kho.AnimationSpeed = 0.03F;
            this.btn_xoa_kho.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoa_kho.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btn_xoa_kho.BorderColor = System.Drawing.Color.Black;
            this.btn_xoa_kho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xoa_kho.FocusedColor = System.Drawing.Color.Empty;
            this.btn_xoa_kho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoa_kho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_xoa_kho.Image = global::GUI.Properties.Resources.xoa;
            this.btn_xoa_kho.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xoa_kho.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_xoa_kho.Location = new System.Drawing.Point(352, 3);
            this.btn_xoa_kho.Name = "btn_xoa_kho";
            this.btn_xoa_kho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_xoa_kho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xoa_kho.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xoa_kho.OnHoverImage = null;
            this.btn_xoa_kho.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xoa_kho.Radius = 20;
            this.btn_xoa_kho.Size = new System.Drawing.Size(75, 60);
            this.btn_xoa_kho.TabIndex = 7;
            this.btn_xoa_kho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_sua_kho
            // 
            this.btn_sua_kho.AnimationHoverSpeed = 0.07F;
            this.btn_sua_kho.AnimationSpeed = 0.03F;
            this.btn_sua_kho.BackColor = System.Drawing.Color.Transparent;
            this.btn_sua_kho.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btn_sua_kho.BorderColor = System.Drawing.Color.Black;
            this.btn_sua_kho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_sua_kho.FocusedColor = System.Drawing.Color.Empty;
            this.btn_sua_kho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sua_kho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_sua_kho.Image = global::GUI.Properties.Resources.sua;
            this.btn_sua_kho.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_sua_kho.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_sua_kho.Location = new System.Drawing.Point(180, 5);
            this.btn_sua_kho.Name = "btn_sua_kho";
            this.btn_sua_kho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_sua_kho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_sua_kho.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_sua_kho.OnHoverImage = null;
            this.btn_sua_kho.OnPressedColor = System.Drawing.Color.Black;
            this.btn_sua_kho.Radius = 20;
            this.btn_sua_kho.Size = new System.Drawing.Size(81, 59);
            this.btn_sua_kho.TabIndex = 6;
            this.btn_sua_kho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_them_kho
            // 
            this.btn_them_kho.AnimationHoverSpeed = 0.07F;
            this.btn_them_kho.AnimationSpeed = 0.03F;
            this.btn_them_kho.BackColor = System.Drawing.Color.Transparent;
            this.btn_them_kho.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btn_them_kho.BorderColor = System.Drawing.Color.Black;
            this.btn_them_kho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_them_kho.FocusedColor = System.Drawing.Color.Empty;
            this.btn_them_kho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_them_kho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_them_kho.Image = global::GUI.Properties.Resources.them;
            this.btn_them_kho.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_them_kho.ImageSize = new System.Drawing.Size(70, 70);
            this.btn_them_kho.Location = new System.Drawing.Point(22, 4);
            this.btn_them_kho.Name = "btn_them_kho";
            this.btn_them_kho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_them_kho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_them_kho.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_them_kho.OnHoverImage = null;
            this.btn_them_kho.OnPressedColor = System.Drawing.Color.Black;
            this.btn_them_kho.Radius = 20;
            this.btn_them_kho.Size = new System.Drawing.Size(84, 59);
            this.btn_them_kho.TabIndex = 5;
            this.btn_them_kho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grid_kho
            // 
            this.grid_kho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.grid_kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_kho.Location = new System.Drawing.Point(3, 73);
            this.grid_kho.Name = "grid_kho";
            this.grid_kho.Size = new System.Drawing.Size(459, 453);
            this.grid_kho.TabIndex = 0;
            // 
            // nhanvien
            // 
            this.nhanvien.Controls.Add(this.panel5);
            this.nhanvien.Controls.Add(this.panel6);
            this.nhanvien.Controls.Add(this.panel7);
            this.nhanvien.Controls.Add(this.grid_nhanvien);
            this.nhanvien.Location = new System.Drawing.Point(4, 22);
            this.nhanvien.Name = "nhanvien";
            this.nhanvien.Padding = new System.Windows.Forms.Padding(3);
            this.nhanvien.Size = new System.Drawing.Size(949, 529);
            this.nhanvien.TabIndex = 2;
            this.nhanvien.Text = "Nhân Viên";
            this.nhanvien.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(477, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(473, 458);
            this.panel5.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại tài khoản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Họ tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên tài khoản:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.panel6.Controls.Add(this.gunaButton3);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Location = new System.Drawing.Point(477, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(469, 63);
            this.panel6.TabIndex = 9;
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.gunaButton3.Image = global::GUI.Properties.Resources.timkiem;
            this.gunaButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.ImageSize = new System.Drawing.Size(50, 50);
            this.gunaButton3.Location = new System.Drawing.Point(342, 3);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 20;
            this.gunaButton3.Size = new System.Drawing.Size(49, 57);
            this.gunaButton3.TabIndex = 7;
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.panel7.Controls.Add(this.btn_xoa_nhanvien);
            this.panel7.Controls.Add(this.btn_sua_nhanvien);
            this.panel7.Controls.Add(this.btn_them_nhanvien);
            this.panel7.Location = new System.Drawing.Point(3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(468, 63);
            this.panel7.TabIndex = 8;
            // 
            // btn_xoa_nhanvien
            // 
            this.btn_xoa_nhanvien.AnimationHoverSpeed = 0.07F;
            this.btn_xoa_nhanvien.AnimationSpeed = 0.03F;
            this.btn_xoa_nhanvien.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoa_nhanvien.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btn_xoa_nhanvien.BorderColor = System.Drawing.Color.Black;
            this.btn_xoa_nhanvien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xoa_nhanvien.FocusedColor = System.Drawing.Color.Empty;
            this.btn_xoa_nhanvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoa_nhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_xoa_nhanvien.Image = global::GUI.Properties.Resources.xoa;
            this.btn_xoa_nhanvien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xoa_nhanvien.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_xoa_nhanvien.Location = new System.Drawing.Point(343, 2);
            this.btn_xoa_nhanvien.Name = "btn_xoa_nhanvien";
            this.btn_xoa_nhanvien.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_xoa_nhanvien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xoa_nhanvien.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xoa_nhanvien.OnHoverImage = null;
            this.btn_xoa_nhanvien.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xoa_nhanvien.Radius = 20;
            this.btn_xoa_nhanvien.Size = new System.Drawing.Size(85, 57);
            this.btn_xoa_nhanvien.TabIndex = 6;
            this.btn_xoa_nhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_sua_nhanvien
            // 
            this.btn_sua_nhanvien.AnimationHoverSpeed = 0.07F;
            this.btn_sua_nhanvien.AnimationSpeed = 0.03F;
            this.btn_sua_nhanvien.BackColor = System.Drawing.Color.Transparent;
            this.btn_sua_nhanvien.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btn_sua_nhanvien.BorderColor = System.Drawing.Color.Black;
            this.btn_sua_nhanvien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_sua_nhanvien.FocusedColor = System.Drawing.Color.Empty;
            this.btn_sua_nhanvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sua_nhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_sua_nhanvien.Image = global::GUI.Properties.Resources.sua;
            this.btn_sua_nhanvien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_sua_nhanvien.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_sua_nhanvien.Location = new System.Drawing.Point(175, 3);
            this.btn_sua_nhanvien.Name = "btn_sua_nhanvien";
            this.btn_sua_nhanvien.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_sua_nhanvien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_sua_nhanvien.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_sua_nhanvien.OnHoverImage = null;
            this.btn_sua_nhanvien.OnPressedColor = System.Drawing.Color.Black;
            this.btn_sua_nhanvien.Radius = 20;
            this.btn_sua_nhanvien.Size = new System.Drawing.Size(91, 57);
            this.btn_sua_nhanvien.TabIndex = 5;
            this.btn_sua_nhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_them_nhanvien
            // 
            this.btn_them_nhanvien.AnimationHoverSpeed = 0.07F;
            this.btn_them_nhanvien.AnimationSpeed = 0.03F;
            this.btn_them_nhanvien.BackColor = System.Drawing.Color.Transparent;
            this.btn_them_nhanvien.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btn_them_nhanvien.BorderColor = System.Drawing.Color.Black;
            this.btn_them_nhanvien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_them_nhanvien.FocusedColor = System.Drawing.Color.Empty;
            this.btn_them_nhanvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_them_nhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_them_nhanvien.Image = global::GUI.Properties.Resources.them;
            this.btn_them_nhanvien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_them_nhanvien.ImageSize = new System.Drawing.Size(70, 70);
            this.btn_them_nhanvien.Location = new System.Drawing.Point(21, 3);
            this.btn_them_nhanvien.Name = "btn_them_nhanvien";
            this.btn_them_nhanvien.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_them_nhanvien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_them_nhanvien.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_them_nhanvien.OnHoverImage = null;
            this.btn_them_nhanvien.OnPressedColor = System.Drawing.Color.Black;
            this.btn_them_nhanvien.Radius = 20;
            this.btn_them_nhanvien.Size = new System.Drawing.Size(87, 57);
            this.btn_them_nhanvien.TabIndex = 4;
            this.btn_them_nhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grid_nhanvien
            // 
            this.grid_nhanvien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.grid_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_nhanvien.Location = new System.Drawing.Point(3, 71);
            this.grid_nhanvien.Name = "grid_nhanvien";
            this.grid_nhanvien.Size = new System.Drawing.Size(468, 458);
            this.grid_nhanvien.TabIndex = 7;
            // 
            // thongke
            // 
            this.thongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.thongke.Controls.Add(this.listView1);
            this.thongke.Location = new System.Drawing.Point(4, 22);
            this.thongke.Name = "thongke";
            this.thongke.Padding = new System.Windows.Forms.Padding(3);
            this.thongke.Size = new System.Drawing.Size(949, 529);
            this.thongke.TabIndex = 3;
            this.thongke.Text = "Thống Kê";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(943, 440);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frm_quanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(958, 558);
            this.Controls.Add(this.panel1);
            this.Name = "frm_quanly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.frm_quanly_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.kho.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_kho)).EndInit();
            this.nhanvien.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_nhanvien)).EndInit();
            this.thongke.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage kho;
        private System.Windows.Forms.DataGridView grid_kho;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage nhanvien;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView grid_nhanvien;
        private System.Windows.Forms.TabPage thongke;
        private System.Windows.Forms.ListView listView1;
        private Guna.UI.WinForms.GunaButton btn_timkiem;
        private Guna.UI.WinForms.GunaButton btn_xoa_kho;
        private Guna.UI.WinForms.GunaButton btn_sua_kho;
        private Guna.UI.WinForms.GunaButton btn_them_kho;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton btn_xoa_nhanvien;
        private Guna.UI.WinForms.GunaButton btn_sua_nhanvien;
        private Guna.UI.WinForms.GunaButton btn_them_nhanvien;
    }
}