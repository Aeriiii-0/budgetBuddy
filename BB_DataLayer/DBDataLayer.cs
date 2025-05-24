using BB_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace BB_DataLayer
{
    public class DBDataLayer : IBudgetBuddyData
    {
      
        static string connectionString
          = "Data Source =ARRA\\SQLEXPRESS02; Initial Catalog = BudgetBuddy; Integrated Security = True; TrustServerCertificate=True;";
        //static List<UserAccounts> UserAccounts = new List<UserAccounts>();
        static SqlConnection sqlConnection;

        public DBDataLayer()
        {
            sqlConnection= new SqlConnection(connectionString);
        }
        public void CreateAccount(UserAccounts userAccounts)
        {
            var insertStatement = "INSERT INTO accounts VALUES (@username, @password, @allowance)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@username", userAccounts.username);
            insertCommand.Parameters.AddWithValue("@password", userAccounts.password);
            insertCommand.Parameters.AddWithValue("@allowance", userAccounts.allowance);
            sqlConnection.Open();

            insertCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void DeleteAccount(UserAccounts userAccounts)
        {
            sqlConnection.Open();

            var deleteStatement = $"DELETE FROM accounts WHERE username = @username";
            SqlCommand updateCommand = new SqlCommand(deleteStatement, sqlConnection);
            updateCommand.Parameters.AddWithValue("@username", userAccounts.username);

            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public List<UserAccounts> GetAccounts()
        {
            var selectStatement = "SELECT username, password, allowance FROM accounts";

           SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            
            sqlConnection.Open();

            SqlDataReader reader = selectCommand.ExecuteReader();

            var userAccounts= new List<UserAccounts>();

            while (reader.Read())
            {
               UserAccounts userAccount = new UserAccounts();
                userAccount.username = reader["username"].ToString();
                userAccount.password = reader["password"].ToString();
                userAccount.allowance =Convert.ToDouble(reader["allowance"].ToString());

                userAccounts.Add(userAccount);

            }

            sqlConnection.Close();
            return userAccounts;

        }

        public void UpdateAccount(UserAccounts userAccounts)
        {
           sqlConnection.Open();
            var updateStatement = $"UPDATE accounts SET allowance= @allowance WHERE username = @username";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@username", userAccounts.username);
            updateCommand.Parameters.AddWithValue("@password", userAccounts.password);
            updateCommand.Parameters.AddWithValue("@allowance", userAccounts.allowance);
            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();

        }
    }
}
