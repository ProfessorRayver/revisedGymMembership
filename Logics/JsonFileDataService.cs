using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using GymCommon;

namespace Logics
{
    public class JsonFileDataService : IGymDataService
    {
        private string jsonFile = "membershiplist.json";
        private List<Member> members = new List<Member>();

        public JsonFileDataService()
        {
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            if (File.Exists(jsonFile))
            {
                string jsonText = File.ReadAllText(jsonFile);
                var loaded = JsonSerializer.Deserialize<List<Member>>(jsonText,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                if (loaded != null)
                    members = loaded;
                else
                    members = new List<Member>();
            }
            else
            {
                members = new List<Member>();
            }
        }

        private void SaveToFile()
        {
            string jsonString = JsonSerializer.Serialize(members, new JsonSerializerOptions
            { WriteIndented = true });
            File.WriteAllText(jsonFile, jsonString);
        }

        private int FindMemberIndex(string name)
        {
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].Name != null && members[i].Name.Equals(name, System.StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }

        public List<Member> GetMembers()
        {
            LoadFromFile();
            return new List<Member>(members);
        }

        public void AddMember(Member member)
        {
            LoadFromFile();
            members.Add(member);
            SaveToFile();
        }

        public void RemoveMember(string name)
        {
            LoadFromFile();
            int index = FindMemberIndex(name);
            if (index != -1)
            {
                members.RemoveAt(index);
                SaveToFile();
            }
        }

        public void UpdatePaymentStatus(string name, string status)
        {
            LoadFromFile();
            int index = FindMemberIndex(name);
            if (index != -1)
            {
                members[index].PaymentStatus = status;
                SaveToFile();
            }
        }
    }
}
