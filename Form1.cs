using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

      

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.AntiqueWhite;
        }

        private void frmDangKy_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.Aqua;
        }

        private void frmDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult res = MessageBox.Show("Bạn có muốn thoat", "Tiêu đề",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (res == DialogResult.Yes)
            //{
            //    e.Cancel = false;
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            lbl_HoTen.Text = txt_Ho.Text + " ";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoat", "Tiêu đề",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_HoTen.Text = txt_Ten.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_HoTen.Text = txt_Ho.Text + " " + txt_Ten.Text;
        }

        private void lbl_HoTen_DoubleClick(object sender, EventArgs e)
        {
            lbl_HoTen.Text = " ";
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            String res = txt_Ho.Text + " " + txt_Ten.Text;
            String gt = rad_Nam.Checked ? "Nam" : "Nữ";
            String st = "";
            if (chk_Dulich.Checked)
            {
                st += chk_Dulich.Text + " ";
            }
            if (chk_Thethao.Checked)
            {
                st += chk_Thethao.Text + " ";
            }
            if (chk_Phim.Checked)
            {
                st += chk_Phim.Text + " ";
            }
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            MessageBox.Show("Họ Tên: " + res + " Giới tính: " + gt + " Ngày Sinh: " 
                + dateTimePicker1.Text + " Sở Thích: " + st);
        }
    }
}
