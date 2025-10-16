using System;
using System.Collections.Generic;
using System.IO;
using GymCommon;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Logics
{
    public class GymLogic
    {
        private IGymDataService dataService;

        public GymLogic()
        {
            dataService = new SqlGymDataService();
            //dataService = new TextFileDataService();
            //dataService = new JsonFileDataService();
            //dataService = new InMemoryGymDataServices(); 
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

        public void SendMailtrapEmail(string toEmail, string subject, string body)
        {
            var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("1aaf312c9fec5c", "6b9908b82d0775"),
                EnableSsl = true
            };

            var mail = new MailMessage("Rayver@Reyes.com", toEmail, subject, body);
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = false;

            try
            {
                client.Send(mail);
                Console.WriteLine("Successfully sent, check the inbox.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error there is something wrong: " + ex.Message);
            }
        }

        public List<string> GetMemberNames()
        {
            return dataService.GetMemberNames();
        }
    }
}
