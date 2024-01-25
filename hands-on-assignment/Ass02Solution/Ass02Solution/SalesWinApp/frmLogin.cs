using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        private readonly IMemberRepository _memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            bool isAdmin = _memberRepository.CheckLoginAdmin(email, password);
            if (isAdmin)
            {
                frmMain frmMain = new frmMain
                {
                    IsAdmin = true
                };
                this.Hide();
                frmMain.ShowDialog();
            }
            else
            {
                Member member = _memberRepository.CheckLogin(email, password);
                if (_memberRepository.CheckLogin(email, password) != null)
                {
                    this.Hide();
                    frmMain frmMain = new frmMain
                    {
                        IsAdmin = false,
                        MemberAccount = member
                    };
                    frmMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
