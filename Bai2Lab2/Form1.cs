using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Khoi tao o dau dong
            ListViewItem item = new ListViewItem(txtTenLop.Text);

            //them cac cot phia sau
            item.SubItems.Add(txtBoMon.Text);
            item.SubItems.Add(txtSoLuong.Text);

            //add item vao list view
            lstSinhVien.Items.Add(item);

            //ListViewItem a = lstSinhVien.SelectedItems[0];
            //string tenLop = a.SubItems[0].Text;
            //string boMon = a.SubItems[1].Text;
            //string soLuong = a.SubItems[2].Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while(lstSinhVien.SelectedItems.Count > 0)
            {
                lstSinhVien.Items.RemoveAt(lstSinhVien.SelectedItems[0].Index);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstSinhVien.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
