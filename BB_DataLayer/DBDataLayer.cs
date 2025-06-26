using BB_Common;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_DataLayer
{
    public class DBDataLayer : IBudgetBuddyData
    {

        static string connectionString = "Data Source =ARRA\\SQLEXPRESS02; Initial Catalog = BudgetBuddy; Integrated Security = True; TrustServerCertificate=True;";
        static SqlConnection sqlConnection;

        public DBDataLayer()
        {
            sqlConnection = new SqlConnection(connectionString);
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

            var userAccounts = new List<UserAccounts>();

            while (reader.Read())
            {
                UserAccounts userAccount = new UserAccounts();
                userAccount.username = reader["username"].ToString();
                userAccount.password = reader["password"].ToString();
                userAccount.allowance = Convert.ToDouble(reader["allowance"].ToString());

                userAccounts.Add(userAccount);

            }

            sqlConnection.Close();
            return userAccounts;

        }


        public void UpdateAccount(UserAccounts userAccounts) 
        {
            sqlConnection.Open();
            var updateStatement = $"UPDATE accounts SET allowance= @allowance, password = @password WHERE username = @username";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@allowance", userAccounts.allowance); 
            updateCommand.Parameters.AddWithValue("@password", userAccounts.password);
            updateCommand.Parameters.AddWithValue("@username", userAccounts.username);
            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();

        }

        public void AddExpense(FinancialReport expense)
        {

            var insertStatement = "INSERT INTO WeeklyExpenses VALUES (@account_id, @DayOfWeek, @TotalExpense, @ExpenseDate)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@account_id", expense.account_id);
            insertCommand.Parameters.AddWithValue("@DayOfWeek", expense.DayOfWeek);
            insertCommand.Parameters.AddWithValue("@TotalExpense", expense.TotalExpense);
            insertCommand.Parameters.AddWithValue("@ExpenseDate", expense.ExpenseDate);
            sqlConnection.Open();

            insertCommand.ExecuteNonQuery();

            sqlConnection.Close();

        }

        public int GetAccountId(UserAccounts userAccounts)
        {
            string selectStatement = "SELECT account_id FROM accounts WHERE username = @username";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
                selectCommand.Parameters.AddWithValue("@username", userAccounts.username);
                conn.Open();
                return (int)selectCommand.ExecuteScalar();
            }
        }

        public List<FinancialReport> GetExpensesOnAcc(int accountId)
        {
            List<FinancialReport> reports = new List<FinancialReport>();

            string selectStatement = "SELECT expense_id, account_id, DayOfWeek, TotalExpense, ExpenseDate FROM WeeklyExpenses WHERE account_id = @account_id";
            using (SqlCommand command = new SqlCommand(selectStatement, sqlConnection))
            {
                command.Parameters.AddWithValue("@account_id", accountId);
                sqlConnection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    FinancialReport report = new FinancialReport
                    {
                        expense_ID = Convert.ToInt32(reader["expense_id"]),
                        account_id = Convert.ToInt32(reader["account_id"]),
                        DayOfWeek = reader["DayOfWeek"].ToString(),
                        TotalExpense = Convert.ToDouble(reader["TotalExpense"]),
                        ExpenseDate = Convert.ToDateTime(reader["ExpenseDate"])
                    };
                    reports.Add(report);
                }

                sqlConnection.Close();
            }

            return reports;
        }

        public void DeleteLoggedDays(int accountId)
        {
            sqlConnection.Open();

            var deleteStatement = $"DELETE FROM WeeklyExpenses WHERE account_id = @account_id";
            SqlCommand command = new SqlCommand(deleteStatement, sqlConnection);
            command.Parameters.AddWithValue("@account_id", accountId);

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }


    }
}
