using ExamSystem.Controllers;
using ExamSystem.Models;
using System;

namespace ExamSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            FileCreator.CreateExamFiles();

        Start:
            var accountController = new AccountController();
            var examController = new ExamController();
            User loggedInUser = null;

            while (true)
            {
                if (loggedInUser == null)
                {
                    Console.WriteLine("1. Register");
                    Console.WriteLine("2. Login");
                    Console.WriteLine("3. Exit");

                    Console.Write("Your choice: ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        accountController.Register();
                    }
                    else if (choice == "2")
                    {
                        loggedInUser = accountController.Login();
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("Closing....");
                        return; 
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice, please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Choose one:");
                    Console.WriteLine("1. Start Exam");
                    Console.WriteLine("2. Exit Exam");
                  

                    Console.Write("Your choice: ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        examController.StartExam();
                    }
                  
                    else if (choice == "2")
                    {
                        Console.WriteLine("Exited");
                        loggedInUser = null;
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice");
                    }
                }
            }
        }
    }
}
