using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMembers();
        MemberObject GetMemberByID(int id);
        IEnumerable<MemberObject> Search(string search);
        void AddMember(MemberObject member);
        void UpdateMember(MemberObject member);
        void DeleteMember(int id);
        List<MemberObject> getMembersByCityAndCountry(string city, string country);
        MemberObject GetMemberByEmailAndPassword(string email, string password);
        List<string> GetCityList();
        List<string> GetCountryList();
        List<string> GetCityOfCountry(string country);
        List<MemberObject> GetMemberFilterSortSearch(string search, string sort, string city, string country);
    }
}
