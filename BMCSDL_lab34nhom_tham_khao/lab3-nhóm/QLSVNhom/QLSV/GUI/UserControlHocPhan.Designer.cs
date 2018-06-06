namespace QLSV.GUI
{
    partial class UserControlHocPhan
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
            this.lvDSHocPhan = new System.Windows.Forms.ListView();
            this.colMaHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boxThongTinNV = new System.Windows.Forms.GroupBox();
            this.txtSoTC = new System.Windows.Forms.NumericUpDown();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.boxThongTinNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvDSHocPhan);
            this.groupBox2.Location = new System.Drawing.Point(357, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 270);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học phần";
            // 
            // lvDSHocPhan
            // 
            this.lvDSHocPhan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHP,
            this.colTenHP,
            this.colSoTC});
            this.lvDSHocPhan.FullRowSelect = true;
            this.lvDSHocPhan.GridLines = true;
            this.lvDSHocPhan.Location = new System.Drawing.Point(50, 29);
            this.lvDSHocPhan.MultiSelect = false;
            this.lvDSHocPhan.Name = "lvDSHocPhan";
            this.lvDSHocPhan.Size = new System.Drawing.Size(220, 219);
            this.lvDSHocPhan.TabIndex = 0;
            this.lvDSHocPhan.UseCompatibleStateImageBehavior = false;
            this.lvDSHocPhan.View = System.Windows.Forms.View.Details;
            this.lvDSHocPhan.SelectedIndexChanged += new System.EventHandler(this.lvDSHocPhan_SelectedIndexChanged);
            // 
            // colMaHP
            // 
            this.colMaHP.Text = "Mã học phần";
            this.colMaHP.Width = 76;
            // 
            // colTenHP
            // 
            this.colTenHP.Text = "Tên học phần";
            this.colTenHP.Width = 92;
            // 
            // colSoTC
            // 
            this.colSoTC.Text = "Số tín chỉ";
            // 
            // boxThongTinNV
            // 
            this.boxThongTinNV.Controls.Add(this.txtSoTC);
            this.boxThongTinNV.Controls.Add(this.txtTenHP);
            this.boxThongTinNV.Controls.Add(this.label3);
            this.boxThongTinNV.Controls.Add(this.txtMaHP);
            this.boxThongTinNV.Controls.Add(this.label5);
            this.boxThongTinNV.Controls.Add(this.label2);
            this.boxThongTinNV.Location = new System.Drawing.Point(39, 80);
            this.boxThongTinNV.Name = "boxThongTinNV";
            this.boxThongTinNV.Size = new System.Drawing.Size(261, 270);
            this.boxThongTinNV.TabIndex = 23;
            this.boxThongTinNV.TabStop = false;
            this.boxThongTinNV.Text = "Thông tin học phần";
            // 
            // txtSoTC
            // 
            this.txtSoTC.Enabled = false;
            this.txtSoTC.Location = new System.Drawing.Point(33, 205);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.Size = new System.Drawing.Size(180, 20);
            this.txtSoTC.TabIndex = 11;
            // 
            // txtTenHP
            // 
            this.txtTenHP.Enabled = false;
            this.txtTenHP.Location = new System.Drawing.Point(33, 120);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(180, 20);
            this.txtTenHP.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên HP";
            // 
            // txtMaHP
            // 
            this.txtMaHP.Enabled = false;
            this.txtMaHP.Location = new System.Drawing.Point(33, 46);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(180, 20);
            this.txtMaHP.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số tín chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "QUẢN LÝ HỌC PHẦN";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(479, 409);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(263, 409);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 39;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(155, 409);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(587, 409);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 37;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(371, 409);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Ghi/Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(47, 409);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // UserControlHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.boxThongTinNV);
            this.Name = "UserControlHocPhan";
            this.Size = new System.Drawing.Size(671, 453);
            this.groupBox2.ResumeLayout(false);
            this.boxThongTinNV.ResumeLayout(false);
            this.boxThongTinNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvDSHocPhan;
        private System.Windows.Forms.ColumnHeader colMaHP;
        private System.Windows.Forms.ColumnHeader colTenHP;
        private System.Windows.Forms.GroupBox boxThongTinNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colSoTC;
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown txtSoTC;
    }
}
