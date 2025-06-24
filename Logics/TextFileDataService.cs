using System;
using System.Collections.Generic;
using System.IO;
using GymCommon;

namespace Logics
{
    public class TextFileDataService : IGymDataService
    {
        private string filePath = "membershiplist.txt";
        private List<Member> members = new List<Member>();

        public TextFileDataService()
        {
            LoadDataFromFile();
        }

        private void LoadDataFromFile()
        {
            members.Clear();
            if (!File.Exists(filePath))
                return;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 4)
                {
                    members.Add(new Member
                    {
                        Name = parts[0],
                        MembershipType = parts[1],
                        registeredMonth = parts[2],
                        PaymentStatus = parts[3]
                    });
                }
            }
        }

        private void WriteDataToFile()
        {
            var lines = new string[members.Count];
            for (int i = 0; i < members.Count; i++)
            {
                lines[i] = $"{members[i].Name}|{members[i].MembershipType}|{members[i].registeredMonth}|{members[i].PaymentStatus}";
            }
            File.WriteAllLines(filePath, lines);
        }

        private int FindMemberIndex(string name)
        {
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].Name != null && members[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }

        public List<Member> GetMembers()
        {
            LoadDataFromFile();
            return new List<Member>(members);
        }

        public void AddMember(Member member)
        {
            LoadDataFromFile();
            members.Add(member);
            WriteDataToFile();
        }

        public void RemoveMember(string name)
        {
            LoadDataFromFile();
            int index = FindMemberIndex(name);
            if (index != -1)
            {
                members.RemoveAt(index);
                WriteDataToFile();
            }
        }

        public void UpdatePaymentStatus(string name, string status)
        {
            LoadDataFromFile();
            int index = FindMemberIndex(name);
            if (index != -1)
            {
                members[index].PaymentStatus = status;
                WriteDataToFile();
            }
        }
    }
}