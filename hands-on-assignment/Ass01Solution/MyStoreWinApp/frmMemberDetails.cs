using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';

        }

        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }//Update: true, Insert: false
        public MemberObject Member { get; set; }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate)
            {
                txtID.Text = Member.MemberID.ToString();
                txtName.Text = Member.MemberName;
                txtEmail.Text = Member.Email;                
                txtPassword.Text = Member.Password;
                txtCity.Text = Member.City;
                txtCountry.Text = Member.Country;
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberID = int.Parse(txtID.Text),
                    MemberName = txtName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                };
                if (InsertOrUpdate)
                {
                    MemberRepository.UpdateMember(member);
                    if (Text == "Your Account")
                    {
                        frmLogin frm = new frmLogin();
                        
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MemberRepository.AddMember(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}
