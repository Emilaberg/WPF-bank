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
    public static class LoginController
    {
        
        public static bool Validateinput(string username, string password)
        {
            if(username == "" && password == "") //Om man inte skrivit in nånting alls
            {
                MessageBox.Show("you need to type a username and a password", "Alert");
                return false;
            }
            else if (username == "" && password != "") //om man inte skrivit in ett username
            {
                MessageBox.Show("you need to type a username", "Alert");
                return false; 
            }
            else if(username != "" && password == "") // om man inte skrivit in ett password 
            {
                MessageBox.Show("you need to type a password", "Alert");
                return false;
            }else
            {
                foreach(User user in UserManager.Users)
                {
                    if (user.Username == username && user.GetPassword() == password)
                    {
                        UserManager.CurrentSignedInUser = user; //SETS THE LOGGED IN USER TO CURRENTSIGNEDINUSER
                        return true;
                    }else if( user.Username == username && user.GetPassword() != password ) //Password was wrong
                    {
                        MessageBox.Show("user Found, but password is incorrect", "Alert");
                        return false;
                    }else if( user.Username != username && user.GetPassword() == password ) //username was wrong
                    {
                        MessageBox.Show("user Found, but username is incorrect", "Alert");
                        return false;
                    }
                }
                MessageBox.Show("There are no user registrerd with these credentials.", "Alert");
                
                return false;
            }
        }

        public static void LoginUser(string username, string password)
        {

        }

    }
}
