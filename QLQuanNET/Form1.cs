using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanNET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void OpenChildForm(Form Childform)//Form con trong form cha
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;//Loại bỏ viền
            Childform.Dock = DockStyle.Fill;
            panel_content.Controls.Add(Childform);
            panel_content.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();
        }
        private void btn_NV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien());
            lbl_home.Text = btn_NV.Text;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lbl_home.Text = "Home";
        }

        private void btn_Thietbi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThietBi());
            lbl_home.Text = btn_Thietbi.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCTMayTinh());
            lbl_home.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKH());
            lbl_home.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThanhToan());
            lbl_home.Text = button3.Text;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormThanhToan());
            lbl_home.Text = button3.Text;
        }
    }
}
