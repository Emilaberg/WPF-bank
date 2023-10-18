
using WPF_bank.Managers;
namespace WPF_bank.Classes
{
    public class User
    {
        private int userId;
        public string? Username{ get; set; }
        private string? Password;

        public AccountManager AccountManager { get; set; } = new();
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

        public string GetInfo()
        {
            return $"Username: {Username} Salary account: {AccountManager.SalaryAccount.Salary} Savings Account: {AccountManager.SavingsAccount.Savings} Total funds: {AccountManager.SalaryAccount.Salary + AccountManager.SavingsAccount.Savings}";
        }
    }
}
