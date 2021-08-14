using PBL3_TeamSuperGao.BLL;
using PBL3_TeamSuperGao.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_TeamSuperGao.GUI
{
    public partial class Form1 : Form
    {
        public delegate void mydel();
        public mydel Sent_form_ { get; set; }
        public Form1()
        {
            InitializeComponent();
            SetCBBThongKe();
            setcbbCV();
            setcbbSortNV();
            ShowNV();
            setcbbDM();
            setcbbSortMon();
            ShowMon();
            HandleThongKeHoaDon();
            Show_dtgvTK();
            SetCBB1();
        }

        // Sett cbb to handle thong ke
        public void SetCBBThongKe()
        {
            cbbThongKe.Items.AddRange(new CBBItem[] { 
                new CBBItem{Value = 0,Text = "ThongKeHoaDon"},
                new CBBItem{Value = 1,Text = "ThongKeDoanhThu"},
                new CBBItem{Value = 2,Text = "ThongKeMon"},
            });
            cbbThongKe.SelectedIndex = 0;
        }
                                        //MODULE

        ////////////////////////////////////////////////////////////////////
        //THONG KE
        // Xu Ly su kien thong ke di kem voi CBB
        public void ThongKe(object sender,EventArgs e)
        {
            switch (((CBBItem)cbbThongKe.Items[cbbThongKe.SelectedIndex]).Value)
            {
                case 0:
                    dtvThongKe.DataSource = null;
                    HandleThongKeHoaDon();
                    txtTongDoanhThu.Text = TongDoanhThu().ToString();
                    break;
                case 1:
                    HandleThongKeDoanhThu();
                    txtTongDoanhThu.Text = TongDoanhThu().ToString();
                    break;
                case 2:
                    HandleThongKeMon();
                    txtTongDoanhThu.Text = "";
                    break;
                default:
                    break;
            }
        }
        //
        public double TongDoanhThu()
        {
            double TongDoanhThu = 0;
            for(int i = 0; i< dtvThongKe.Rows.Count; i++)
            {
                TongDoanhThu += Convert.ToDouble(dtvThongKe.Rows[i].Cells["TongTien"].Value);
            }
            return TongDoanhThu;
        }
        // Xu ly su kien thong ke mon
        private void HandleThongKeMon()
        {
            dtvThongKe.DataSource = BLL_ThongKe.Instance.BLL_ThongKeMon(dtmOrg.Value, dtmDes.Value);
            dtvThongKe.Columns[0].Visible = false;
            dtvThongKe.Columns[4].Visible = false;
        }
        
        private void HandleThongKeHoaDon()
        {
            dtvThongKe.DataSource = BLL_ThongKe.Instance.ThongKeHoaDon(dtmOrg.Value, dtmDes.Value);
        }
        // Xu ly su kien thong ke Doanh Thu
        private void HandleThongKeDoanhThu()
        {
            dtvThongKe.DataSource = BLL_ThongKe.Instance.BLL_ThongKeDoanhThu(dtmOrg.Value, dtmDes.Value);
        }

        /*----------------------------------------------------------------*/
        ////////////////////////////////////////////////////////////////
        // MODULE
        // QUAN LY TAI KHOAN 

        // reset textbox
        public void SetCBB1()
        {
            foreach(NhanVien i in BLL_QLNhanVien.Instance.GetAllNV())
            {
                comboBox1.Items.Add(new CBBItem { Value = i.IDNhanVien,Text = i.HoTen});
            }
        }
        public void reset()
        {
            txtReFill.Text = "";
            txtMatKhauTK.Text = "";
            txtTenTK.Text = "";
        }
        // Xử lý Exception Null
        static void ProcessString(string s1, string s2, string s3)
        {
            if (s1 == "" || s2 == "" || s3 == "")
            {
                throw new ArgumentNullException();
            }
        }
        //show list TK on Dtgv TaiKhoan
        public void Show_dtgvTK()
        {
            dtgvTaiKhoan.DataSource = BLL_QLTaiKhoan.Instance.BLL_ShowTK();
            dtgvTaiKhoan.Columns[0].Visible = false;
            dtgvTaiKhoan.Columns[3].Visible = false;
        }
        // kiem tra mat khau nhap lai co trung voi mat khau khong
        private void txtReFill_TextChanged(object sender, EventArgs e)
        {
            if (txtReFill.Text != txtMatKhauTK.Text && txtReFill.Text != "")
            {
                lblCheck.Text = "Mat khau khong khop!";
                lblCheck.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblCheck.ForeColor = System.Drawing.Color.White;
            }

        }
        // handle change selection click on dtgv 
        private void dtgvTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            txtTenTK.Text = dtgvTaiKhoan.CurrentRow.Cells["UserName"].Value.ToString();
            txtMatKhauTK.Text = dtgvTaiKhoan.CurrentRow.Cells["PassWord"].Value.ToString();
            int IDTK = Convert.ToInt32(dtgvTaiKhoan.CurrentRow.Cells["IDTaiKhoan"].Value);
            int index = -1;
            int IDNV = -1;
            foreach(NhanVien i in BLL_QLNhanVien.Instance.GetAllNV())
            {
                if (i.IDTaiKhoan == IDTK) IDNV = i.IDNhanVien;
            }
            for(int i =0;i< BLL_QLNhanVien.Instance.GetAllNV().Count(); i++)
            {
                if(((CBBItem)comboBox1.Items[i]).Value == IDNV)
                {
                    index = i;
                }
            }
            comboBox1.SelectedIndex = index;
        }
        // Kiem tra user ton tai chua
        public bool Check_isExistUser(string str)
        {
            foreach(var i in BLL_QLTaiKhoan.Instance.BLL_ShowTK())
            {
                if (String.Compare(str.Trim(),i.UserName.Trim(),true) == 0) return true;
            }
            return false;
        }
        // handle event add TK and edit tk
        private void btnAddTK_Click(object sender, EventArgs eva)
        {
            try
            {
                ProcessString(txtTenTK.Text, txtMatKhauTK.Text,txtTenTK.Text);
                if ((Button)sender == btnAddTK)
                {
                    if (txtReFill.Text == txtMatKhauTK.Text && Check_isExistUser(txtTenTK.Text) == false)
                    {
                        int IDTK = BLL_QLTaiKhoan.Instance.BLL_AddTK(txtTenTK.Text, txtMatKhauTK.Text);
                        BLL_QLNhanVien.Instance.UpdateIDTK(IDTK,((CBBItem)comboBox1.Items[comboBox1.SelectedIndex]).Value);
                        MessageBox.Show("Them tai khoan thanh cong!");
                        reset();
                    }
                    else if (Check_isExistUser(txtTenTK.Text) == true)
                    {
                        MessageBox.Show("Da ton tai tai khoan!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Mat khau khong trung khop!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                if((Button)sender == btnEditTK)
                {
                    if (txtReFill.Text == txtMatKhauTK.Text && Check_isExistUser(txtTenTK.Text) == true)
                    {
                        int ID = Convert.ToInt32(dtgvTaiKhoan.CurrentRow.Cells["IDTaiKhoan"].Value);
                        BLL_QLTaiKhoan.Instance.BLL_EditTK(txtTenTK.Text, txtMatKhauTK.Text);
                        BLL_QLNhanVien.Instance.UpdateIDTK(ID, ((CBBItem)comboBox1.Items[comboBox1.SelectedIndex]).Value);
                        MessageBox.Show("Chinh sua thanh cong!");
                        reset();
                    }
                    else if (Check_isExistUser(txtTenTK.Text) == false)
                    {
                        MessageBox.Show("Khong ton tai tai khoan!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Mat khau khong trung khop!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // handle Show TK on Dtgv TaiKhoan
        private void btnShowTK_Click(object sender, EventArgs e)
        {
            Show_dtgvTK();
        }
        // handle event Delete Tai khoan
        private void BtnDelTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvTaiKhoan.CurrentRow.Selected == true)
                {
                    BLL_QLTaiKhoan.Instance.BLL_DeleteTK(Convert.ToInt32(dtgvTaiKhoan.CurrentRow.Cells["IDTaiKhoan"].Value));
                    Show_dtgvTK();
                    reset();
                }
            }
            catch(Exception et)
            {
                MessageBox.Show(et.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // handle event button reset
        private void btnResetTK_Click(object sender, EventArgs e)
        {
            reset();
        }

        /*--------------------------------------------------------------------*/
        // QUAN LY NHAN VIEN, MON
        //////////////////////////////////////////////////////////////////
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
            if (bll.Check(ID_NhanVien) == true) MessageBox.Show("Khong the xoa nhan vien nay");
            else bll.DelNVByID_BLL(ID_NhanVien);
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
            BLL_QLNV.Instance.AddNV_BLL(nv);
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
            int ID_ChucVu = ((CBBItem)cboChucVu.Items[cboChucVu.SelectedIndex]).Value;
            dvwNV.DataSource = BLL_QLNV.Instance.SortNV_BLL(ID_ChucVu, choice);
        }

        /*-------------------------------------------------------------------*/
        // QUAN LY MON
        //
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
            dvwMon.Columns[3].Visible = false;
        }

        private void btnDelMon_Click(object sender, EventArgs e)
        {
            int ID_Mon = Convert.ToInt32(dvwMon.CurrentRow.Cells["IDMon"].Value);
            BLL_QLM bll = new BLL_QLM();
            if (bll.Check(ID_Mon) == true) MessageBox.Show("Khong the xoa nhan vien nay");
            else bll.DelMonByID_BLL(ID_Mon);
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
            BLL_QLM.Instance.AddMon_BLL(m);
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
            int ID_DanhMuc = ((CBBItem)cboDanhMuc.Items[cboDanhMuc.SelectedIndex]).Value;
            dvwMon.DataSource = BLL_QLM.Instance.SortMon_BLL(ID_DanhMuc, choice);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sent_form_();
            this.Close();
        }
    }
}
