using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;

        public frmMemberManagement()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';

        }


        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            LoadMemberList(memberRepository.GetMembers());
            foreach (var city in memberRepository.GetCityList())
            {
                cboCity.Items.Add(city);
            }
            //if (cboCity.Items != null && cboCity.Items.Count != 0) cboCity.SelectedIndex = 0;
            foreach (var country in memberRepository.GetCountryList())
            {
                cboCountry.Items.Add(country);
            }
            //if (cboCountry.Items != null && cboCountry.Items.Count != 0) cboCountry.SelectedIndex = 0;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;

        }

        private void dgvMemberList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails()
            {
                Text = "Update car",
                InsertOrUpdate = true,
                Member = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList(memberRepository.GetMembers());
                source.Position = source.Count - 1;
            }

        }

        private void LoadMemberList(IEnumerable<MemberObject> members)
        {

            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "MemberID");
                txtName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void ClearText()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        private MemberObject GetMemberObject()
        {
            MemberObject memberObject = null;
            try
            {
                memberObject = new MemberObject
                {
                    MemberID = int.Parse(txtID.Text),
                    MemberName = txtName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return memberObject;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Add member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList(memberRepository.GetMembers());
                source.Position = source.Position - 1;
            }
        }

        /*private void btnUpdate_Click(object sender, EventArgs e)
        {

        }*/

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberID);
                LoadMemberList(memberRepository.GetMembers());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a car");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                LoadMemberList(memberRepository.Search(txtSearch.Text));
            }
            else
            {
                LoadMemberList(memberRepository.GetMembers());

            }
            cboCountry.Items.Clear();
            cboCity.Items.Clear();
            foreach (var city in memberRepository.GetCityList())
            {
                cboCity.Items.Add(city);
            }
            foreach (var country in memberRepository.GetCountryList())
            {
                cboCountry.Items.Add(country);
            }
            cboSort.Text = "";
            cboCity.Enabled = true;
            cboCountry.Enabled = true;
            cboCity.Text = "";
            cboCountry.Text = "";

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cboSort.Text = "";
            cboCity.Enabled = true;
            cboCountry.Enabled = true;
            cboCity.Text = "";
            cboCountry.Text = "";
            txtSearch.Text = string.Empty;
            cboCity.Items.Clear();
            cboCountry.Items.Clear();
            foreach (var city in memberRepository.GetCityList())
            {
                cboCity.Items.Add(city);
            }
            foreach (var country in memberRepository.GetCountryList())
            {
                cboCountry.Items.Add(country);
            }

            LoadMemberList(memberRepository.GetMembers());
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMemberList(memberRepository.GetMemberFilterSortSearch(txtSearch.Text,
                cboSort.Text, cboCity.Text, cboCountry.Text));
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCity.Items.Clear();
            foreach (var city in memberRepository.GetCityOfCountry(cboCountry.Text))
            {

                cboCity.Items.Add(city);
            }
            LoadMemberList(memberRepository.GetMemberFilterSortSearch(txtSearch.Text,
                cboSort.Text, cboCity.Text, cboCountry.Text));
        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {

            cboCountry.Enabled = false;
            LoadMemberList(memberRepository.GetMemberFilterSortSearch(txtSearch.Text,
                cboSort.Text, cboCity.Text, ""));
        }

        private void dgvMemberList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
