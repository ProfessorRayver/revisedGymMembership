using System;
using System.Collections.Generic;
using System.IO;
using GymCommon;

namespace Logics
{
    public class InMemoryGymDataServices : IGymDataService
    {
        private readonly List<Member> members = new List<Member>();

        public List<Member> GetMembers()
        {
            return new List<Member>(members);
        }

        public void AddMember(Member member)
        {
            members.Add(member);
        }

        public void RemoveMember(string name)
        {
            for (int i = members.Count - 1; i >= 0; i--)
            {
                if (members[i].Name != null && members[i].Name.Equals(name, System.StringComparison.OrdinalIgnoreCase))
                {
                    members.RemoveAt(i);
                }
            }
        }

        public void UpdatePaymentStatus(string name, string status)
        {
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].Name != null && members[i].Name.Equals(name, System.StringComparison.OrdinalIgnoreCase))
                {
                    members[i].PaymentStatus = status;
                    break;
                }
            }
        }
    }
}