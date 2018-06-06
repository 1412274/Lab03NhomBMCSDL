namespace QLSV.GUI
{
    partial class UserControlBangDiem
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvDSDiem = new System.Windows.Forms.ListView();
            this.colMaHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boxThongTinNV = new System.Windows.Forms.GroupBox();
            this.comboBoxMaHP = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxLop = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMaSV = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.boxThongTinNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(582, 416);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(362, 416);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(252, 416);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Ghi/Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(142, 416);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(32, 416);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvDSDiem);
            this.groupBox2.Location = new System.Drawing.Point(350, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 270);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách điểm";
            // 
            // lvDSDiem
            // 
            this.lvDSDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHP,
            this.colTenHP,
            this.colDiem});
            this.lvDSDiem.FullRowSelect = true;
            this.lvDSDiem.GridLines = true;
            this.lvDSDiem.Location = new System.Drawing.Point(50, 29);
            this.lvDSDiem.MultiSelect = false;
            this.lvDSDiem.Name = "lvDSDiem";
            this.lvDSDiem.Size = new System.Drawing.Size(220, 219);
            this.lvDSDiem.TabIndex = 0;
            this.lvDSDiem.UseCompatibleStateImageBehavior = false;
            this.lvDSDiem.View = System.Windows.Forms.View.Details;
            this.lvDSDiem.SelectedIndexChanged += new System.EventHandler(this.lvDSDiem_SelectedIndexChanged);
            // 
            // colMaHP
            // 
            this.colMaHP.Text = "Mã học phần";
            this.colMaHP.Width = 76;
            // 
            // colTenHP
            // 
            this.colTenHP.Text = "Tên học phần";
            this.colTenHP.Width = 75;
            // 
            // colDiem
            // 
            this.colDiem.Text = "Điểm";
            // 
            // boxThongTinNV
            // 
            this.boxThongTinNV.Controls.Add(this.comboBoxMaHP);
            this.boxThongTinNV.Controls.Add(this.txtDiem);
            this.boxThongTinNV.Controls.Add(this.label5);
            this.boxThongTinNV.Controls.Add(this.label2);
            this.boxThongTinNV.Location = new System.Drawing.Point(32, 98);
            this.boxThongTinNV.Name = "boxThongTinNV";
            this.boxThongTinNV.Size = new System.Drawing.Size(261, 270);
            this.boxThongTinNV.TabIndex = 21;
            this.boxThongTinNV.TabStop = false;
            this.boxThongTinNV.Text = "Thông tin điểm môn học";
            // 
            // comboBoxMaHP
            // 
            this.comboBoxMaHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaHP.Enabled = false;
            this.comboBoxMaHP.FormattingEnabled = true;
            this.comboBoxMaHP.Location = new System.Drawing.Point(33, 56);
            this.comboBoxMaHP.Name = "comboBoxMaHP";
            this.comboBoxMaHP.Size = new System.Drawing.Size(180, 21);
            this.comboBoxMaHP.TabIndex = 33;
            // 
            // txtDiem
            // 
            this.txtDiem.Enabled = false;
            this.txtDiem.Location = new System.Drawing.Point(33, 166);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(180, 20);
            this.txtDiem.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "QUẢN LÝ BẢNG ĐIỂM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Chọn lớp";
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLop.FormattingEnabled = true;
            this.comboBoxLop.Location = new System.Drawing.Point(113, 60);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(180, 21);
            this.comboBoxLop.TabIndex = 30;
            this.comboBoxLop.SelectedIndexChanged += new System.EventHandler(this.comboBoxLop_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Chọn SV";
            // 
            // comboBoxMaSV
            // 
            this.comboBoxMaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaSV.Enabled = false;
            this.comboBoxMaSV.FormattingEnabled = true;
            this.comboBoxMaSV.Location = new System.Drawing.Point(402, 60);
            this.comboBoxMaSV.Name = "comboBoxMaSV";
            this.comboBoxMaSV.Size = new System.Drawing.Size(180, 21);
            this.comboBoxMaSV.TabIndex = 32;
            this.comboBoxMaSV.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaSV_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(472, 416);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // UserControlBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMaSV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.boxThongTinNV);
            this.Name = "UserControlBangDiem";
            this.Size = new System.Drawing.Size(671, 453);
            this.groupBox2.ResumeLayout(false);
            this.boxThongTinNV.ResumeLayout(false);
            this.boxThongTinNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvDSDiem;
        private System.Windows.Forms.GroupBox boxThongTinNV;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colMaHP;
        private System.Windows.Forms.ColumnHeader colTenHP;
        private System.Windows.Forms.ColumnHeader colDiem;
        private System.Windows.Forms.ComboBox comboBoxMaHP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMaSV;
        private System.Windows.Forms.Button btnReset;
    }
}
