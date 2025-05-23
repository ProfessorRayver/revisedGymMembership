using System;
using System.Collections.Generic;
using System.IO;

namespace Logics
{
    public interface IGymDataService
    {
        List<Member> GetMembers();
        void AddMember(Member member);
        void RemoveMember(string name);
        void UpdatePaymentStatus(string name, string status);
    }
}
