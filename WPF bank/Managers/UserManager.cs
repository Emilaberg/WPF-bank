using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_bank.Classes;
namespace WPF_bank.Managers
{
    public static class UserManager
    {
        private static int totalUserId = 0;
        public static List<User> Users { get; set; } = new() 
        { 
            new Client("test", "password"),
            new Client("Emil", "password1"),
            new Client("benny", "password2"),
            new Client("test1", "password3"),
            new Client("a", "a"),
            new Admin("admin", "1")
        };

        public static User? CurrentSignedInUser { get; set; }


        public static int CreateUserId()
        {
            return totalUserId++;
        }
    }
}
