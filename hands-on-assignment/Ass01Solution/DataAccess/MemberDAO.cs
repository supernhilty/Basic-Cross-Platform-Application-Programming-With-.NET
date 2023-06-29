using BusinessObject;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace DataAccess
{
    public class MemberDAO
    {
        private const string SORT_ASC = "Member Name A - Z";
        private const string SORT_DESC = "Member Name Z - A";

        private static List<MemberObject> MemberList = new List<MemberObject>()
        {
            new MemberObject{MemberID=7, MemberName="Nguyen Thi Ha", Email="hant@gmail.com", Password="123", City="Ha Noi", Country="Viet Nam"},
            new MemberObject{MemberID=1, MemberName="Nguyen Ha", Email="han@gmail.com", Password="123", City="Ha Noi", Country="Viet Nam"},
            new MemberObject{MemberID=2, MemberName="Vu Cat Ly", Email="lyvc@gmail.com", Password="123", City="Ho Chi Minh", Country="Viet Nam"},
            new MemberObject{MemberID=3, MemberName="Nguyen An", Email="ann@gmail.com", Password="123", City="Da Nang", Country="Viet Nam"},
            new MemberObject{MemberID=4, MemberName="Le Trong Ly", Email="lylt@gmail.com", Password="123", City="New York", Country="US"},
            new MemberObject{MemberID=5, MemberName="Taylor Nguyen", Email="taylorn@gmail.com", Password="123", City="Las Vegas", Country="US"},
            new MemberObject{MemberID=6, MemberName="Le Hoai", Email="hoail@gmail.com", Password="123", City="London", Country="UK"}

        };

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public List<MemberObject> GetMemberList => MemberList;

        public List<MemberObject> GetSearchList(string search)
        {
            return MemberList.Where(mem=>(mem.MemberName.ToLower().Contains(search.ToLower())|| mem.City.ToLower().Contains(search.ToLower())|| mem.Country.ToLower().Contains(search.ToLower()))).ToList();
        }

        public MemberObject? GetMemberByID(int memberID)
        {
            return MemberList.SingleOrDefault(mem=>mem.MemberID == memberID);
        }
            
        public MemberObject? GetMemberByName(string memberName)
        {
            return MemberList.SingleOrDefault(memb=>memb.MemberName.Contains(memberName));
        }

        public void AddNew(MemberObject member)
        {
            MemberObject mem = GetMemberByID(member.MemberID);
            if(mem != null)
            {
                throw new Exception("Member has already existed");
            }
            else
            {
                MemberList.Add(member);
            }
        }

        public void Update(MemberObject member)
        {
            MemberObject mem = GetMemberByID(member.MemberID);
            if (mem != null)
            {
                var index = MemberList.IndexOf(mem);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member has not existed");
            }
        }

        public void Remove(int memberID) 
        {
            MemberObject mem = GetMemberByID(memberID);
            if (mem != null)
            {
                MemberList.Remove(mem);
            }
            else
            {
                throw new Exception("Member has not existed");
            }
        }

        public List<MemberObject> getMembersByCityAndCountry(string city, string country)
        {
            List<MemberObject> filterList = new List<MemberObject>();
            foreach (MemberObject member in MemberList)
            {
                if(member.City == city || member.Country == country)
                {
                    filterList.Add(member);
                }
            }
            return filterList;
        }

        public MemberObject? getMemberByEmailAndPassWord(string email, string password)
        {
            return MemberList.SingleOrDefault(mem => mem.Email == email && mem.Password == password);
        }

        public List<string> GetCityList()
        {
            return (from member in MemberList
             select member.City).Distinct().ToList();
             
        }

        public List<string> GetCountryList()
        {
            return (from member in MemberList
                    select member.Country).Distinct().ToList();
        }

        public List<string> GetCityListOfCountry(string country)
        {
            return (from member in MemberList
                    where member.Country.Equals(country)
                    select member.City
                   ).Distinct().ToList();

        }

        public List<MemberObject> GetMemberFilterSortSearch(string search, string sort, string city, string country)
        {
            List<MemberObject> list = null;
            if (search != null &&search.Equals(""))
            {
                list = GetSearchList(search);
            }
            else
            {
                list = GetMemberList;
            }
            if(country != null && !country.Equals(""))
            {
                list = list.Where(mem=>mem.Country.Equals(country)).ToList();
            }
            if (city != null && !city.Equals(""))
            {
                list = list.Where(mem => mem.City.Equals(city)).ToList();
            }
            if (sort != null && !sort.Equals(""))
            {
                if (sort.Equals(SORT_ASC))
                {
                    list= list.OrderBy(mem=>mem.MemberName.ToLower()).ToList();
                }else if (sort.Equals(SORT_DESC))
                {
                    list = list.OrderByDescending(mem => mem.MemberName.ToLower()).ToList();

                }
            }
            return list;
        }
    }
}