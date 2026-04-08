using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentDiary.Models;

namespace StudentDiary.Services
{
    public class AuthService
    {
        private readonly JsonService jsonService = new();

        public async Task<UserModel?> Login(string login, string password)
        {
            var users = await jsonService.LoadAsync<List<UserModel>>("users.json");

            return users?.FirstOrDefault(u =>
                u.Login == login && u.Password == password);
        }
    }
}