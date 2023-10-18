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
using WPF_bank.Managers;

namespace WPF_bank.Views
{
    /// <summary>
    /// Interaction logic for AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        string LastPressed = "";
        public AccountWindow()
        {
            InitializeComponent();
            InitializeUi();
        }

        private void ToggleVisibility(object sender, RoutedEventArgs e)
        {

            BtnExecuteTransfer.Visibility = Visibility.Visible;
            
            Button btn = (Button)sender;
            

            if(btn.Name == LastPressed)
            {
                LastPressed = "";
                switch (btn.Name)
                {
                    case "btnSalaryDeposit":
                    case "btnSalaryWithdraw":
                    case "btnSavingsDeposit":
                    case "btnSavingsWithdraw":
                        lblAmount.Visibility = Visibility.Hidden;
                        txtAmount.Visibility = Visibility.Hidden;
                        
                        break;
                    case "BtnTransfer":

                        //FROM ACCOUNT
                        lblFromAccount.Visibility = Visibility.Hidden;
                        txtFromAccount.Visibility = Visibility.Hidden;

                        //TO ACCOUNT
                        lblToAccount.Visibility = Visibility.Hidden;
                        txtToAccount.Visibility = Visibility.Hidden;

                        //AMOUNT
                        lblAmount.Visibility = Visibility.Hidden;
                        txtAmount.Visibility = Visibility.Hidden;
                        
                        break;
                }
                
            }else
            {
                //reset all
                lblAmount.Visibility = Visibility.Hidden;
                txtAmount.Visibility = Visibility.Hidden;
                //FROM ACCOUNT
                lblFromAccount.Visibility = Visibility.Hidden;
                txtFromAccount.Visibility = Visibility.Hidden;
                //TO ACCOUNT
                lblToAccount.Visibility = Visibility.Hidden;
                txtToAccount.Visibility = Visibility.Hidden;
                //AMOUNT
                lblAmount.Visibility = Visibility.Hidden;
                txtAmount.Visibility = Visibility.Hidden;

                switch (btn.Name)
                {
                    case "btnSalaryDeposit":
                    case "btnSalaryWithdraw":
                    case "btnSavingsDeposit":
                    case "btnSavingsWithdraw":
                        lblAmount.Visibility = Visibility.Visible;
                        txtAmount.Visibility = Visibility.Visible;

                        break;
                    case "BtnTransfer":
                        //FROM ACCOUNT
                        lblFromAccount.Visibility = Visibility.Visible;
                        txtFromAccount.Visibility = Visibility.Visible;

                        //TO ACCOUNT
                        lblToAccount.Visibility = Visibility.Visible;
                        txtToAccount.Visibility = Visibility.Visible;

                        //AMOUNT
                        lblAmount.Visibility = Visibility.Visible;
                        txtAmount.Visibility = Visibility.Visible;
                        break;
                }
                LastPressed = btn.Name;
            }
            
        }
        private void InitializeUi()
        {
            //updates header
            txtLoggedInType.Content = $"{UserManager.CurrentSignedInUser!.GetType().Name}";
            txtUser.Content = UserManager.CurrentSignedInUser.Username;
            //Main header
            txtWelcome.Content = $"Welcome Back {UserManager.CurrentSignedInUser.Username}";

            //Account
            
            txtSalary.Text = UserManager.CurrentSignedInUser.AccountManager.SalaryAccount.Salary.ToString();
            txtSavings.Text = UserManager.CurrentSignedInUser.AccountManager.SavingsAccount.Savings.ToString();

        }

        private void TxtLogOut_Click(object sender, RoutedEventArgs e)
        {
            ViewsController.Logout().Show();
            Close();
        }
    }
}
