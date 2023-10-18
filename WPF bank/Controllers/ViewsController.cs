using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_bank.Managers;
using WPF_bank.Views;

namespace WPF_bank.Controllers
{
    public static class ViewsController
    {


        public static AdminPanel adminPanel()
        {
            AdminPanel adminPanel = new AdminPanel();
            return adminPanel;
        }

        public static LoginWindow LoginWindow()
        {
            LoginWindow loginWindow = new();
            return loginWindow;
        }

        public static AccountWindow AccountWindow(bool loggedIn)
        {
            
            AccountWindow accountWindow = new();
            return accountWindow;
            
        }
        public static LoginWindow Logout()
        {
            UserManager.CurrentSignedInUser = null;
            LoginWindow loginWindow = new();
            return loginWindow;
        }
        public static Register Register()
        {
            Register register = new();
            return register;
        }

        

    }
}
