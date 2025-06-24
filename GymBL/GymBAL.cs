using System.Collections.Generic;
using Logics;       
using GymCommon;    

namespace GymBL
{
    public class GymBAL
    {
        private GymLogic gymLogic;

        public GymBAL()
        {
            gymLogic = new GymLogic();
        }

        public void AddMember(string name, string membershipType, string month)
        {
            Member newMember = new Member();
            newMember.Name = name;
            newMember.MembershipType = membershipType;
            newMember.Month = month;
            newMember.PaymentStatus = "Unpaid";

            gymLogic.AddMember(newMember);
        }

        public bool RemoveMember(string name)
        {
            List<Member> members = gymLogic.GetMembers();
            bool found = false;

            foreach (Member m in members)
            {
                if (m.Name == name)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                gymLogic.RemoveMember(name);
                return true;
            }

            return false;
        }

        public List<string> GetMemberSummaries()
        {
            List<Member> members = gymLogic.GetMembers();
            List<string> summaries = new List<string>();

            foreach (Member member in members)
            {
                string summary = "Name: " + member.Name +
                                 ", Membership Type: " + member.MembershipType +
                                 ", Month: " + member.Month +
                                 ", Payment Status: " + member.PaymentStatus;
                summaries.Add(summary);
            }

            return summaries;
        }

        public bool UpdatePaymentStatus(string name, string newStatus)
        {
            List<Member> members = gymLogic.GetMembers();
            bool found = false;

            foreach (Member m in members)
            {
                if (m.Name == name)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                gymLogic.UpdatePaymentStatus(name, newStatus);
                return true;
            }

            return false;
        }
    }
}
