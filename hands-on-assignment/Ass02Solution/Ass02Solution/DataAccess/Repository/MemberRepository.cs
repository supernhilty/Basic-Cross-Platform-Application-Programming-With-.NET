using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly AppDbContext _db;
        public MemberRepository()
        {
            _db = new AppDbContext();
        }

        public void Add(Member member)
        {
            if(_db.Members.Find(member.MemberId) != null)
            {
                throw new Exception("Member has existed!");
            }
            _db.Members.Add(member);
            _db.SaveChanges();

        }

        public Member? CheckLogin(string email, string password)
        {
            return GetMembers().Where(mem => mem.Email == email && mem.Password == password).FirstOrDefault();
           
          
        }

        public bool CheckLoginAdmin(string email, string password)
        {
            IConfiguration config = new ConfigurationBuilder()
                      .SetBasePath(Directory.GetCurrentDirectory())      // file config ở thư mục hiện tại
                      .AddJsonFile("appsettings.json", true, true).Build();                  // nạp config định dạng JSON
                                                                                             // Tạo configurationroot
            string? emailConfig = config["Admin:email"];
            string? passwordConfig = config["Admin:password"];
            if (emailConfig != null && passwordConfig != null)
            {
                if (emailConfig == email && passwordConfig == password)
                {
                    return true;
                }
            }
            return false;
        }

        public void Delete(Member member)
        {
            _db.Members.Remove(member);
            _db.SaveChanges();


        }

        public IEnumerable<Member> GetMembers()
        {
            return _db.Members.ToList();
        }

        public bool UpdateProfile(Member member)
        {
            Member exMember = _db.Members.Find(member.MemberId);
            if (exMember != null)
            {

                _db.Entry(exMember).CurrentValues.SetValues(member);
                /* _db.Members.Update(member);
                 _db.ChangeTracker.DetectChanges();*/
                _db.SaveChanges();
                return true;               
            }
            else
            {
                throw new Exception("Member not valid!");
            }  
            
        }
    }
}
