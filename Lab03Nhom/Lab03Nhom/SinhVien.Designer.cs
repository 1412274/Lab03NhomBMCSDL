namespace Lab03Nhom
{
    partial class SinhVien
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
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_LayDSSV = new System.Windows.Forms.Button();
            this.dg_DSSV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CapNhat);
            this.groupBox1.Controls.Add(this.btn_LayDSSV);
            this.groupBox1.Controls.Add(this.dg_DSSV);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(515, 283);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(75, 23);
            this.btn_CapNhat.TabIndex = 2;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_LayDSSV
            // 
            this.btn_LayDSSV.Location = new System.Drawing.Point(614, 283);
            this.btn_LayDSSV.Name = "btn_LayDSSV";
            this.btn_LayDSSV.Size = new System.Drawing.Size(95, 23);
            this.btn_LayDSSV.TabIndex = 1;
            this.btn_LayDSSV.Text = "Load danh sách";
            this.btn_LayDSSV.UseVisualStyleBackColor = true;
            this.btn_LayDSSV.Click += new System.EventHandler(this.btn_LayDSSV_Click);
            // 
            // dg_DSSV
            // 
            this.dg_DSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DSSV.Location = new System.Drawing.Point(16, 29);
            this.dg_DSSV.Name = "dg_DSSV";
            this.dg_DSSV.Size = new System.Drawing.Size(693, 235);
            this.dg_DSSV.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm sinh viên";
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SinhVien";
            this.Text = "SinhVien";
            this.Load += new System.EventHandler(this.SinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_DSSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_LayDSSV;
        private System.Windows.Forms.DataGridView dg_DSSV;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}