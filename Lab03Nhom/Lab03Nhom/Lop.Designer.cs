namespace Lab03Nhom
{
    partial class Lop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_XemDSLop = new System.Windows.Forms.Button();
            this.dg_XemDSLop = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ThemLop = new System.Windows.Forms.Button();
            this.cb_DSNV = new System.Windows.Forms.ComboBox();
            this.lbl_NhanVien = new System.Windows.Forms.Label();
            this.tb_TenLop = new System.Windows.Forms.TextBox();
            this.tb_MaLop = new System.Windows.Forms.TextBox();
            this.lbl_TenLop = new System.Windows.Forms.Label();
            this.lb_MaLop = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_XemDSLop)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_XemDSLop);
            this.groupBox1.Controls.Add(this.dg_XemDSLop);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp";
            // 
            // btn_XemDSLop
            // 
            this.btn_XemDSLop.Location = new System.Drawing.Point(393, 174);
            this.btn_XemDSLop.Name = "btn_XemDSLop";
            this.btn_XemDSLop.Size = new System.Drawing.Size(94, 23);
            this.btn_XemDSLop.TabIndex = 1;
            this.btn_XemDSLop.Text = "Xem danh sách";
            this.btn_XemDSLop.UseVisualStyleBackColor = true;
            this.btn_XemDSLop.Click += new System.EventHandler(this.btn_XemDSLop_Click);
            // 
            // dg_XemDSLop
            // 
            this.dg_XemDSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_XemDSLop.Location = new System.Drawing.Point(20, 19);
            this.dg_XemDSLop.Name = "dg_XemDSLop";
            this.dg_XemDSLop.Size = new System.Drawing.Size(467, 140);
            this.dg_XemDSLop.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ThemLop);
            this.groupBox2.Controls.Add(this.cb_DSNV);
            this.groupBox2.Controls.Add(this.lbl_NhanVien);
            this.groupBox2.Controls.Add(this.tb_TenLop);
            this.groupBox2.Controls.Add(this.tb_MaLop);
            this.groupBox2.Controls.Add(this.lbl_TenLop);
            this.groupBox2.Controls.Add(this.lb_MaLop);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm lớp";
            // 
            // btn_ThemLop
            // 
            this.btn_ThemLop.Location = new System.Drawing.Point(412, 94);
            this.btn_ThemLop.Name = "btn_ThemLop";
            this.btn_ThemLop.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemLop.TabIndex = 6;
            this.btn_ThemLop.Text = "Thêm";
            this.btn_ThemLop.UseVisualStyleBackColor = true;
            this.btn_ThemLop.Click += new System.EventHandler(this.btn_ThemLop_Click);
            // 
            // cb_DSNV
            // 
            this.cb_DSNV.FormattingEnabled = true;
            this.cb_DSNV.Location = new System.Drawing.Point(91, 61);
            this.cb_DSNV.Name = "cb_DSNV";
            this.cb_DSNV.Size = new System.Drawing.Size(121, 21);
            this.cb_DSNV.TabIndex = 5;
            // 
            // lbl_NhanVien
            // 
            this.lbl_NhanVien.AutoSize = true;
            this.lbl_NhanVien.Location = new System.Drawing.Point(17, 64);
            this.lbl_NhanVien.Name = "lbl_NhanVien";
            this.lbl_NhanVien.Size = new System.Drawing.Size(56, 13);
            this.lbl_NhanVien.TabIndex = 4;
            this.lbl_NhanVien.Text = "Nhân viên";
            // 
            // tb_TenLop
            // 
            this.tb_TenLop.Location = new System.Drawing.Point(319, 24);
            this.tb_TenLop.Name = "tb_TenLop";
            this.tb_TenLop.Size = new System.Drawing.Size(168, 20);
            this.tb_TenLop.TabIndex = 3;
            // 
            // tb_MaLop
            // 
            this.tb_MaLop.Location = new System.Drawing.Point(91, 24);
            this.tb_MaLop.Name = "tb_MaLop";
            this.tb_MaLop.Size = new System.Drawing.Size(121, 20);
            this.tb_MaLop.TabIndex = 2;
            // 
            // lbl_TenLop
            // 
            this.lbl_TenLop.AutoSize = true;
            this.lbl_TenLop.Location = new System.Drawing.Point(250, 27);
            this.lbl_TenLop.Name = "lbl_TenLop";
            this.lbl_TenLop.Size = new System.Drawing.Size(43, 13);
            this.lbl_TenLop.TabIndex = 1;
            this.lbl_TenLop.Text = "Tên lớp";
            // 
            // lb_MaLop
            // 
            this.lb_MaLop.AutoSize = true;
            this.lb_MaLop.Location = new System.Drawing.Point(17, 27);
            this.lb_MaLop.Name = "lb_MaLop";
            this.lb_MaLop.Size = new System.Drawing.Size(39, 13);
            this.lb_MaLop.TabIndex = 0;
            this.lb_MaLop.Text = "Mã lớp";
            // 
            // Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lop";
            this.Text = "Lop";
            this.Load += new System.EventHandler(this.Lop_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_XemDSLop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_XemDSLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_DSNV;
        private System.Windows.Forms.Label lbl_NhanVien;
        private System.Windows.Forms.TextBox tb_TenLop;
        private System.Windows.Forms.TextBox tb_MaLop;
        private System.Windows.Forms.Label lbl_TenLop;
        private System.Windows.Forms.Label lb_MaLop;
        private System.Windows.Forms.Button btn_XemDSLop;
        private System.Windows.Forms.Button btn_ThemLop;
    }
}