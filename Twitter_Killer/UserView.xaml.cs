using System.Windows;

namespace Twitter_Killer
{
    public partial class UserView
    {
        public UserView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
        }
    }
}
