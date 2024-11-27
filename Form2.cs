using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tạo 1 dòng dữ liệu (ListviewItem)
            ListViewItem it = new ListViewItem(txt_lastname.Text);
            //thêm các cột còn lại vào dòng it
            it.SubItems.Add(txt_firstname.Text);
            it.SubItems.Add(txt_phone.Text);
            //đưa dòng dữ liệu lên listview
            Lv_Studen.Items.Add(it); ;
        }
        //bắt sự kiện chọn trên listview (Selected
        private void Lv_Studen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lấy dữ liệu từ dòng lên textbox
            if (Lv_Studen.SelectedItems.Count > 0) // Kiểm tra xem có dòng nào được chọn
            {
                // Lấy dòng được chọn
                ListViewItem selectedItem = Lv_Studen.SelectedItems[0]; 
                txt_lastname.Text = selectedItem.SubItems[0].Text;
                txt_firstname.Text = selectedItem.SubItems[1].Text;
                txt_phone.Text = selectedItem.SubItems[2].Text; 
            }
            else
            {
                txt_lastname.Clear();
                txt_firstname.Clear();
                txt_phone.Clear();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (Lv_Studen.SelectedItems.Count > 0) // Kiểm tra xem có dòng nào được chọn
            {
                Lv_Studen.Items.Remove(Lv_Studen.SelectedItems[0]); // Xóa dòng được chọn
                //cách 2 nhưng nó sẽ khiến bị trống 1 dòng ở giữa
                //ListViewItem selected = Lv_Studen.SelectedItems[0];
                //selected.SubItems.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (Lv_Studen.SelectedItems.Count > 0) // Kiểm tra xem có dòng nào được chọn
            {
                ListViewItem selectedItem = Lv_Studen.SelectedItems[0]; // Lấy dòng được chọn

                // Cập nhật dữ liệu trong dòng với nội dung từ TextBox
                selectedItem.SubItems[0].Text = txt_lastname.Text;
                selectedItem.SubItems[1].Text = txt_firstname.Text;
                selectedItem.SubItems[2].Text = txt_phone.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
