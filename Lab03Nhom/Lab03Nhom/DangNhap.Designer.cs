namespace Lab03Nhom
{
    partial class DangNhap
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
            this.lbl_TenDN = new System.Windows.Forms.Label();
            this.lbl_MK = new System.Windows.Forms.Label();
            this.tb_TenDN = new System.Windows.Forms.TextBox();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TenDN
            // 
            this.lbl_TenDN.AutoSize = true;
            this.lbl_TenDN.Location = new System.Drawing.Point(23, 50);
            this.lbl_TenDN.Name = "lbl_TenDN";
            this.lbl_TenDN.Size = new System.Drawing.Size(81, 13);
            this.lbl_TenDN.TabIndex = 0;
            this.lbl_TenDN.Text = "Tên đăng nhập";
            // 
            // lbl_MK
            // 
            this.lbl_MK.AutoSize = true;
            this.lbl_MK.Location = new System.Drawing.Point(23, 113);
            this.lbl_MK.Name = "lbl_MK";
            this.lbl_MK.Size = new System.Drawing.Size(52, 13);
            this.lbl_MK.TabIndex = 1;
            this.lbl_MK.Text = "Mật khẩu";
            // 
            // tb_TenDN
            // 
            this.tb_TenDN.Location = new System.Drawing.Point(122, 47);
            this.tb_TenDN.Name = "tb_TenDN";
            this.tb_TenDN.Size = new System.Drawing.Size(175, 20);
            this.tb_TenDN.TabIndex = 2;
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Location = new System.Drawing.Point(122, 110);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.Size = new System.Drawing.Size(175, 20);
            this.tb_MatKhau.TabIndex = 3;
            this.tb_MatKhau.UseSystemPasswordChar = true;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(122, 180);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(75, 23);
            this.btn_DangNhap.TabIndex = 4;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(222, 180);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 230);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.tb_MatKhau);
            this.Controls.Add(this.tb_TenDN);
            this.Controls.Add(this.lbl_MK);
            this.Controls.Add(this.lbl_TenDN);
            this.Name = "DangNhap";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TenDN;
        private System.Windows.Forms.Label lbl_MK;
        private System.Windows.Forms.TextBox tb_TenDN;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Thoat;
    }
}

