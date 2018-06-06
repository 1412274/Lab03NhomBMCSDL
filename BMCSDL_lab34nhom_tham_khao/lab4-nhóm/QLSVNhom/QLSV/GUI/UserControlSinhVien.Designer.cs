namespace QLSV.GUI
{
    partial class UserControlSinhVien
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
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxLop = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lvDSSinhVien = new System.Windows.Forms.ListView();
            this.colMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenDN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boxThongTinNV = new System.Windows.Forms.GroupBox();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.boxThongTinNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Chọn lớp";
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLop.FormattingEnabled = true;
            this.comboBoxLop.Location = new System.Drawing.Point(415, 58);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(180, 21);
            this.comboBoxLop.TabIndex = 21;
            this.comboBoxLop.SelectedValueChanged += new System.EventHandler(this.comboBoxLop_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.lvDSSinhVien);
            this.groupBox2.Location = new System.Drawing.Point(30, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 195);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(439, 159);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(223, 159);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(115, 159);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(547, 159);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(331, 159);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Ghi/Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(7, 159);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lvDSSinhVien
            // 
            this.lvDSSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSV,
            this.colHoTen,
            this.colNgaySinh,
            this.colDiaChi,
            this.colTenDN});
            this.lvDSSinhVien.FullRowSelect = true;
            this.lvDSSinhVien.GridLines = true;
            this.lvDSSinhVien.Location = new System.Drawing.Point(6, 19);
            this.lvDSSinhVien.MultiSelect = false;
            this.lvDSSinhVien.Name = "lvDSSinhVien";
            this.lvDSSinhVien.Size = new System.Drawing.Size(617, 124);
            this.lvDSSinhVien.TabIndex = 0;
            this.lvDSSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvDSSinhVien.View = System.Windows.Forms.View.Details;
            this.lvDSSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvDSSinhVien_SelectedIndexChanged);
            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã SV";
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ Tên";
            this.colHoTen.Width = 121;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 120;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 167;
            // 
            // colTenDN
            // 
            this.colTenDN.Text = "Tên DN";
            this.colTenDN.Width = 120;
            // 
            // boxThongTinNV
            // 
            this.boxThongTinNV.Controls.Add(this.txtNgaySinh);
            this.boxThongTinNV.Controls.Add(this.txtMatKhau);
            this.boxThongTinNV.Controls.Add(this.label7);
            this.boxThongTinNV.Controls.Add(this.txtDiaChi);
            this.boxThongTinNV.Controls.Add(this.label6);
            this.boxThongTinNV.Controls.Add(this.txtHoTen);
            this.boxThongTinNV.Controls.Add(this.label5);
            this.boxThongTinNV.Controls.Add(this.txtTenDangNhap);
            this.boxThongTinNV.Controls.Add(this.label4);
            this.boxThongTinNV.Controls.Add(this.label3);
            this.boxThongTinNV.Controls.Add(this.txtMaSV);
            this.boxThongTinNV.Controls.Add(this.label2);
            this.boxThongTinNV.Location = new System.Drawing.Point(30, 85);
            this.boxThongTinNV.Name = "boxThongTinNV";
            this.boxThongTinNV.Size = new System.Drawing.Size(629, 153);
            this.boxThongTinNV.TabIndex = 19;
            this.boxThongTinNV.TabStop = false;
            this.boxThongTinNV.Text = "Thông tin sinh viên";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.txtNgaySinh.Enabled = false;
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaySinh.Location = new System.Drawing.Point(96, 71);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(180, 20);
            this.txtNgaySinh.TabIndex = 12;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.Location = new System.Drawing.Point(385, 118);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(180, 20);
            this.txtMatKhau.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mật khẩu";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(385, 72);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(180, 20);
            this.txtDiaChi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa chỉ";
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
            this.txtTenDangNhap.Location = new System.Drawing.Point(96, 118);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(180, 20);
            this.txtTenDangNhap.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Enabled = false;
            this.txtMaSV.Location = new System.Drawing.Point(96, 31);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(180, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // UserControlSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxLop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.boxThongTinNV);
            this.Controls.Add(this.label1);
            this.Name = "UserControlSinhVien";
            this.Size = new System.Drawing.Size(671, 453);
            this.groupBox2.ResumeLayout(false);
            this.boxThongTinNV.ResumeLayout(false);
            this.boxThongTinNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView lvDSSinhVien;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.ColumnHeader colTenDN;
        private System.Windows.Forms.GroupBox boxThongTinNV;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
    }
}
