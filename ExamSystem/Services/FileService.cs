using System;
using System.IO;

namespace ExamSystem.Services
{
    public class FileService
    {
        private readonly string filePath = "users.txt";
        
        public void SaveUser(string username, string password, string name, string surname)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"{username};{password};{name};{surname}");
            }
        }
        
        public bool CheckUserCredentials(string username, string password)
        {
            if (!File.Exists(filePath))
                return false;

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var parts = line.Split(';');
                    if (parts[0] == username && parts[1] == password)
                    {
                        return true; 
                    }
                }
            }
            return false; 
        }
    }
}