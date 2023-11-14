namespace QLQuanNET
{
    partial class FormNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.grp_dgv = new System.Windows.Forms.GroupBox();
            this.dgv_NV = new System.Windows.Forms.DataGridView();
            this.grp_TT = new System.Windows.Forms.GroupBox();
            this.grp_ = new System.Windows.Forms.GroupBox();
            this.grp_ThanhXuLy = new System.Windows.Forms.GroupBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.lbl_TenNV = new System.Windows.Forms.Label();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_HoTenNV = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.lbl_TK = new System.Windows.Forms.Label();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.ptb_NV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).BeginInit();
            this.grp_TT.SuspendLayout();
            this.grp_.SuspendLayout();
            this.grp_ThanhXuLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_NV)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_dgv
            // 
            this.grp_dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_dgv.Location = new System.Drawing.Point(24, 226);
            this.grp_dgv.Name = "grp_dgv";
            this.grp_dgv.Size = new System.Drawing.Size(571, 322);
            this.grp_dgv.TabIndex = 0;
            this.grp_dgv.TabStop = false;
            this.grp_dgv.Text = "Danh Sách:";
            // 
            // dgv_NV
            // 
            this.dgv_NV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NV.Location = new System.Drawing.Point(24, 248);
            this.dgv_NV.Name = "dgv_NV";
            this.dgv_NV.Size = new System.Drawing.Size(571, 294);
            this.dgv_NV.TabIndex = 1;
            // 
            // grp_TT
            // 
            this.grp_TT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_TT.Controls.Add(this.ptb_NV);
            this.grp_TT.Controls.Add(this.txt_email);
            this.grp_TT.Controls.Add(this.txt_SDT);
            this.grp_TT.Controls.Add(this.txt_HoTenNV);
            this.grp_TT.Controls.Add(this.txt_MaNV);
            this.grp_TT.Controls.Add(this.lbl_email);
            this.grp_TT.Controls.Add(this.lbl_SDT);
            this.grp_TT.Controls.Add(this.lbl_TenNV);
            this.grp_TT.Controls.Add(this.lbl_MaNV);
            this.grp_TT.Location = new System.Drawing.Point(601, 50);
            this.grp_TT.Name = "grp_TT";
            this.grp_TT.Size = new System.Drawing.Size(289, 417);
            this.grp_TT.TabIndex = 2;
            this.grp_TT.TabStop = false;
            this.grp_TT.Text = "Thông tin:";
            // 
            // grp_
            // 
            this.grp_.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_.Controls.Add(this.txt_TK);
            this.grp_.Controls.Add(this.lbl_TK);
            this.grp_.Location = new System.Drawing.Point(601, 473);
            this.grp_.Name = "grp_";
            this.grp_.Size = new System.Drawing.Size(289, 69);
            this.grp_.TabIndex = 3;
            this.grp_.TabStop = false;
            this.grp_.Text = "Tìm kiếm";
            // 
            // grp_ThanhXuLy
            // 
            this.grp_ThanhXuLy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_ThanhXuLy.Controls.Add(this.btn_Luu);
            this.grp_ThanhXuLy.Controls.Add(this.btn_Xoa);
            this.grp_ThanhXuLy.Controls.Add(this.btn_Sua);
            this.grp_ThanhXuLy.Controls.Add(this.btn_Them);
            this.grp_ThanhXuLy.Location = new System.Drawing.Point(24, 50);
            this.grp_ThanhXuLy.Name = "grp_ThanhXuLy";
            this.grp_ThanhXuLy.Size = new System.Drawing.Size(571, 170);
            this.grp_ThanhXuLy.TabIndex = 4;
            this.grp_ThanhXuLy.TabStop = false;
            this.grp_ThanhXuLy.Text = "Chức Năng";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Title.Location = new System.Drawing.Point(324, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(300, 31);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "Danh Sách Nhân Viên";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(48, 188);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(78, 13);
            this.lbl_MaNV.TabIndex = 6;
            this.lbl_MaNV.Text = "Mã Nhân Viên:";
            // 
            // lbl_TenNV
            // 
            this.lbl_TenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TenNV.AutoSize = true;
            this.lbl_TenNV.Location = new System.Drawing.Point(48, 234);
            this.lbl_TenNV.Name = "lbl_TenNV";
            this.lbl_TenNV.Size = new System.Drawing.Size(46, 13);
            this.lbl_TenNV.TabIndex = 7;
            this.lbl_TenNV.Text = "Họ Tên:";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Location = new System.Drawing.Point(48, 280);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(78, 13);
            this.lbl_SDT.TabIndex = 8;
            this.lbl_SDT.Text = "Số Điện Thoại:";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(48, 326);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "Email:";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaNV.Location = new System.Drawing.Point(131, 188);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(115, 20);
            this.txt_MaNV.TabIndex = 10;
            // 
            // txt_HoTenNV
            // 
            this.txt_HoTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HoTenNV.Location = new System.Drawing.Point(131, 233);
            this.txt_HoTenNV.Name = "txt_HoTenNV";
            this.txt_HoTenNV.Size = new System.Drawing.Size(115, 20);
            this.txt_HoTenNV.TabIndex = 11;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SDT.Location = new System.Drawing.Point(131, 278);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(115, 20);
            this.txt_SDT.TabIndex = 12;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.Location = new System.Drawing.Point(131, 323);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(115, 20);
            this.txt_email.TabIndex = 13;
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Them.AutoSize = true;
            this.btn_Them.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_Them.FlatAppearance.BorderSize = 2;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Navy;
            this.btn_Them.Location = new System.Drawing.Point(149, 48);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(88, 45);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sua.AutoSize = true;
            this.btn_Sua.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_Sua.FlatAppearance.BorderSize = 2;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Purple;
            this.btn_Sua.Location = new System.Drawing.Point(149, 106);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(88, 45);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Xoa.AutoSize = true;
            this.btn_Xoa.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_Xoa.FlatAppearance.BorderSize = 2;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Xoa.Location = new System.Drawing.Point(306, 48);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(88, 45);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Luu.AutoSize = true;
            this.btn_Luu.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_Luu.FlatAppearance.BorderSize = 2;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.Navy;
            this.btn_Luu.Location = new System.Drawing.Point(306, 106);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(88, 45);
            this.btn_Luu.TabIndex = 3;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            // 
            // lbl_TK
            // 
            this.lbl_TK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TK.AutoSize = true;
            this.lbl_TK.Location = new System.Drawing.Point(48, 29);
            this.lbl_TK.Name = "lbl_TK";
            this.lbl_TK.Size = new System.Drawing.Size(29, 13);
            this.lbl_TK.TabIndex = 0;
            this.lbl_TK.Text = "SĐT";
            // 
            // txt_TK
            // 
            this.txt_TK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TK.Location = new System.Drawing.Point(131, 26);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(115, 20);
            this.txt_TK.TabIndex = 1;
            // 
            // ptb_NV
            // 
            this.ptb_NV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptb_NV.Image = ((System.Drawing.Image)(resources.GetObject("ptb_NV.Image")));
            this.ptb_NV.Location = new System.Drawing.Point(51, 19);
            this.ptb_NV.Name = "ptb_NV";
            this.ptb_NV.Size = new System.Drawing.Size(195, 151);
            this.ptb_NV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_NV.TabIndex = 14;
            this.ptb_NV.TabStop = false;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 560);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grp_ThanhXuLy);
            this.Controls.Add(this.grp_);
            this.Controls.Add(this.grp_TT);
            this.Controls.Add(this.dgv_NV);
            this.Controls.Add(this.grp_dgv);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).EndInit();
            this.grp_TT.ResumeLayout(false);
            this.grp_TT.PerformLayout();
            this.grp_.ResumeLayout(false);
            this.grp_.PerformLayout();
            this.grp_ThanhXuLy.ResumeLayout(false);
            this.grp_ThanhXuLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_NV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_dgv;
        private System.Windows.Forms.DataGridView dgv_NV;
        private System.Windows.Forms.GroupBox grp_TT;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_HoTenNV;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.Label lbl_TenNV;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.GroupBox grp_;
        private System.Windows.Forms.GroupBox grp_ThanhXuLy;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.Label lbl_TK;
        private System.Windows.Forms.PictureBox ptb_NV;
    }
}