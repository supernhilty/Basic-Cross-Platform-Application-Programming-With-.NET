using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddMember(MemberObject member)=>MemberDAO.Instance.AddNew(member);
        

        public void DeleteMember(int id)=>MemberDAO.Instance.Remove(id);

        public MemberObject GetMemberByEmailAndPassword(string email, string password)
        => MemberDAO.Instance.getMemberByEmailAndPassWord(email, password);

        public MemberObject GetMemberByID(int id) => MemberDAO.Instance.GetMemberByID(id);


        public IEnumerable<MemberObject> Search(string search) => MemberDAO.Instance.GetSearchList(search);



        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberList;
        

        public List<MemberObject> getMembersByCityAndCountry(string city, string country)
        =>MemberDAO.Instance.getMembersByCityAndCountry(city, country);

        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);

        public List<string> GetCityList()
        =>MemberDAO.Instance.GetCityList();

        public List<string> GetCountryList()
        =>MemberDAO.Instance.GetCountryList();

        public List<string> GetCityOfCountry(string country)
        =>MemberDAO.Instance.GetCityListOfCountry(country);

        public List<MemberObject> GetMemberFilterSortSearch(string search, string sort, string city, string country)
       =>MemberDAO.Instance.GetMemberFilterSortSearch(search, sort, city, country);
    }
}
