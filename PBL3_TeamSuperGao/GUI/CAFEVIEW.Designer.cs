
namespace PBL3_TeamSuperGao.GUI
{
    partial class CAFEVIEW
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> //
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAFEVIEW));
            this.labelnamecf = new System.Windows.Forms.Label();
            this.comboBoxDM = new System.Windows.Forms.ComboBox();
            this.comboBoxM = new System.Windows.Forms.ComboBox();
            this.comboBoxSL = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.cbbChuyenBan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGopBan = new System.Windows.Forms.Button();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnamecf
            // 
            this.labelnamecf.Font = new System.Drawing.Font("Ravie", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnamecf.ForeColor = System.Drawing.Color.Red;
            this.labelnamecf.Location = new System.Drawing.Point(424, 7);
            this.labelnamecf.Name = "labelnamecf";
            this.labelnamecf.Size = new System.Drawing.Size(410, 52);
            this.labelnamecf.TabIndex = 1;
            this.labelnamecf.Text = "Cà Phê Anh Em";
            // 
            // comboBoxDM
            // 
            this.comboBoxDM.FormattingEnabled = true;
            this.comboBoxDM.Location = new System.Drawing.Point(628, 81);
            this.comboBoxDM.Name = "comboBoxDM";
            this.comboBoxDM.Size = new System.Drawing.Size(136, 27);
            this.comboBoxDM.TabIndex = 2;
            this.comboBoxDM.SelectedIndexChanged += new System.EventHandler(this.comboBoxDM_SelectedIndexChanged);
            // 
            // comboBoxM
            // 
            this.comboBoxM.FormattingEnabled = true;
            this.comboBoxM.Location = new System.Drawing.Point(628, 114);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(136, 27);
            this.comboBoxM.TabIndex = 3;
            // 
            // comboBoxSL
            // 
            this.comboBoxSL.FormattingEnabled = true;
            this.comboBoxSL.Location = new System.Drawing.Point(789, 113);
            this.comboBoxSL.Name = "comboBoxSL";
            this.comboBoxSL.Size = new System.Drawing.Size(82, 27);
            this.comboBoxSL.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(533, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 308);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách";
            // 
            // dtgvDanhSach
            // 
            this.dtgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSach.Location = new System.Drawing.Point(14, 22);
            this.dtgvDanhSach.Name = "dtgvDanhSach";
            this.dtgvDanhSach.RowHeadersWidth = 51;
            this.dtgvDanhSach.Size = new System.Drawing.Size(566, 269);
            this.dtgvDanhSach.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(787, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(529, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Danh Mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Món";
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnChuyenBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChuyenBan.Location = new System.Drawing.Point(547, 466);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(94, 60);
            this.btnChuyenBan.TabIndex = 11;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = false;
            this.btnChuyenBan.Click += new System.EventHandler(this.buttonChuyenBan_Click);
            // 
            // cbbChuyenBan
            // 
            this.cbbChuyenBan.FormattingEnabled = true;
            this.cbbChuyenBan.Location = new System.Drawing.Point(612, 531);
            this.cbbChuyenBan.Name = "cbbChuyenBan";
            this.cbbChuyenBan.Size = new System.Drawing.Size(126, 27);
            this.cbbChuyenBan.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(744, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giảm giá (%)";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(873, 532);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(138, 26);
            this.txtTongTien.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(744, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tổng tiền";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 81);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(487, 393);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // btnGopBan
            // 
            this.btnGopBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGopBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGopBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGopBan.Location = new System.Drawing.Point(655, 465);
            this.btnGopBan.Name = "btnGopBan";
            this.btnGopBan.Size = new System.Drawing.Size(83, 60);
            this.btnGopBan.TabIndex = 41;
            this.btnGopBan.Text = "Gộp bàn";
            this.btnGopBan.UseVisualStyleBackColor = false;
            this.btnGopBan.Click += new System.EventHandler(this.buttonGopBan_Click);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(873, 473);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(138, 26);
            this.txtGiamGia.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(553, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Bàn";
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.Aqua;
            this.btnTroVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTroVe.Image = global::PBL3_TeamSuperGao.Properties.Resources.Go_back_32px;
            this.btnTroVe.Location = new System.Drawing.Point(33, 25);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(80, 34);
            this.btnTroVe.TabIndex = 46;
            this.btnTroVe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.Image = global::PBL3_TeamSuperGao.Properties.Resources.systemusers_32px;
            this.btnHeThong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHeThong.Location = new System.Drawing.Point(1008, 10);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(105, 52);
            this.btnHeThong.TabIndex = 35;
            this.btnHeThong.Text = "Hệ thống ";
            this.btnHeThong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHeThong.UseVisualStyleBackColor = true;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Handle);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaMon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMon.Image = global::PBL3_TeamSuperGao.Properties.Resources.trash_32px;
            this.btnXoaMon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaMon.Location = new System.Drawing.Point(1017, 83);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(96, 62);
            this.btnXoaMon.TabIndex = 32;
            this.btnXoaMon.Text = "Xóa Món";
            this.btnXoaMon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaMon.UseVisualStyleBackColor = false;
            this.btnXoaMon.Click += new System.EventHandler(this.buttonXoaMon_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = global::PBL3_TeamSuperGao.Properties.Resources.pay_per_32px1;
            this.btnThanhToan.Location = new System.Drawing.Point(1017, 473);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(96, 86);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThemMon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Image = global::PBL3_TeamSuperGao.Properties.Resources.add_icon_32px;
            this.btnThemMon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemMon.Location = new System.Drawing.Point(912, 83);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(99, 62);
            this.btnThemMon.TabIndex = 9;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.buttonThemMon_Click);
            // 
            // CAFEVIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1146, 571);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.btnGopBan);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnHeThong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbChuyenBan);
            this.Controls.Add(this.btnChuyenBan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSL);
            this.Controls.Add(this.comboBoxM);
            this.Controls.Add(this.comboBoxDM);
            this.Controls.Add(this.labelnamecf);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CAFEVIEW";
            this.Text = "Cafe Anh Em";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelnamecf;
        private System.Windows.Forms.ComboBox comboBoxDM;
        private System.Windows.Forms.ComboBox comboBoxM;
        private System.Windows.Forms.ComboBox comboBoxSL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.ComboBox cbbChuyenBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.DataGridView dtgvDanhSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGopBan;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTroVe;
    }
}

