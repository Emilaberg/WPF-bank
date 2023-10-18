
using System.Windows;
using System.Windows.Controls;
using WPF_bank.Classes;
using WPF_bank.Controllers;
using WPF_bank.Managers;

namespace WPF_bank.Views
{
    /// <summary>
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
            InitializeUi();
        }

        private void InitializeUi()
        {
            txtLoggedInType.Content = UserManager.CurrentSignedInUser.GetType().Name;
            txtUser.Content = UserManager.CurrentSignedInUser.Username;
            UpdateUi();

        }
        private void UpdateUi()
        {
            lstUsers.Items.Clear();
            foreach (User user in UserManager.Users)
            {
                
                ListViewItem item = new();
                item.Content = user.GetInfo();
                item.Tag = user;
                if (user.GetType().Name == "Admin")
                {
                    item.IsEnabled = false;
                }
                lstUsers.Items.Add(item);
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BtnRemove.Opacity = 1;

        }

        private void TxtLogOut_Click(object sender, RoutedEventArgs e)
        {
            ViewsController.Logout().Show();
            Close();
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            

            if(MessageBox.Show("YOU ARE ABOUT TO REMOVE A USERACCOUNT, DO YOU WANT TO PROCEED?", "WARNING", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ListViewItem selectedItem = (ListViewItem)lstUsers.SelectedItem;
                User selectedUser = (User)selectedItem.Tag;

                UserManager.Users.RemoveAll(e => e.GetUserId() == selectedUser.GetUserId());
                UpdateUi();
            }
            
            
        }
    }
}
