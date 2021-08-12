using System;
using PBL3_TeamSuperGao.BLL;
using PBL3_TeamSuperGao.DTO;
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
    public partial class Add_EditMon : Form
    {
        public delegate void Mydel(object s);
        public Mydel function;

        public Add_EditMon(int ID_Mon)
        {
            InitializeComponent();
            setcbbDM();
            cboDanhMuc.SelectedIndex = 0;
            LoadData(ID_Mon);
        }

        public void setcbbDM()
        {
            foreach (DanhMucMon dm in BLL_QLM.Instance.GetDanhMuc_BLL())
            {
                cboDanhMuc.Items.Add(new CBBItem
                {
                    Text = dm.TenDanhMuc,
                    Value = dm.IDDanhMucMon
                });
            }
        }

        private Mon GetData()
        {
            Mon m = new Mon
            {
                TenMon = txtTenMon.Text,
                DonGia = Convert.ToDouble(txtDonGia.Text),
                IDDanhMucMon = ((CBBItem)cboDanhMuc.SelectedItem).Value
            };
            return m;
        }

        private void LoadData(int ID_Mon)
        {
            if (ID_Mon != 0)
            {
                Mon m = new Mon();
                m = BLL_QLM.Instance.GetMonByID_BLL(ID_Mon);
                txtTenMon.Text = m.TenMon;
                txtDonGia.Text = m.DonGia.ToString();
                cboDanhMuc.SelectedIndex = Convert.ToInt32(m.IDDanhMucMon) - 1;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTenMon.Text == "" || txtDonGia.Text == "")
                MessageBox.Show("Vui long dien du thong tin");
            else
            {
                function(GetData());
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
