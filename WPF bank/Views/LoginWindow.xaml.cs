using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_bank.Classes;
using WPF_bank.Controllers;
using WPF_bank.Managers;
namespace WPF_bank.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //run LoginController, if it returns true, run viewsControllern
            if(LoginController.Validateinput(txtUsername.Text, txtPassword.Password))
            {
                //Jag sätter den inloggade usern i logincontrollern om username och password stämmer överens.
                //loginuser
                
                if (UserManager.CurrentSignedInUser.GetType().Name == "Admin")
                {
                    AdminPanel adminPanel = new();
                    adminPanel.Show();
                    
                }else
                {
                    AccountWindow accountWindow = ViewsController.AccountWindow(true);
                    accountWindow.Show();
                }
                Close();

            }
            else
            {
                //om det blir false kommer den messagebox visas.
                return;
            }

        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Register RegisterWindow = ViewsController.Register();
            RegisterWindow.Show();
            Close();
        }
    }
}
