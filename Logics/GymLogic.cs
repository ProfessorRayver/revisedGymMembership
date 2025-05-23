using System;
using System.Collections.Generic;
using System.IO;

namespace Logics
{
    public class GymLogic
    {
        private IGymDataService dataService;

        public GymLogic()
        {
           // dataService = new TextFileDataService();
            dataService = new JsonFileDataService();
        }

        public void AddMember(Member member)
        {
            dataService.AddMember(member);
        }

        public void RemoveMember(string name)
        {
            dataService.RemoveMember(name);
        }

        public List<Member> GetMembers()
        {
            return dataService.GetMembers();
        }

        public void UpdatePaymentStatus(string name, string status)
        {
            dataService.UpdatePaymentStatus(name, status);
        }
    }
}
