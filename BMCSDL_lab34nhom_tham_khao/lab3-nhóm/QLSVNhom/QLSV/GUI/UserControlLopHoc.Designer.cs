namespace QLSV.GUI
{
    partial class UserControlLopHoc
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
            this.lvDSLop = new System.Windows.Forms.ListView();
            this.colMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boxThongTinNV = new System.Windows.Forms.GroupBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.boxThongTinNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(577, 407);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(357, 407);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(247, 407);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Ghi/Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(137, 407);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 407);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm lớp";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvDSLop);
            this.groupBox2.Location = new System.Drawing.Point(345, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 270);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp";
            // 
            // lvDSLop
            // 
            this.lvDSLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaLop,
            this.colTenLop});
            this.lvDSLop.FullRowSelect = true;
            this.lvDSLop.GridLines = true;
            this.lvDSLop.Location = new System.Drawing.Point(50, 29);
            this.lvDSLop.MultiSelect = false;
            this.lvDSLop.Name = "lvDSLop";
            this.lvDSLop.Size = new System.Drawing.Size(220, 219);
            this.lvDSLop.TabIndex = 0;
            this.lvDSLop.UseCompatibleStateImageBehavior = false;
            this.lvDSLop.View = System.Windows.Forms.View.Details;
            this.lvDSLop.SelectedIndexChanged += new System.EventHandler(this.lvDSLop_SelectedIndexChanged);
            // 
            // colMaLop
            // 
            this.colMaLop.Text = "Mã lớp";
            this.colMaLop.Width = 70;
            // 
            // colTenLop
            // 
            this.colTenLop.Text = "Tên lớp";
            this.colTenLop.Width = 134;
            // 
            // boxThongTinNV
            // 
            this.boxThongTinNV.Controls.Add(this.txtTenLop);
            this.boxThongTinNV.Controls.Add(this.label5);
            this.boxThongTinNV.Controls.Add(this.txtMaLop);
            this.boxThongTinNV.Controls.Add(this.label2);
            this.boxThongTinNV.Location = new System.Drawing.Point(27, 89);
            this.boxThongTinNV.Name = "boxThongTinNV";
            this.boxThongTinNV.Size = new System.Drawing.Size(261, 270);
            this.boxThongTinNV.TabIndex = 13;
            this.boxThongTinNV.TabStop = false;
            this.boxThongTinNV.Text = "Thông tin lớp học";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Location = new System.Drawing.Point(35, 176);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(180, 20);
            this.txtTenLop.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(35, 78);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(180, 20);
            this.txtMaLop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(467, 407);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // UserControlLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.boxThongTinNV);
            this.Controls.Add(this.label1);
            this.Name = "UserControlLopHoc";
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
        private System.Windows.Forms.ListView lvDSLop;
        private System.Windows.Forms.ColumnHeader colMaLop;
        private System.Windows.Forms.ColumnHeader colTenLop;
        private System.Windows.Forms.GroupBox boxThongTinNV;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
    }
}
