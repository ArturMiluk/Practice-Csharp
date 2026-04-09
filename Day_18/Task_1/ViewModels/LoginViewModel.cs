using System.ComponentModel;
using System.Threading.Tasks;
using StudentDiary.Models;
using StudentDiary.Services;

namespace StudentDiary.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly AuthService authService = new();

        private string login = string.Empty;
        public string Login
        {
            get => login;
            set
            {
                login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        private string password = string.Empty;
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public async Task<UserModel?> LoginUser()
        {
            return await authService.Login(Login, Password);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}