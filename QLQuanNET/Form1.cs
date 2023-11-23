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
        private Button thisButton;//khoi tao nut
        private Random rd;
        private int temp;
        private Form currentFormChild;
        public Form1()
        {
            InitializeComponent();
            CustomDesign();
            rd = new Random();
        }

        private Color SelectThemeColor() //random chon mau
        {
            int index = rd.Next(Theme.ColorList.Count);
            while (temp == index)//neu temp = mau tren
            {
                index = rd.Next(Theme.ColorList.Count); // index ++
            }
            temp = index;//neu temp != index thi cho = nhau
            string color = Theme.ColorList[index];//chuoi mau = mang chuoi theme
            return ColorTranslator.FromHtml(color);//tra ve color.fromhtml(gia tri rgb so mau)
        }

        private void ActivateButton(object btnSender)//hien mau nut bam
        {
            if (btnSender != null)//neu btn khac null
            {
                if (thisButton != (Button)btnSender)//neu nut hien tai khac nut vua bam
                {
                    DisableButton();//Xoa mau o nut
                    Color color = SelectThemeColor(); //Mau nut = ham goi mau
                    thisButton = (Button)btnSender; // nut vua bam thanh nut hien tai
                    thisButton.BackColor = color;//thay doi mau
                    thisButton.ForeColor = Color.White;//thay doi kieu chu
                    thisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //thay doi font
                    //Thay doi mau panel title
                    panel_titlebar.BackColor = color;
                    panel_logo.BackColor = Theme.ChangeColorBrightness(color, -0.3);
                    //Theme.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()//Xoa mau nut
        {
            foreach (Control previousBtn in panel_Menu.Controls)//loop cac bien control truoc do trong panel_menu
            {
                if (previousBtn.GetType() == typeof(Button))//neu bien la kieu button trong panel
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);//tra ve mau
                    previousBtn.ForeColor = Color.Gainsboro;//tra ve kieu chu
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //tra ve font
                }
            }
            foreach (Control previousBtn in panel_submenuDSMT.Controls)//tuong tu panel_menu dung cho panel_sub
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(35, 32, 39);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            foreach (Control previousBtn in panel_submenuHD.Controls)//tuong tu panel_menu dung cho panel_sub
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(35, 32, 39);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

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
            //lbl_title.Text = Childform.Text;
        }
        
        private void CustomDesign() // Mac dinh An submenu
        {
            panel_submenuDSMT.Visible = false;
            panel_submenuHD.Visible = false;
        }

        private void HideSubMenu()//An subMenu neu an vao 1 submenu khac -- optional
        {
            if(panel_submenuDSMT.Visible == true) 
            {
                panel_submenuDSMT.Visible = false;
            }
            if(panel_submenuHD.Visible == true)
            {
                panel_submenuHD.Visible = false;
            }
        }

        private void DisplaySubMenu(Panel SubmenuName)//Hien submenu
        {
            if(SubmenuName.Visible == false)
            {
                SubmenuName.Visible = true;
            }
            else
            {
                SubmenuName.Visible = false;
                //HideSubMenu();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplaySubMenu(panel_submenuDSMT);
            ActivateButton(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DisplaySubMenu(panel_submenuHD);
            ActivateButton(sender);
        }
        #region SubmenuDSMT 
        private void button2_Click(object sender, EventArgs e)
        {
            HideSubMenu(); 
            ActivateButton(sender);
            OpenChildForm(new FormCTMayTinh());
            lbl_title.Text = "QUẢN LÝ MÁY TÍNH";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActivateButton(sender);
        }
        #endregion end
        #region SubmenuHD 
        private void button8_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActivateButton(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActivateButton(sender);
            OpenChildForm(new FormThanhToan());
            lbl_title.Text = "DANH SÁCH HÓA ĐƠN";
        }
        #endregion end

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lbl_title.Text = "HOME";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormKH());
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormNhanVien());
            lbl_title.Text = "QUẢN LÝ NHÂN VIÊN";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dt =MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}