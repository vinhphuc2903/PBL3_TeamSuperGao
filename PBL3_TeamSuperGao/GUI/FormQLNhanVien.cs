using PBL3_TeamSuperGao.BLL;
using PBL3_TeamSuperGao.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_TeamSuperGao.GUI
{
    public partial class FormQLNhanVien : Form
    {
        public FormQLNhanVien()
        {
            InitializeComponent();
            SetTBCV();
        }
        public void SetTBCV()
        {
            DTDoAn st = new DTDoAn();
            foreach(ChucVu i in st.ChucVu)
            {
                comboBoxCV.Items.Add(new CBBITem{ Value = Convert.ToInt32(i.IDChucVu), Text = i.TenChucVu});
            }
        }
        //get cbb thong ke
        public void GetCBBThongKe()
        {
            comboBoxThongKe.Items.Add(new CBBITem { Value = 1, Text = "Thống kê theo ngày" });
            comboBoxThongKe.Items.Add(new CBBITem { Value = 2, Text = "Thống kê theo tháng" });
            comboBoxThongKe.Items.Add(new CBBITem { Value = 3, Text = "Thống kê theo năm" });
            comboBoxThongKe.Items.Add(new CBBITem { Value = 4, Text = "Thống kê theo món được gọi nhiều nhất" });
        }
        /// <summary>
        /// thong ke theo ngay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ThongKeTheoNgay()
        {
            DTDoAn st = new DTDoAn();
            //ChiTietHoaDon u = st.ChiTietHoaDons.Where(p => Convert.ToInt32( p.NgayGioThanhToan.Value.Date) < Convert.ToInt32(dateTimePicker2.Value.Date));

        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_QLNhanVien.Instance.SwapNV(BLL_QLNhanVien.Instance.GetAllNV());
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_QLNhanVien.Instance.SwapNV(BLL_QLNhanVien.Instance.SearchForName(((CBBITem)comboBoxCV.SelectedItem).Value,textBoxTen.Text));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            BLL_QLNhanVien.Instance.DeleteHoten(index);
            dataGridView1.DataSource = BLL_QLNhanVien.Instance.SwapNV(BLL_QLNhanVien.Instance.GetAllNV()); 
            dataGridView1.Columns[0].Visible = false;
        }
        //thoat chuong trinh
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            this.Close();
        }


    }
}
