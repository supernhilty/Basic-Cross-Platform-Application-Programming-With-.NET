using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System.Collections;
using System.Linq;


namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        private MemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }



        private void btnCancel_Click(object sender, EventArgs e)=>Close();

        private void txtLogin_Click(object sender, EventArgs e)
        {
            IConfiguration config = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())      // file config ở thư mục hiện tại
                       .AddJsonFile("appsettings.json", true, true).Build();                  // nạp config định dạng JSON
                                                                                              // Tạo configurationroot
            string? email = config["DefaultAccount:email"];
            string? password = config["DefaultAccount:password"];

            var admin = new MemberObject
            {
                Email = email,
                Password = password,
            };
            string inputEmail = txtEmail.Text;
            string inputPassword = txtPassword.Text;

            List<MemberObject> members = memberRepository.GetMembers().ToList();
            bool loginAdmin = false;
            if(admin.Email == inputEmail && admin.Password == password)
            {
                loginAdmin = true;
            }
            var loginUser = memberRepository.GetMemberByEmailAndPassword(inputEmail, inputPassword);
            if (loginAdmin)
            {
                frmMemberManagement frm = new frmMemberManagement();

                MessageBox.Show("Login Admin account successfully!", "Admin");
                
                frm.ShowDialog();
                this.Close();


            }
            else if (loginUser != null)
            {
                frmMemberDetails frm = new frmMemberDetails()
                {
                    Text = "Your Account",
                    InsertOrUpdate = true,
                    MemberRepository = memberRepository,
                    Member = loginUser,
                };
                MessageBox.Show("Login successfully!", "User");
                
                frm.ShowDialog();
                this.Close();


            }
            else
            {
                MessageBox.Show("Wrong email or password, please input again!", "Login fail");

            }
        }
    }
}
