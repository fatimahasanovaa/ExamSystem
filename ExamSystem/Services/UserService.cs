using System.IO;
using System.Linq;
using ExamSystem.Models;

namespace ExamSystem.Services
{
    public class UserService
    {
        private readonly string _filePath = "Data/users.txt";

        public void RegisterUser(User user)
        {
            var userData = $"{user.Name},{user.Username},{user.Password}";
            File.AppendAllText(_filePath, userData + "\n");
        }

        public User LoginUser(string username, string password)
        {
            var users = File.ReadAllLines(_filePath);
            foreach (var line in users)
            {
                var parts = line.Split(',');
                if (parts[1] == username && parts[2] == password)
                {
                    return new User { Name = parts[0], Username = parts[1], Password = parts[2] };
                }
            }
            return null;
        }
    }
}