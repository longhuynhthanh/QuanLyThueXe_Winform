namespace Version1
{
    partial class Form1
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
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.txtSoGioThue = new System.Windows.Forms.TextBox();
            this.txtHoTenNguoiThue = new System.Windows.Forms.TextBox();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbXeThue = new System.Windows.Forms.GroupBox();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.lblBienSo = new System.Windows.Forms.Label();
            this.gbLoaiXe = new System.Windows.Forms.GroupBox();
            this.rdb250cc = new System.Windows.Forms.RadioButton();
            this.rdb100cc = new System.Windows.Forms.RadioButton();
            this.rdbXeMay = new System.Windows.Forms.RadioButton();
            this.rdbXeDap = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lsvXe = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSaoLuu = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTenTimKiem = new System.Windows.Forms.Label();
            this.txtTenTimKiem = new System.Windows.Forms.TextBox();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.gbThongTin.SuspendLayout();
            this.gbXeThue.SuspendLayout();
            this.gbLoaiXe.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.txtSoGioThue);
            this.gbThongTin.Controls.Add(this.txtHoTenNguoiThue);
            this.gbThongTin.Controls.Add(this.txtMaSo);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.label6);
            this.gbThongTin.Location = new System.Drawing.Point(12, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(977, 80);
            this.gbThongTin.TabIndex = 6;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin";
            // 
            // txtSoGioThue
            // 
            this.txtSoGioThue.Location = new System.Drawing.Point(767, 33);
            this.txtSoGioThue.Name = "txtSoGioThue";
            this.txtSoGioThue.Size = new System.Drawing.Size(100, 26);
            this.txtSoGioThue.TabIndex = 11;
            // 
            // txtHoTenNguoiThue
            // 
            this.txtHoTenNguoiThue.Location = new System.Drawing.Point(403, 33);
            this.txtHoTenNguoiThue.Name = "txtHoTenNguoiThue";
            this.txtHoTenNguoiThue.Size = new System.Drawing.Size(185, 26);
            this.txtHoTenNguoiThue.TabIndex = 10;
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(66, 37);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(100, 26);
            this.txtMaSo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Giờ Thuê";
            // 
            // gbXeThue
            // 
            this.gbXeThue.Controls.Add(this.txtBienSo);
            this.gbXeThue.Controls.Add(this.lblBienSo);
            this.gbXeThue.Controls.Add(this.gbLoaiXe);
            this.gbXeThue.Controls.Add(this.rdbXeMay);
            this.gbXeThue.Controls.Add(this.rdbXeDap);
            this.gbXeThue.Location = new System.Drawing.Point(12, 99);
            this.gbXeThue.Name = "gbXeThue";
            this.gbXeThue.Size = new System.Drawing.Size(977, 182);
            this.gbXeThue.TabIndex = 7;
            this.gbXeThue.TabStop = false;
            this.gbXeThue.Text = "Xe Thuê";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(474, 139);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(185, 26);
            this.txtBienSo.TabIndex = 11;
            this.txtBienSo.Visible = false;
            // 
            // lblBienSo
            // 
            this.lblBienSo.AutoSize = true;
            this.lblBienSo.Location = new System.Drawing.Point(399, 146);
            this.lblBienSo.Name = "lblBienSo";
            this.lblBienSo.Size = new System.Drawing.Size(61, 19);
            this.lblBienSo.TabIndex = 7;
            this.lblBienSo.Text = "Biển Số";
            this.lblBienSo.Visible = false;
            // 
            // gbLoaiXe
            // 
            this.gbLoaiXe.Controls.Add(this.rdb250cc);
            this.gbLoaiXe.Controls.Add(this.rdb100cc);
            this.gbLoaiXe.Location = new System.Drawing.Point(403, 54);
            this.gbLoaiXe.Name = "gbLoaiXe";
            this.gbLoaiXe.Size = new System.Drawing.Size(420, 74);
            this.gbLoaiXe.TabIndex = 2;
            this.gbLoaiXe.TabStop = false;
            this.gbLoaiXe.Text = "Loại Xe Máy";
            this.gbLoaiXe.Visible = false;
            // 
            // rdb250cc
            // 
            this.rdb250cc.AutoSize = true;
            this.rdb250cc.Location = new System.Drawing.Point(269, 25);
            this.rdb250cc.Name = "rdb250cc";
            this.rdb250cc.Size = new System.Drawing.Size(65, 23);
            this.rdb250cc.TabIndex = 3;
            this.rdb250cc.TabStop = true;
            this.rdb250cc.Text = "250cc";
            this.rdb250cc.UseVisualStyleBackColor = true;
            // 
            // rdb100cc
            // 
            this.rdb100cc.AutoSize = true;
            this.rdb100cc.Location = new System.Drawing.Point(71, 25);
            this.rdb100cc.Name = "rdb100cc";
            this.rdb100cc.Size = new System.Drawing.Size(65, 23);
            this.rdb100cc.TabIndex = 2;
            this.rdb100cc.TabStop = true;
            this.rdb100cc.Text = "100cc";
            this.rdb100cc.UseVisualStyleBackColor = true;
            // 
            // rdbXeMay
            // 
            this.rdbXeMay.AutoSize = true;
            this.rdbXeMay.Location = new System.Drawing.Point(403, 25);
            this.rdbXeMay.Name = "rdbXeMay";
            this.rdbXeMay.Size = new System.Drawing.Size(82, 23);
            this.rdbXeMay.TabIndex = 1;
            this.rdbXeMay.TabStop = true;
            this.rdbXeMay.Text = "Xe Máy";
            this.rdbXeMay.UseVisualStyleBackColor = true;
            this.rdbXeMay.CheckedChanged += new System.EventHandler(this.rdbXeMay_CheckedChanged);
            // 
            // rdbXeDap
            // 
            this.rdbXeDap.AutoSize = true;
            this.rdbXeDap.Location = new System.Drawing.Point(66, 25);
            this.rdbXeDap.Name = "rdbXeDap";
            this.rdbXeDap.Size = new System.Drawing.Size(78, 23);
            this.rdbXeDap.TabIndex = 0;
            this.rdbXeDap.TabStop = true;
            this.rdbXeDap.Text = "Xe Đạp";
            this.rdbXeDap.UseVisualStyleBackColor = true;
            this.rdbXeDap.CheckedChanged += new System.EventHandler(this.rdbXeDap_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Họ Tên Người Thuê";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã Số";
            // 
            // lsvXe
            // 
            this.lsvXe.FullRowSelect = true;
            this.lsvXe.GridLines = true;
            this.lsvXe.Location = new System.Drawing.Point(12, 393);
            this.lsvXe.Name = "lsvXe";
            this.lsvXe.Size = new System.Drawing.Size(977, 257);
            this.lsvXe.TabIndex = 8;
            this.lsvXe.UseCompatibleStateImageBehavior = false;
            this.lsvXe.View = System.Windows.Forms.View.Details;
            this.lsvXe.SelectedIndexChanged += new System.EventHandler(this.lsvXe_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnKhoiPhuc);
            this.groupBox4.Controls.Add(this.btnSaoLuu);
            this.groupBox4.Controls.Add(this.btnTimKiem);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Location = new System.Drawing.Point(12, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(977, 100);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Location = new System.Drawing.Point(661, 25);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Size = new System.Drawing.Size(100, 51);
            this.btnSaoLuu.TabIndex = 4;
            this.btnSaoLuu.Text = "Sao Lưu";
            this.btnSaoLuu.UseVisualStyleBackColor = true;
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(505, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 51);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(340, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 51);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(174, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 51);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(25, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 51);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTenTimKiem
            // 
            this.lblTenTimKiem.AutoSize = true;
            this.lblTenTimKiem.Location = new System.Drawing.Point(488, 238);
            this.lblTenTimKiem.Name = "lblTenTimKiem";
            this.lblTenTimKiem.Size = new System.Drawing.Size(129, 19);
            this.lblTenTimKiem.TabIndex = 10;
            this.lblTenTimKiem.Text = "Họ Tên Tìm Kiếm";
            this.lblTenTimKiem.Visible = false;
            // 
            // txtTenTimKiem
            // 
            this.txtTenTimKiem.Location = new System.Drawing.Point(649, 231);
            this.txtTenTimKiem.Name = "txtTenTimKiem";
            this.txtTenTimKiem.Size = new System.Drawing.Size(185, 26);
            this.txtTenTimKiem.TabIndex = 12;
            this.txtTenTimKiem.Visible = false;
            this.txtTenTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTenTimKiem_KeyUp);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Location = new System.Drawing.Point(818, 25);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(100, 51);
            this.btnKhoiPhuc.TabIndex = 5;
            this.btnKhoiPhuc.Text = "Khôi Phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 662);
            this.Controls.Add(this.txtTenTimKiem);
            this.Controls.Add(this.lblTenTimKiem);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lsvXe);
            this.Controls.Add(this.gbXeThue);
            this.Controls.Add(this.gbThongTin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Ứng Dụng Thuê Xe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbXeThue.ResumeLayout(false);
            this.gbXeThue.PerformLayout();
            this.gbLoaiXe.ResumeLayout(false);
            this.gbLoaiXe.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.TextBox txtSoGioThue;
        private System.Windows.Forms.TextBox txtHoTenNguoiThue;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbXeThue;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label lblBienSo;
        private System.Windows.Forms.GroupBox gbLoaiXe;
        private System.Windows.Forms.RadioButton rdb250cc;
        private System.Windows.Forms.RadioButton rdb100cc;
        private System.Windows.Forms.RadioButton rdbXeMay;
        private System.Windows.Forms.RadioButton rdbXeDap;
        private System.Windows.Forms.ListView lsvXe;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSaoLuu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTenTimKiem;
        private System.Windows.Forms.TextBox txtTenTimKiem;
        private System.Windows.Forms.Button btnKhoiPhuc;
    }
}

