using System;
using System.Collections.Generic;
using Logics;

namespace revisedGymMembership
{
    class Program
    {
        static GymLogic gymLogic = new GymLogic();

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
                Console.Write("\nChoose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1") AddMember();
                else if (choice == "2") RemoveMember();
                else if (choice == "3") DisplayMembers();
                else if (choice == "4") UpdatePaymentStatus();
                else if (choice == "5") break;
                else Console.WriteLine("Invalid input, try again.\n");
            }
        }

        static void AddMember()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter membership type (normal or special): ");
            string membershipType = Console.ReadLine();

            Console.Write("Enter the month the member registered: ");
            string month = Console.ReadLine();

            Member newMember = new Member
            {
                Name = name,
                MembershipType = membershipType,
                Month = month,
                PaymentStatus = "Unpaid"
            };

            gymLogic.AddMember(newMember);
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

            gymLogic.RemoveMember(name);
            Console.WriteLine("Member removed (if existed).\n");
        }

        static void DisplayMembers()
        {
            List<Member> members = gymLogic.GetMembers();

            if (members.Count == 0)
            {
                Console.WriteLine("\nNo members registered.\n");
                return;
            }

            Console.WriteLine("\nList of Members:");
            foreach (var member in members)
            {
                Console.WriteLine("Name: " + member.Name +
                                  ", Membership: " + member.MembershipType +
                                  ", Month: " + member.Month +
                                  ", Payment Status: " + member.PaymentStatus);
            }
            Console.WriteLine();
        }

        static void UpdatePaymentStatus()
        {
            Console.Write("Enter name of the member to update payment status: ");
            string name = Console.ReadLine();

            Console.Write("Enter new payment status (Paid/Unpaid): ");
            string status = Console.ReadLine();

            gymLogic.UpdatePaymentStatus(name, status);
            Console.WriteLine("Payment status updated (if member exists).\n");
        }
    }
}
