using System;
using PBL3_TeamSuperGao.DTO;
using PBL3_TeamSuperGao.BLL;
using PBL3_TeamSuperGao.GUI;
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
    public partial class Add_Edit : Form
    {
        public Add_Edit(string u)
        {
            InitializeComponent();
            setcbbCV();
            setcbbSortNV();
            ShowNV();
            setcbbDM();
            setcbbSortMon();
            ShowMon();
        }

        public void setcbbCV()
        {
            cboChucVu.Items.Add(new CBBItem
            {
                Text = "All",
                Value = 0
            });
            foreach (ChucVu CV in BLL_QLNV.Instance.GetChucVu_BLL())
            {
                cboChucVu.Items.Add(new CBBItem
                {
                    Text = CV.TenChucVu,
                    Value = CV.IDChucVu
                });
            }
            cboChucVu.SelectedIndex = 0;
        }

        public void setcbbSortNV()
        {
            cboSortNV.Items.Add(new CBBItem { Value = 0, Text = "HoTen" });
            cboSortNV.Items.Add(new CBBItem { Value = 1, Text = "GioiTinh" });
            cboSortNV.Items.Add(new CBBItem { Value = 2, Text = "ChucVu" });
            cboSortNV.SelectedIndex = 0;
        }

        private void btnShowNV_Click(object sender, EventArgs e)
        {
            ShowNV();
        }

        private void ShowNV()
        {
            int ID_ChucVu = ((CBBItem)cboChucVu.Items[cboChucVu.SelectedIndex]).Value;
            BLL_QLNV bll = new BLL_QLNV();
            dvwNV.DataSource = bll.GetListNV_BLL(ID_ChucVu);
            dvwNV.Columns[0].Visible = false;
        }

        private void btnDelNV_Click(object sender, EventArgs e)
        { 
            int ID_NhanVien = Convert.ToInt32(dvwNV.CurrentRow.Cells["IDNhanVien"].Value);
            BLL_QLNV bll = new BLL_QLNV();
            bll.DelNVByID_BLL(ID_NhanVien);
            ShowNV();
        }

        private void AddandEditNV(object sender, EventArgs e)
        {
            if ((Button)sender == btnAddNV)
            {
                int ID_NhanVien = 0;
                Add_EditNV f = new Add_EditNV(ID_NhanVien);
                f.function += new Add_EditNV.Mydel(AddNV);
                f.Show();
            }
            else if ((Button)sender == btnEditNV)
            {
                int ID_NhanVien = Convert.ToInt32(dvwNV.CurrentRow.Cells["IDNhanVien"].Value);
                Add_EditNV f = new Add_EditNV(ID_NhanVien);
                f.function += new Add_EditNV.Mydel(EditNV);
                f.Show();
            }
        }

        private void AddNV(object s)
        {
            NhanVien nv = new NhanVien();
            nv = (NhanVien)s;
            bool status;
            status = BLL_QLNV.Instance.AddNV_BLL(nv);
            if (status == false) MessageBox.Show("Vui long dien du thong tin");
            ShowNV();
        }

        private void EditNV(object s)
        {
            int ID_NhanVien = Convert.ToInt32(dvwNV.CurrentRow.Cells["IDNhanVien"].Value);
            BLL_QLNV.Instance.EditNV_BLL((NhanVien)s, ID_NhanVien);
            ShowNV();
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            int ID_ChucVu = ((CBBItem)cboChucVu.Items[cboChucVu.SelectedIndex]).Value;
            string NameNV = txtSearchNV.Text;
            dvwNV.DataSource = BLL_QLNV.Instance.SearchNVByName_BLL(ID_ChucVu, NameNV);
        }

        private void btnSortNV_Click(object sender, EventArgs e)
        {
            int choice = ((CBBItem)cboSortNV.Items[cboSortNV.SelectedIndex]).Value;
            dvwNV.DataSource = BLL_QLNV.Instance.SortNV_BLL(choice);
        }

        /*-------------------------------------------------------------------*/

        public void setcbbDM()
        {
            cboDanhMuc.Items.Add(new CBBItem
            {
                Text = "All",
                Value = 0
            });
            foreach (DanhMucMon DM in BLL_QLM.Instance.GetDanhMuc_BLL())
            {
                cboDanhMuc.Items.Add(new CBBItem
                {
                    Text = DM.TenDanhMuc,
                    Value = DM.IDDanhMucMon
                });
            }
            cboDanhMuc.SelectedIndex = 0;
        }

        public void setcbbSortMon()
        {
            cboSortMon.Items.Add(new CBBItem { Value = 0, Text = "TenMon" });
            cboSortMon.Items.Add(new CBBItem { Value = 1, Text = "DonGia" });
            cboSortMon.Items.Add(new CBBItem { Value = 2, Text = "DanhMuc" });
            cboSortMon.SelectedIndex = 0;
        }

        private void btnShowMon_Click(object sender, EventArgs e)
        {
            ShowMon();
        }

        private void ShowMon()
        {
            int ID_DanhMuc = ((CBBItem)cboDanhMuc.Items[cboDanhMuc.SelectedIndex]).Value;
            BLL_QLM bll = new BLL_QLM();
            dvwMon.DataSource = bll.GetListMon_BLL(ID_DanhMuc);
            dvwMon.Columns[0].Visible = false;
        }

        private void btnDelMon_Click(object sender, EventArgs e)
        {
            int ID_Mon = Convert.ToInt32(dvwMon.CurrentRow.Cells["IDMon"].Value);
            BLL_QLM bll = new BLL_QLM();
            bll.DelMonByID_BLL(ID_Mon);
            ShowMon();
        }

        private void AddandEditMon(object sender, EventArgs e)
        {
            if ((Button)sender == btnAddMon)
            {
                int ID_Mon = 0;
                Add_EditMon f = new Add_EditMon(ID_Mon);
                f.function += new Add_EditMon.Mydel(AddMon);
                f.Show();
            }
            else if ((Button)sender == btnEditMon)
            {
                int ID_Mon = Convert.ToInt32(dvwMon.CurrentRow.Cells["IDMon"].Value);
                Add_EditMon f = new Add_EditMon(ID_Mon);
                f.function += new Add_EditMon.Mydel(EditMon);
                f.Show();
            }
        }

        private void AddMon(object s)
        {
            Mon m = new Mon();
            m = (Mon)s;
            bool status;
            status = BLL_QLM.Instance.AddMon_BLL(m);
            if (status == false) MessageBox.Show("Vui long dien du thong tin");
            ShowMon();
        }

        private void EditMon(object s)
        {
            int ID_Mon = Convert.ToInt32(dvwMon.CurrentRow.Cells["IDMon"].Value);
            BLL_QLM.Instance.EditMon_BLL((Mon)s, ID_Mon);
            ShowMon();
        }

        private void btnSearchMon_Click(object sender, EventArgs e)
        {
            int ID_DanhMuc = ((CBBItem)cboDanhMuc.Items[cboDanhMuc.SelectedIndex]).Value;
            string NameMon = txtSearchMon.Text;
            dvwMon.DataSource = BLL_QLM.Instance.SearchMonByName_BLL(ID_DanhMuc, NameMon);
        }

        private void btnSortMon_Click(object sender, EventArgs e)
        {
            int choice = ((CBBItem)cboSortMon.Items[cboSortMon.SelectedIndex]).Value;
            dvwMon.DataSource = BLL_QLM.Instance.SortMon_BLL(choice);
        }
    }
}
