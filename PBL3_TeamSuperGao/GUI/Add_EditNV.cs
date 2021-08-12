using System;
using PBL3_TeamSuperGao.DTO;
using PBL3_TeamSuperGao.BLL;
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
    public partial class Add_EditNV : Form
    {
        public delegate void Mydel(object s);
        public Mydel function;

        public Add_EditNV(int ID_NhanVien)
        {
            InitializeComponent();
            setcbbCV();
            cboChucVu.SelectedIndex = 0;
            rdoMale.Checked = true;
            LoadData(ID_NhanVien);
        }

        public void setcbbCV()
        {
            foreach (ChucVu lsh in BLL_QLNV.Instance.GetChucVu_BLL())
            {
                cboChucVu.Items.Add(new CBBItem
                {
                    Text = lsh.TenChucVu,
                    Value = lsh.IDChucVu
                });
            }
        }

        private NhanVien GetData()
        {
            Boolean gen;
            if (rdoMale.Checked == true) gen = false;
            else gen = true;
            NhanVien nv = new NhanVien
            {
                HoTen = txtHoTen.Text,
                DanToc = txtDanToc.Text,
                GioiTinh = gen,
                SoDienThoai = txtSDT.Text,
                QueQuan = txtQueQuan.Text,
                NgaySinh = Convert.ToDateTime(dtmNS.Value),
                TrinhDoHocVan = txtHocVan.Text,
                IDChucVu = ((CBBItem)cboChucVu.SelectedItem).Value
            };
            return nv;
        }

        private void LoadData(int ID_NhanVien)
        {
            if (ID_NhanVien != 0)
            {
                NhanVien nv = new NhanVien();
                nv = BLL_QLNV.Instance.GetNVByID_BLL(ID_NhanVien);
                txtHoTen.Text = nv.HoTen;
                txtDanToc.Text = nv.DanToc;
                if (nv.GioiTinh == true) rdoFemale.Checked = true;
                else rdoMale.Checked = true;
                txtSDT.Text = nv.SoDienThoai;
                txtQueQuan.Text = nv.QueQuan;
                dtmNS.Value = Convert.ToDateTime(nv.NgaySinh);
                txtHocVan.Text = nv.TrinhDoHocVan;
                cboChucVu.SelectedIndex = Convert.ToInt32(nv.IDChucVu) - 1;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtDanToc.Text == "" || txtHocVan.Text == "" || txtSDT.Text == "" || txtQueQuan.Text == "")
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
