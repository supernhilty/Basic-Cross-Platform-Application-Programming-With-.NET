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
    public partial class frmMembers : Form
    {
        private readonly IMemberRepository _memberRepository = new MemberRepository();
        BindingSource _source;
        public frmMembers()
        {
            InitializeComponent();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            // this.dgvMember.Columns["Order"].Visible = false;
            LoadMemberList();
        }

        private void LoadMemberList(IEnumerable<Member> members = null)
        {
            if (members == null)
            {
                members = _memberRepository.GetMembers();
            }
            _source = new BindingSource();
            _source.DataSource = members;

            dgvMember.DataSource = null;
            dgvMember.DataSource = _source;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile()
            {
                Member = GetMember(),
                IsUpdate = false
            };
            if (frmProfile.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile()
            {
                Member = GetMember(),
                IsUpdate = true
            };
            if (frmProfile.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _memberRepository.Delete(GetMember());
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private Member GetMember()
        {
            return dgvMember.SelectedRows[0].DataBoundItem as Member;
        }



        private void dgvMember_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
