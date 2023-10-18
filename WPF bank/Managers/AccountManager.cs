using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_bank.Classes;

namespace WPF_bank.Managers
{
    internal class AccountManager
    {
        protected decimal totalFunds = 0;
        public int AccountNumber { get; set; } = Guid.NewGuid().GetHashCode();
        public static SalaryAccount SalaryAccount { get; set; } = new();
        public static SavingsAccount SavingsAccount { get; set;} = new();

        

    }
}
