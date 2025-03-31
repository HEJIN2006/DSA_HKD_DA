namespace DSA_new
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNhapID = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.lblNhapten = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNguoiDang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBaiVietGanDay = new System.Windows.Forms.Label();
            this.btnDang = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.listBoxNoiDung = new System.Windows.Forms.ListBox();
            this.picBoxAnh = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Location = new System.Drawing.Point(338, 114);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(144, 50);
            this.btnChinhSua.TabIndex = 41;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(163, 77);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 50);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtNhapID);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Location = new System.Drawing.Point(498, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 155);
            this.panel1.TabIndex = 43;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Yellow;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblID.Location = new System.Drawing.Point(17, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(45, 29);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // txtNhapID
            // 
            this.txtNhapID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapID.Location = new System.Drawing.Point(81, 28);
            this.txtNhapID.Multiline = true;
            this.txtNhapID.Name = "txtNhapID";
            this.txtNhapID.Size = new System.Drawing.Size(198, 29);
            this.txtNhapID.TabIndex = 22;
            this.txtNhapID.TextChanged += new System.EventHandler(this.txtNhapID_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(17, 77);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(140, 50);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(123, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 16);
            this.label14.TabIndex = 40;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(644, 367);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(140, 50);
            this.btnQuayLai.TabIndex = 42;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.BackColor = System.Drawing.Color.Yellow;
            this.lblNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNoiDung.Location = new System.Drawing.Point(194, 64);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(111, 29);
            this.lblNoiDung.TabIndex = 39;
            this.lblNoiDung.Text = "Nội dung";
            this.lblNoiDung.Click += new System.EventHandler(this.lblNoiDung_Click);
            // 
            // lblNhapten
            // 
            this.lblNhapten.AutoSize = true;
            this.lblNhapten.BackColor = System.Drawing.Color.Yellow;
            this.lblNhapten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapten.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNhapten.Location = new System.Drawing.Point(193, 15);
            this.lblNhapten.Name = "lblNhapten";
            this.lblNhapten.Size = new System.Drawing.Size(110, 29);
            this.lblNhapten.TabIndex = 38;
            this.lblNhapten.Text = "Nhập tên";
            this.lblNhapten.Click += new System.EventHandler(this.lblNhapten_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 36;
            // 
            // txtTenNguoiDang
            // 
            this.txtTenNguoiDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiDang.Location = new System.Drawing.Point(315, 14);
            this.txtTenNguoiDang.Name = "txtTenNguoiDang";
            this.txtTenNguoiDang.Size = new System.Drawing.Size(175, 30);
            this.txtTenNguoiDang.TabIndex = 35;
            this.txtTenNguoiDang.TextChanged += new System.EventHandler(this.txtTenNguoiDang_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-29, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(859, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lblBaiVietGanDay
            // 
            this.lblBaiVietGanDay.AutoSize = true;
            this.lblBaiVietGanDay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBaiVietGanDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaiVietGanDay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBaiVietGanDay.Location = new System.Drawing.Point(314, 195);
            this.lblBaiVietGanDay.Name = "lblBaiVietGanDay";
            this.lblBaiVietGanDay.Size = new System.Drawing.Size(216, 32);
            this.lblBaiVietGanDay.TabIndex = 33;
            this.lblBaiVietGanDay.Text = "Bài viết gần đây";
            this.lblBaiVietGanDay.Click += new System.EventHandler(this.lblBaiVietGanDay_Click);
            // 
            // btnDang
            // 
            this.btnDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDang.Location = new System.Drawing.Point(202, 115);
            this.btnDang.Name = "btnDang";
            this.btnDang.Size = new System.Drawing.Size(121, 50);
            this.btnDang.TabIndex = 32;
            this.btnDang.Text = "Đăng";
            this.btnDang.UseVisualStyleBackColor = true;
            this.btnDang.Click += new System.EventHandler(this.btnDang_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(315, 62);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(175, 29);
            this.txtNoiDung.TabIndex = 31;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // listBoxNoiDung
            // 
            this.listBoxNoiDung.BackColor = System.Drawing.Color.White;
            this.listBoxNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNoiDung.FormattingEnabled = true;
            this.listBoxNoiDung.ItemHeight = 29;
            this.listBoxNoiDung.Location = new System.Drawing.Point(6, 230);
            this.listBoxNoiDung.Name = "listBoxNoiDung";
            this.listBoxNoiDung.Size = new System.Drawing.Size(787, 207);
            this.listBoxNoiDung.TabIndex = 44;
            this.listBoxNoiDung.SelectedIndexChanged += new System.EventHandler(this.listBoxNoiDung_SelectedIndexChanged);
            // 
            // picBoxAnh
            // 
            this.picBoxAnh.BackColor = System.Drawing.SystemColors.GrayText;
            this.picBoxAnh.Image = global::DSA_new.Properties.Resources._487054652_1863096757767440_3258430002736435049_n;
            this.picBoxAnh.Location = new System.Drawing.Point(12, 9);
            this.picBoxAnh.Name = "picBoxAnh";
            this.picBoxAnh.Size = new System.Drawing.Size(173, 168);
            this.picBoxAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAnh.TabIndex = 45;
            this.picBoxAnh.TabStop = false;
            this.picBoxAnh.Click += new System.EventHandler(this.picBoxAnh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBoxAnh);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.lblNhapten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenNguoiDang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBaiVietGanDay);
            this.Controls.Add(this.btnDang);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.listBoxNoiDung);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtNhapID;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Label lblNhapten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNguoiDang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBaiVietGanDay;
        private System.Windows.Forms.Button btnDang;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ListBox listBoxNoiDung;
        private System.Windows.Forms.PictureBox picBoxAnh;
    }
}

