using GymCommon;
using System.Net;
using System.Net.Mail;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Logics
{
    public class GymLogic
    {
        public IGymDataService dataService;
        public IConfiguration _configuration;
        public emailSettings _smtpSettings;

        public GymLogic()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

          
            _smtpSettings = new emailSettings(); 
            _configuration.GetSection("Smtp").Bind(_smtpSettings);

            dataService = new SqlGymDataService();
            //dataService = new TextFileDataService();
            //dataService = new JsonFileDataService();
            //dataIAccess = new InMemoryGymDataServices(); 
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
            string host = _smtpSettings.Host;
            int port = _smtpSettings.Port;
            string username = _smtpSettings.Username;
            string password = _smtpSettings.Password;
            string fromAddress = _smtpSettings.FromAddress;

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
                Console.WriteLine("Successfully configured credential! Check the inbox.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error, there is something wrong: " + ex.Message);
            }
        }

        public List<string> GetMemberNames()
        {
            return dataService.GetMemberNames();
        }
    }
}