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
        //När clien skapas, så skapas en accountmanager,med båda accounts.
        public AccountManager AccountManager { get; set; } = new();
        
        public Client(string username, string password) :base(username,password)
        {
            
        }
    }
}
