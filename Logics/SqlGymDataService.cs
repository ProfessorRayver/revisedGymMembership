using System;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace Logics
{
    public class SqlGymDataService : IGymDataService
    {
        private static string connectionString = "Data Source=DESKTOP-C1E363;Initial Catalog=YOU;Integrated Security=True;TrustServerCertificate=True;";
        private static SqlConnection sqlConnection;

        public SqlGymDataService()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void AddMember(Member member)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var insertStatement = "INSERT INTO Members (Name, MembershipType, Month, PaymentStatus) VALUES (@Name, @MembershipType, @Month, @PaymentStatus)";
                SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

                insertCommand.Parameters.AddWithValue("@Name", member.Name);
                insertCommand.Parameters.AddWithValue("@MembershipType", member.MembershipType);
                insertCommand.Parameters.AddWithValue("@Month", member.Month);
                insertCommand.Parameters.AddWithValue("@PaymentStatus", member.PaymentStatus);

                sqlConnection.Open();
                insertCommand.ExecuteNonQuery();
            }
        }
    } 
}

   
