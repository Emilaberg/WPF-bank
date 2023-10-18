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
using WPF_bank.Controllers;

namespace WPF_bank.Views
{
    /// <summary>
    /// Interaction logic for register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (RegisterController.ValidateRegister(txtUsername.Text, txtPassword.Password, txtConfirmPassword.Password))
            {
                //Jag sätter den inloggade usern i logincontrollern om username och password stämmer överens.
                //loginuser
                AccountWindow accountWindow = ViewsController.AccountWindow(true);

                if (accountWindow == null)
                {
                    return;

                }
                accountWindow.Show();
                Close();
            }
            else
            {
                //om det blir false kommer den messagebox visas.
                return;
            }
        }
    }
}
