using BB_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BB_DataLayer
{
    public class TextFileData : IBudgetBuddyData
    {
        string filePath = "TextFileData.txt";
        List<UserAccounts> userAccounts = new List<UserAccounts>();

        public TextFileData()
        {
            GetData();
        }

        public void GetData()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose(); 
                return;
            }

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length < 3 || !double.TryParse(parts[2], out double allowance))
                {
                    continue; 
                }

                userAccounts.Add(new UserAccounts
                {
                    username = parts[0],
                    password = parts[1],
                    allowance = allowance
                });
            }
        }

        private void WriteDataToFile()
        {
            var lines = new string[userAccounts.Count];

            for (int i = 0; i < userAccounts.Count; i++)
            {
                lines[i] = $"{userAccounts[i].username},{userAccounts[i].password},{userAccounts[i].allowance}";
            }

            File.WriteAllLines(filePath, lines);
        }



        private int FindAccountIndex(string userUsername, string userPassword)  //note this parameter for txt
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

        public void CreateAccount(UserAccounts userAccounts)
        {
            var newLine = $"{userAccounts.username},{userAccounts.password},{userAccounts.allowance}";

            File.AppendAllText(filePath, newLine);

        }


        public void UpdateAccount(UserAccounts accounts)
        {
            var index = FindAccountIndex(accounts.username, accounts.password);

            if (index != -1)
            {
                userAccounts[index].username = accounts.username;
                userAccounts[index].password = accounts.password;
                userAccounts[index].allowance = accounts.allowance;

                WriteDataToFile();
            }
        }
        public void DeleteAccount(UserAccounts account)
        {
            int index = -1;
            for (int i = 0; i < userAccounts.Count; i++)
            {
                if (userAccounts[i].username == account.username)
                {
                    index = i;
                }
            }

            userAccounts.RemoveAt(index);

            WriteDataToFile();
        }

    }
}