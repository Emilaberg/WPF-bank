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
            if(loggedIn)
            {
                AccountWindow accountWindow = new();
                return accountWindow;
            }
            return null;
        }

        public static Register Register()
        {
            Register register = new();
            return register;
        }

        public static object UpdateUi(string c)
        {
            if(c == "AccountWindow")
            {
                //returnea account window data
                return new { };
            }
            else if(c == "AdminPanel")
            {
                //Returnera Alla users
                return new { };
            }
            return new { };
        }

    }
}
