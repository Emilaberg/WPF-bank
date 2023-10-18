using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_bank.Managers;
namespace WPF_bank.Classes
{
    internal class SalaryAccount : AccountManager
    {
        public decimal Salary { get; set; } = new Random().Next(100, 1001);
        public new int AccountNumber { get; set; } = Guid.NewGuid().GetHashCode();

        

        public int GetAccountNumber()
        {
            return AccountNumber;
        }

    }

}
