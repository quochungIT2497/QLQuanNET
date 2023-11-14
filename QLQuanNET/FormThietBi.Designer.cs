namespace QLQuanNET
{
    partial class FormThietBi
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.roundButton4 = new QLQuanNET.RoundButton();
            this.grp_dgv = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grp_TT = new System.Windows.Forms.GroupBox();
            this.comboBox_TenTB = new System.Windows.Forms.ComboBox();
            this.comboBox_MaTB = new System.Windows.Forms.ComboBox();
            this.txt_tinhtrang = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.lbl_TinhTrang = new System.Windows.Forms.Label();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.lbl_TenTB = new System.Windows.Forms.Label();
            this.lbl_MaTB = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.roundButton1 = new QLQuanNET.RoundButton();
            this.roundButton3 = new QLQuanNET.RoundButton();
            this.roundButton2 = new QLQuanNET.RoundButton();
            this.panel_main.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grp_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_TT.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.groupBox4);
            this.panel_main.Controls.Add(this.roundButton4);
            this.panel_main.Controls.Add(this.grp_dgv);
            this.panel_main.Controls.Add(this.grp_TT);
            this.panel_main.Controls.Add(this.lbl_Title);
            this.panel_main.Controls.Add(this.groupBox3);
            this.panel_main.Location = new System.Drawing.Point(38, 24);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(827, 505);
            this.panel_main.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(598, 393);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên thiết bị:";
            // 
            // roundButton4
            // 
            this.roundButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundButton4.BorderColor = System.Drawing.Color.Silver;
            this.roundButton4.ButtonColor = System.Drawing.Color.Purple;
            this.roundButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton4.Location = new System.Drawing.Point(444, 427);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundButton4.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundButton4.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundButton4.Size = new System.Drawing.Size(96, 50);
            this.roundButton4.TabIndex = 6;
            this.roundButton4.Text = "Lưu";
            this.roundButton4.TextColor = System.Drawing.Color.White;
            this.roundButton4.UseVisualStyleBackColor = true;
            // 
            // grp_dgv
            // 
            this.grp_dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_dgv.Controls.Add(this.dataGridView1);
            this.grp_dgv.Location = new System.Drawing.Point(29, 197);
            this.grp_dgv.Name = "grp_dgv";
            this.grp_dgv.Size = new System.Drawing.Size(781, 190);
            this.grp_dgv.TabIndex = 2;
            this.grp_dgv.TabStop = false;
            this.grp_dgv.Text = "Danh Sách:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(781, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // grp_TT
            // 
            this.grp_TT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_TT.Controls.Add(this.comboBox_TenTB);
            this.grp_TT.Controls.Add(this.comboBox_MaTB);
            this.grp_TT.Controls.Add(this.txt_tinhtrang);
            this.grp_TT.Controls.Add(this.txt_DonGia);
            this.grp_TT.Controls.Add(this.lbl_TinhTrang);
            this.grp_TT.Controls.Add(this.lbl_DonGia);
            this.grp_TT.Controls.Add(this.lbl_TenTB);
            this.grp_TT.Controls.Add(this.lbl_MaTB);
            this.grp_TT.Location = new System.Drawing.Point(29, 52);
            this.grp_TT.Name = "grp_TT";
            this.grp_TT.Size = new System.Drawing.Size(781, 139);
            this.grp_TT.TabIndex = 1;
            this.grp_TT.TabStop = false;
            this.grp_TT.Text = "Thông tin";
            // 
            // comboBox_TenTB
            // 
            this.comboBox_TenTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_TenTB.FormattingEnabled = true;
            this.comboBox_TenTB.Location = new System.Drawing.Point(129, 80);
            this.comboBox_TenTB.Name = "comboBox_TenTB";
            this.comboBox_TenTB.Size = new System.Drawing.Size(146, 21);
            this.comboBox_TenTB.TabIndex = 6;
            // 
            // comboBox_MaTB
            // 
            this.comboBox_MaTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_MaTB.FormattingEnabled = true;
            this.comboBox_MaTB.Location = new System.Drawing.Point(129, 36);
            this.comboBox_MaTB.Name = "comboBox_MaTB";
            this.comboBox_MaTB.Size = new System.Drawing.Size(146, 21);
            this.comboBox_MaTB.TabIndex = 2;
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tinhtrang.Location = new System.Drawing.Point(529, 80);
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.Size = new System.Drawing.Size(146, 20);
            this.txt_tinhtrang.TabIndex = 5;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DonGia.Location = new System.Drawing.Point(529, 36);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(146, 20);
            this.txt_DonGia.TabIndex = 4;
            // 
            // lbl_TinhTrang
            // 
            this.lbl_TinhTrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TinhTrang.AutoSize = true;
            this.lbl_TinhTrang.Location = new System.Drawing.Point(465, 83);
            this.lbl_TinhTrang.Name = "lbl_TinhTrang";
            this.lbl_TinhTrang.Size = new System.Drawing.Size(58, 13);
            this.lbl_TinhTrang.TabIndex = 3;
            this.lbl_TinhTrang.Text = "Tình trạng:";
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Location = new System.Drawing.Point(465, 36);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(47, 13);
            this.lbl_DonGia.TabIndex = 2;
            this.lbl_DonGia.Text = "Đơn giá:";
            // 
            // lbl_TenTB
            // 
            this.lbl_TenTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TenTB.AutoSize = true;
            this.lbl_TenTB.Location = new System.Drawing.Point(60, 83);
            this.lbl_TenTB.Name = "lbl_TenTB";
            this.lbl_TenTB.Size = new System.Drawing.Size(63, 13);
            this.lbl_TenTB.TabIndex = 1;
            this.lbl_TenTB.Text = "Tên thiết bị:";
            // 
            // lbl_MaTB
            // 
            this.lbl_MaTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaTB.AutoSize = true;
            this.lbl_MaTB.Location = new System.Drawing.Point(60, 39);
            this.lbl_MaTB.Name = "lbl_MaTB";
            this.lbl_MaTB.Size = new System.Drawing.Size(63, 13);
            this.lbl_MaTB.TabIndex = 0;
            this.lbl_MaTB.Text = "Mã Thiết bị:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Title.Location = new System.Drawing.Point(291, 18);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(262, 31);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Danh Sách Thiết bị";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.roundButton1);
            this.groupBox3.Controls.Add(this.roundButton3);
            this.groupBox3.Controls.Add(this.roundButton2);
            this.groupBox3.Location = new System.Drawing.Point(29, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // roundButton1
            // 
            this.roundButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundButton1.BorderColor = System.Drawing.Color.Silver;
            this.roundButton1.ButtonColor = System.Drawing.Color.Navy;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.Location = new System.Drawing.Point(18, 34);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundButton1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundButton1.Size = new System.Drawing.Size(96, 50);
            this.roundButton1.TabIndex = 3;
            this.roundButton1.Text = "Thêm";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // roundButton3
            // 
            this.roundButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundButton3.BorderColor = System.Drawing.Color.Silver;
            this.roundButton3.ButtonColor = System.Drawing.Color.Teal;
            this.roundButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.Location = new System.Drawing.Point(282, 34);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundButton3.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundButton3.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundButton3.Size = new System.Drawing.Size(96, 50);
            this.roundButton3.TabIndex = 5;
            this.roundButton3.Text = "Xóa";
            this.roundButton3.TextColor = System.Drawing.Color.White;
            this.roundButton3.UseVisualStyleBackColor = true;
            // 
            // roundButton2
            // 
            this.roundButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundButton2.BorderColor = System.Drawing.Color.Silver;
            this.roundButton2.ButtonColor = System.Drawing.Color.Red;
            this.roundButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.Location = new System.Drawing.Point(150, 34);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundButton2.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundButton2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundButton2.Size = new System.Drawing.Size(96, 50);
            this.roundButton2.TabIndex = 4;
            this.roundButton2.Text = "Sửa";
            this.roundButton2.TextColor = System.Drawing.Color.White;
            this.roundButton2.UseVisualStyleBackColor = true;
            // 
            // FormThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(902, 560);
            this.Controls.Add(this.panel_main);
            this.Name = "FormThietBi";
            this.Text = "FormThietBi";
            this.Load += new System.EventHandler(this.FormThietBi_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grp_dgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_TT.ResumeLayout(false);
            this.grp_TT.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grp_TT;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private RoundButton roundButton4;
        private System.Windows.Forms.GroupBox grp_dgv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_TenTB;
        private System.Windows.Forms.ComboBox comboBox_MaTB;
        private System.Windows.Forms.TextBox txt_tinhtrang;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label lbl_TinhTrang;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.Label lbl_TenTB;
        private System.Windows.Forms.Label lbl_MaTB;
        private System.Windows.Forms.GroupBox groupBox3;
        private RoundButton roundButton1;
        private RoundButton roundButton3;
        private RoundButton roundButton2;
    }
}