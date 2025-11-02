using GymCommon;
using System.Net;
using System.Net.Mail;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace Logics
{
    public class GymLogic
    {
        private IGymDataService dataService;
        private IConfiguration _configuration; 

        public GymLogic()
        {
            //configured credential insidw my appsettings.json
                 _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

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
            string host = _configuration["Smtp:Host"];
            int port = int.Parse(_configuration["Smtp:Port"]);
            string username = _configuration["Smtp:Username"];
            string password = _configuration["Smtp:Password"];
            string fromAddress = _configuration["Smtp:FromAddress"];

            var client = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(username, password),
                EnableSsl = true
            };

            var mail = new MailMessage(fromAddress, toEmail, subject, body);
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = false;

            try
            {
                client.Send(mail);
                Console.WriteLine("Successfull configured credential! check the inbox.");
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