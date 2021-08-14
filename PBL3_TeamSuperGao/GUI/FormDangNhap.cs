using PBL3_TeamSuperGao.BLL;
using PBL3_TeamSuperGao.GUI;
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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDoiMK st = new FormDoiMK(txtUserName.Text);
            st.Sent_form_ += new FormDoiMK.mydel(ShowForm);
            this.Hide();
            st.ShowDialog();
        }

        private void Handle_btnDangNhap(object sender, EventArgs e)
        {
            DangNhap();
        }
        void DangNhap()
        {
            if (BLL_QLTaiKhoan.Instance.BLL_isTrueLogin(txtUserName.Text, txtPassword.Text) == false)
                MessageBox.Show("Sai Tài khoản hoặc mật khẩu, vui lòng nhập lại");
            else
            {
                CAFEVIEW st = new CAFEVIEW();
                st.SendForm_ += new CAFEVIEW.mydel(ShowForm);
                //this.Hide();
                //lay ma nhan vien 
                st.t = BLL_QLNhanVien.Instance.GetIDNVForIDTK(BLL_QLTaiKhoan.Instance.GetIDTK(txtUserName.Text, txtPassword.Text));
                //st.ShowDialog();
                this.Visible = false;
                st.ShowDialog();
                this.Close();
            }
            txtPassword.Text = "";
        }
        private void Keypress_enter(object sender,KeyEventArgs kp)
        {
            if(kp.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }
        void ShowForm()
        {
            this.Show();
            txtPassword.Text = "";
        }

    }
}
