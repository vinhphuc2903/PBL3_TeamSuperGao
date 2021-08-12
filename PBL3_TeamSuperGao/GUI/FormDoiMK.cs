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
    public partial class FormDoiMK : Form
    {
        public delegate void mydel();
        public mydel Sent_form_ { get; set; }
        public FormDoiMK(string user)
        {
            InitializeComponent();
            txtUser.Text = user;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ThisClose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BLL_QLTaiKhoan.Instance.BLL_isTrueLogin(txtUser.Text, txtOldPass.Text))
            {
                BLL_QLTaiKhoan.Instance.BLL_EditTK(txtUser.Text, txtNewPass.Text);
                ThisClose();
            }
            else
                MessageBox.Show("Bạn đã nhập sai mật khẩu");
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ThisClose();
        }
        void ThisClose()
        {
            Sent_form_();
            this.Close();
        }
    }
}
