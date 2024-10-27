using ExamSystem.Models;
using ExamSystem.Services;
using System;

namespace ExamSystem.Controllers
{
    public class AccountController
    {
        private readonly FileService fileService;

        public AccountController()
        {
            fileService = new FileService();
        }

        public void Register()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            fileService.SaveUser(username, password, name, surname);
            Console.WriteLine("Registered Successfully!");
        }

        public User Login()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            bool isAuthenticated = fileService.CheckUserCredentials(username, password);
            if (isAuthenticated)
            {
                Console.WriteLine("Login Successfully!");
                return new User { Username = username };
            }
            else
            {
                Console.WriteLine("Unsuccessful Login! Username or password is incorrect.");
                return null;
            }
        }
    }
}