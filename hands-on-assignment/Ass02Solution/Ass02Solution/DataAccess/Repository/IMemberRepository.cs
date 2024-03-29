﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member CheckLogin(string email, string password);
        bool CheckLoginAdmin(string email, string password);
        bool UpdateProfile(Member member);
        void Delete(Member member);
        void Add(Member member);
    }
}
