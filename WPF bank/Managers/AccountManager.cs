using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_bank.Classes;

namespace WPF_bank.Managers
{
    public class AccountManager
    {
        public static decimal totalFunds = 0;
        public static int AccountNumber { get; set; }
        public SalaryAccount SalaryAccount { get; set; } = new();
        public SavingsAccount SavingsAccount { get; set; } = new();

        public bool Deposit(string to, int amount)
        {
            if(to == "salary")
            {
                SalaryAccount.Salary += amount;
            }else if(to == "savings")
            {
                SavingsAccount.Savings += amount;
            }
            return true;
        }

        public bool Withdraw(string from, int amount)
        {
            if (from == "salary")
            {
                SalaryAccount.Salary -= amount;
            }
            else if (from == "savings")
            {
                SavingsAccount.Savings -= amount;
            }
            return true;
        }

        public bool Transfer(string from, int amount)
        {
            if(from == "salary")
            {
                SavingsAccount.Savings += amount;
                SalaryAccount.Salary -= amount;
            }else if(from == "savings")
            {
                SalaryAccount.Salary += amount;
                SavingsAccount.Savings -= amount;
            }
            return true;
        }
    }


    
}
