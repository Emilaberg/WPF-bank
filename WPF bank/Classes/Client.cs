using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_bank.Managers;

namespace WPF_bank.Classes
{
    internal class Client : User
    {
        public int AccountNumber { get; set; } = Guid.NewGuid().GetHashCode();

        
        public Client(string username, string password) :base(username,password)
        {
            
        }
    }
}
