using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_bank.Classes;
using WPF_bank.Managers;

namespace WPF_bank.Controllers
{
    public static class RegisterController
    {
        public static bool ValidateRegister(string username, string password, string confirmPassword)
        {
            if (username == "" && password == "" && confirmPassword == "") //Om man inte skrivit in nånting alls
            {
                MessageBox.Show("you need to type a username, password and confirm password", "Alert");
                return false;
            }
            else if (username == "" && password != "") //om man inte skrivit in ett username
            {
                MessageBox.Show("you need to type a username", "Alert");
                return false;
            }
            else if (username != "" && password == "") // om man inte skrivit in ett password 
            {
                MessageBox.Show("you need to type a password", "Alert");
                return false;
            }else if(username != "" && password != "" && confirmPassword == "") // confirm password är tom
            {
                MessageBox.Show("you need to confirm password", "Alert");
                return false;
            }else
            {
                if(password != confirmPassword)
                {
                    MessageBox.Show("password was not the same, try again", "Alert");
                    return false;
                }else
                {
                    Client newClient = new(username, password);
                    UserManager.Users.Add(newClient);
                    UserManager.CurrentSignedInUser = newClient;
                    return true;
                }
            }
            return false;

        }
    }
}
