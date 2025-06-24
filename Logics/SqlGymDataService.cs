using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using GymCommon;

namespace Logics
{
    public class SqlGymDataService : IGymDataService
    {
        private static string connectionString =
            "Data Source=ver\\SQLEXPRESS; Initial Catalog=gym; Integrated Security=True; TrustServerCertificate=True;";

        public void AddMember(Member member)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var insertStatement = "INSERT INTO DbGym (Name, MembershipType, Month, PaymentStatus) VALUES (@Name, @MembershipType, @Month, @PaymentStatus)";
                SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

                insertCommand.Parameters.AddWithValue("@Name", member.Name);
                insertCommand.Parameters.AddWithValue("@MembershipType", member.MembershipType);
                insertCommand.Parameters.AddWithValue("@Month", member.Month);
                insertCommand.Parameters.AddWithValue("@PaymentStatus", member.PaymentStatus);

                sqlConnection.Open();
                insertCommand.ExecuteNonQuery();
            }
        }

        public List<Member> GetMembers()
        {
            var members = new List<Member>();
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var selectStatement = "SELECT Name, MembershipType, Month, PaymentStatus FROM DbGym";
                SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
                sqlConnection.Open();
                using (var reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        members.Add(new Member
                        {
                            Name = reader["Name"].ToString(),
                            MembershipType = reader["MembershipType"].ToString(),
                            Month = reader["Month"].ToString(),
                            PaymentStatus = reader["PaymentStatus"].ToString()
                        });
                    }
                }
            }
            return members;
        }

        public void RemoveMember(string name)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var deleteStatement = "DELETE FROM DbGym WHERE Name = @Name";
                SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
                deleteCommand.Parameters.AddWithValue("@Name", name);
                sqlConnection.Open();
                deleteCommand.ExecuteNonQuery();
            }
        }

        public void UpdatePaymentStatus(string name, string status)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var updateStatement = "UPDATE DbGym SET PaymentStatus = @PaymentStatus WHERE Name = @Name";
                SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
                updateCommand.Parameters.AddWithValue("@PaymentStatus", status);
                updateCommand.Parameters.AddWithValue("@Name", name);
                sqlConnection.Open();
                updateCommand.ExecuteNonQuery();
            }
        }
    }
}