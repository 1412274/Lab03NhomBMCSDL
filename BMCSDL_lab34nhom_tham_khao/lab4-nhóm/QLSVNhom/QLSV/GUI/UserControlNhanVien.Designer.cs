namespace QLSV.GUI
{
    partial class UserControlNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lvDSNhanVien = new System.Windows.Forms.ListView();
            this.colMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boxThongTinNV = new System.Windows.Forms.GroupBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.boxThongTinNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.lvDSNhanVien);
            this.groupBox2.Location = new System.Drawing.Point(21, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 209);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(439, 166);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(223, 166);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(115, 166);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(547, 166);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(331, 166);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Ghi/Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(7, 166);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lvDSNhanVien
            // 
            this.lvDSNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNV,
            this.colHoTen,
            this.colEmail,
            this.colLuong});
            this.lvDSNhanVien.FullRowSelect = true;
            this.lvDSNhanVien.GridLines = true;
            this.lvDSNhanVien.Location = new System.Drawing.Point(6, 19);
            this.lvDSNhanVien.MultiSelect = false;
            this.lvDSNhanVien.Name = "lvDSNhanVien";
            this.lvDSNhanVien.Size = new System.Drawing.Size(617, 132);
            this.lvDSNhanVien.TabIndex = 0;
            this.lvDSNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvDSNhanVien.View = System.Windows.Forms.View.Details;
            this.lvDSNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvDSNhanVien_SelectedIndexChanged);
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "MÃ NHÂN VIÊN";
            this.colMaNV.Width = 100;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "HỌ TÊN";
            this.colHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHoTen.Width = 200;
            // 
            // colEmail
            // 
            this.colEmail.Text = "EMAIL";
            this.colEmail.Width = 150;
            // 
            // colLuong
            // 
            this.colLuong.Text = "LƯƠNG";
            this.colLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLuong.Width = 120;
            // 
            // boxThongTinNV
            // 
            this.boxThongTinNV.Controls.Add(this.txtMatKhau);
            this.boxThongTinNV.Controls.Add(this.label7);
            this.boxThongTinNV.Controls.Add(this.txtLuong);
            this.boxThongTinNV.Controls.Add(this.label6);
            this.boxThongTinNV.Controls.Add(this.txtHoTen);
            this.boxThongTinNV.Controls.Add(this.label5);
            this.boxThongTinNV.Controls.Add(this.txtTenDangNhap);
            this.boxThongTinNV.Controls.Add(this.label4);
            this.boxThongTinNV.Controls.Add(this.txtEmail);
            this.boxThongTinNV.Controls.Add(this.label3);
            this.boxThongTinNV.Controls.Add(this.txtMaNV);
            this.boxThongTinNV.Controls.Add(this.label2);
            this.boxThongTinNV.Location = new System.Drawing.Point(21, 55);
            this.boxThongTinNV.Name = "boxThongTinNV";
            this.boxThongTinNV.Size = new System.Drawing.Size(629, 155);
            this.boxThongTinNV.TabIndex = 4;
            this.boxThongTinNV.TabStop = false;
            this.boxThongTinNV.Text = "Thông tin nhân viên";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.Location = new System.Drawing.Point(385, 110);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(180, 20);
            this.txtMatKhau.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mật khẩu";
            // 
            // txtLuong
            // 
            this.txtLuong.Enabled = false;
            this.txtLuong.Location = new System.Drawing.Point(385, 69);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(180, 20);
            this.txtLuong.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lương";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(385, 31);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 20);
            this.txtHoTen.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Họ tên";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Enabled = false;
            this.txtTenDangNhap.Location = new System.Drawing.Point(96, 110);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(180, 20);
            this.txtTenDangNhap.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên đăng nhập";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(96, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(96, 31);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(180, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // UserControlNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.boxThongTinNV);
            this.Controls.Add(this.label1);
            this.Name = "UserControlNhanVien";
            this.Size = new System.Drawing.Size(671, 453);
            this.groupBox2.ResumeLayout(false);
            this.boxThongTinNV.ResumeLayout(false);
            this.boxThongTinNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvDSNhanVien;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colLuong;
        private System.Windows.Forms.GroupBox boxThongTinNV;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;

    }
}
