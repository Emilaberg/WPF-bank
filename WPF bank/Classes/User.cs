using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_bank.Managers;
namespace WPF_bank.Classes
{
    public class User
    {
        private int userId;
        public string? Username{ get; set; }
        private string? Password;

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.userId = UserManager.CreateUserId();
        }
        public string GetPassword() 
        { 
            return Password!; 
        }

        public int GetUserId()
        {
            return userId;
        }
    }
}
