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

        public bool Deposit(string to)
        {
            return true;
        }

        public bool Withdraw(string from)
        {
            return true;
        }

        public bool Deposit(string from, string to)
        {
            return true;
        }

        public bool Transfer(string from, string to)
        {
            return true;
        }
    }


    
}
