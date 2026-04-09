using System.Windows;
using StudentDiary.ViewModels;

namespace StudentDiary
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private async void OnLoginClick(object sender, RoutedEventArgs e)
        {
            var vm = new LoginViewModel
            {
                Login = loginBox.Text,
                Password = pwd.Password
            };

            var user = await vm.LoginUser();

            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }

            var main = new Window1();
            main.DataContext = new StudentViewModel(user.Role);
            main.Show();
            Close();
        }
    }
}