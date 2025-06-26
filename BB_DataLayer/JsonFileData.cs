using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BB_Common;

namespace BB_DataLayer
{
    public class JsonFileData: IBudgetBuddyData
    {
        static List<UserAccounts> userAccounts = new List<UserAccounts>();
        static string jsonFilePath = "JsonFileData.json";
        public JsonFileData()
        {
            ReadJsonDataFromFile();
        }
        private void ReadJsonDataFromFile()
        {
            string jsonText = File.ReadAllText(jsonFilePath);
            userAccounts = JsonSerializer.Deserialize<List<UserAccounts>>(jsonText,  new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        private void WriteJsonDataToFile()
        {
            string jsonString = JsonSerializer.Serialize(userAccounts, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(jsonFilePath, jsonString);
        }
        private int FindAccountIndex(string userUsername, string userPassword)  
        {
            var accounts = GetAccounts();

            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].username == userUsername && accounts[i].password == userPassword)
                {
                    return i;
                }
            }

            return -1;
        }

        public List<UserAccounts> GetAccounts()
        {
            return userAccounts;
        }

        public void CreateAccount(UserAccounts userAccount)
        {
            userAccounts.Add(userAccount);
            WriteJsonDataToFile();
        }


        public void DeleteAccount(UserAccounts userAccount)
        {
            var index = FindAccountIndex(userAccount.username, userAccount.password);

            userAccounts.RemoveAt(index);
            WriteJsonDataToFile();

        }

        public void UpdateAccount(UserAccounts userAccount)
        {
            var index = FindAccountIndex(userAccount.username, userAccount.password);

            if (index != -1)
            {
                userAccounts[index].username = userAccount.username;
                userAccounts[index].password = userAccount.password;
                userAccounts[index].allowance = userAccount.allowance;

                WriteJsonDataToFile();
            }
        }

        public void AddExpense(FinancialReport expense)
        {

        }

        public int GetAccountId(UserAccounts userAccounts)
        {
            return 0;
        }

        public void DeleteLoggedDays(int accountId)
        {

        }

        public List<FinancialReport> GetExpensesOnAcc(int accountId)
        {
            return new List<FinancialReport>();
        }
    }
}
