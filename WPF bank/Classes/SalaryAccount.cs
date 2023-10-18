using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_bank.Managers;
namespace WPF_bank.Classes
{
    public class SalaryAccount
    {
        public decimal Salary { get; set; } = new Random().Next(100, 10001);
        private int SalaryAccountNumber { get; set; } = Guid.NewGuid().GetHashCode();
        
        public int GetSalaryAccountNumber()
        {
            return SalaryAccountNumber;
        }

    }

}
