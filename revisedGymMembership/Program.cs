using System;
using System.Collections.Generic;
using GymBL;

namespace revisedGymMembership
{
    class Program
    {
        static GymBAL gymLogic = new GymBAL();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nWELCOME TO DIWATA GYM OVERLOAD!\nUNLI BUHAT, UNLI WEIGHTS, UNLI PAWIS!\n");
                Console.WriteLine("1. Add Member");
                Console.WriteLine("2. Remove Member");
                Console.WriteLine("3. Display Members");
                Console.WriteLine("4. Update Payment Status");
                Console.WriteLine("5. Exit");
                Console.WriteLine("6. Send Payment Reminders");
                Console.Write("\nChoose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddMember();
                        break;
                    case "2":
                        RemoveMember();
                        break;
                    case "3":
                        DisplayMembers();
                        break;
                    case "4":
                        UpdatePaymentStatus();
                        break;
                    case "5":
                        return;
                    case "6":
                        SendPaymentReminders();
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again.\n");
                        break;
                }
            }
        }

        static void AddMember()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter membership type (normal or special): ");
            string membershipType = Console.ReadLine();

            Console.Write("Enter the month the member registered: ");
            string registeredMonth = Console.ReadLine();

            gymLogic.AddMember(name, membershipType, registeredMonth);
            Console.WriteLine("Member added successfully!\n");
        }

        static void RemoveMember()
        {
            Console.Write("Enter name to remove: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid input. Please enter a valid name.\n");
                return;
            }

            bool success = gymLogic.RemoveMember(name);
            Console.WriteLine(success ? "Member removed successfully.\n" : "Member not found.\n");
        }

        static void DisplayMembers()
        {
            List<string> memberSummaries = gymLogic.GetMemberSummaries();

            if (memberSummaries.Count == 0)
            {
                Console.WriteLine("\nNo members registered.\n");
                return;
            }

            Console.WriteLine("\nList of Members:");
            foreach (var summary in memberSummaries)
            {
                Console.WriteLine(summary);
            }
            Console.WriteLine();
        }

        static void UpdatePaymentStatus()
        {
            Console.Write("Enter name of the member to update payment status: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid input. Name cannot be empty.\n");
                return;
            }

            Console.Write("Enter new payment status (Paid/Unpaid): ");
            string status = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(status))
            {
                Console.WriteLine("Invalid input. Status cannot be empty.\n");
                return;
            }

            bool updated = gymLogic.UpdatePaymentStatus(name, status);
            Console.WriteLine(updated ? "Payment status updated.\n" : "Member not found or error occurred.\n");
        }

            static void SendPaymentReminders()
            {
                var gymLogic = new GymBAL();
                List<string> memberNames = gymLogic.GetMemberNames();

                foreach (var name in memberNames)
                {
                    string toEmail = "yourmailtrap@email.com";
                    string subject = "Gym Membership Payment Reminder";
                    string body = $"Dear {name},\n\nThis is a reminder to pay your gym membership.\n\nThank you!";
                    new Logics.GymLogic().SendMailtrapEmail(toEmail, subject, body);
                }

                Console.WriteLine("Payment reminders sent to all registered members.");
            }
        }
    }
