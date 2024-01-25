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
    public partial class frmProfile : Form
    {
        private readonly IMemberRepository _memberRepository = new MemberRepository();
        public Member Member { get; set; }
        public bool IsUpdate { get; set; }
        public frmProfile()
        {
            InitializeComponent();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                txtId.Text = Member.MemberId.ToString();
                txtEmail.Text = Member.Email;
                txtId.Enabled = false;
                txtEmail.Enabled = false;
                txtCompany.Text = Member.CompanyName;
                txtCity.Text = Member.City;
                txtCountry.Text = Member.Country;
                txtPassword.Text = Member.Password;
            }
            else
            {
                txtId.Enabled = false;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsChange = true;
                foreach (Control contr in this.Controls)
                {
                    if (contr is TextBox)
                    {
                        if (contr.Text == string.Empty && contr.Enabled == true)
                        {
                            MessageBox.Show("Please fill " + contr.Name + "!");
                            IsChange = false;
                            break;
                        }
                        
                    }
                    
                }
                if(IsChange)
                {
                    if (!IsUpdate)
                    {

                        Member member = new Member()
                        {
                            City = txtCity.Text,
                            Country = txtCountry.Text,
                            Password = txtPassword.Text,
                            Email = txtEmail.Text,
                            CompanyName = txtCompany.Text,
                        };
                        _memberRepository.Add(member);

                    }
                    else
                    {
                        Member.Email = txtEmail.Text;
                        Member.CompanyName = txtCompany.Text;
                        Member.City = txtCity.Text;
                        Member.Country = txtCountry.Text;
                        Member.Password = txtPassword.Text;
                        _memberRepository.UpdateProfile(Member);
                        MessageBox.Show("Update successfully!");

                    }
                }
               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
