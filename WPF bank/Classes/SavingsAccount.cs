using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_bank.Managers;
namespace WPF_bank.Classes
{
    public class SavingsAccount
    {
        public decimal Savings { get; set; } = new Random().Next(100, 1001);
        private int SavingsAccountNumber { get; set; } = Guid.NewGuid().GetHashCode();

        public int GetSavingsAccountNumber()
        {
            return SavingsAccountNumber;
        }
    }
}
