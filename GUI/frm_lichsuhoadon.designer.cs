
namespace GUI
{
    partial class frm_lichsuhoadon
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
            this.btn_timkiem_hoadon = new Guna.UI.WinForms.GunaButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_timkiem_hoadon);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 558);
            this.panel1.TabIndex = 1;
            // 
            // btn_timkiem_hoadon
            // 
            this.btn_timkiem_hoadon.AnimationHoverSpeed = 0.07F;
            this.btn_timkiem_hoadon.AnimationSpeed = 0.03F;
            this.btn_timkiem_hoadon.BackColor = System.Drawing.Color.Transparent;
            this.btn_timkiem_hoadon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(0)))));
            this.btn_timkiem_hoadon.BorderColor = System.Drawing.Color.Black;
            this.btn_timkiem_hoadon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_timkiem_hoadon.FocusedColor = System.Drawing.Color.Empty;
            this.btn_timkiem_hoadon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_timkiem_hoadon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_timkiem_hoadon.Image = global::GUI.Properties.Resources.timkiem;
            this.btn_timkiem_hoadon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_timkiem_hoadon.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_timkiem_hoadon.Location = new System.Drawing.Point(350, 3);
            this.btn_timkiem_hoadon.Name = "btn_timkiem_hoadon";
            this.btn_timkiem_hoadon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_timkiem_hoadon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_timkiem_hoadon.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_timkiem_hoadon.OnHoverImage = null;
            this.btn_timkiem_hoadon.OnPressedColor = System.Drawing.Color.Black;
            this.btn_timkiem_hoadon.Radius = 10;
            this.btn_timkiem_hoadon.Size = new System.Drawing.Size(53, 32);
            this.btn_timkiem_hoadon.TabIndex = 7;
            this.btn_timkiem_hoadon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(957, 518);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Hóa Đơn";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Khách Hàng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 207;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời Gian";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 234;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng Giá";
            this.columnHeader4.Width = 354;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã Nhân Viên";
            this.columnHeader5.Width = 129;
            // 
            // frm_lichsuhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 558);
            this.Controls.Add(this.panel1);
            this.Name = "frm_lichsuhoadon";
            this.Text = "Lịch Sử Hóa Đơn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private Guna.UI.WinForms.GunaButton btn_timkiem_hoadon;
    }
}