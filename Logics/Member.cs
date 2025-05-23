using System;
using System.Collections.Generic;
using System.IO;

namespace Logics
{
    public class Member
    {
        public string Name { get; set; }
        public string MembershipType { get; set; }
        public string Month { get; set; }
        public string PaymentStatus { get; set; }

        public Member() { }

        public Member(string name, string membershipType, string month)
        {
            Name = name;
            MembershipType = membershipType;
            Month = month;
            PaymentStatus = "Unpaid";
        }
    }
}
