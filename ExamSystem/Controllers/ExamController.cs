using System;
using System.IO;

namespace ExamSystem
{
    public class ExamController
    {
        private const string MathFilePath = "math.txt";
        private const string LogicFilePath = "logic.txt";
        private const string EnglishFilePath = "english.txt";

        public void StartExam()
        {
            Console.WriteLine("Please choose an exam type:");
            Console.WriteLine("1. Math");
            Console.WriteLine("2. Logic");
            Console.WriteLine("3. English");

            string choice = Console.ReadLine();
            string filePath = "";

            switch (choice)
            {
                case "1":
                    filePath = MathFilePath;
                    break;
                case "2":
                    filePath = LogicFilePath;
                    break;
                case "3":
                    filePath = EnglishFilePath;
                    break;
                default:
                    Console.WriteLine("Wrong choice, going back to main menu...");
                    return;
            }

            if (File.Exists(filePath))
            {
                AskQuestionsFromFile(filePath);
            }
            else
            {
                Console.WriteLine("There's no such file");
            }
        }

        private void AskQuestionsFromFile(string filePath)
        {
            Console.WriteLine("\nExam Started. Please answer the questions:\n");

            string[] questions = File.ReadAllLines(filePath);
            int score = 0;

            foreach (var line in questions)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] parts = line.Split(';');
                    string question = parts[0].Trim();
                    string correctAnswer = parts[parts.Length - 1].Trim();

                    Console.WriteLine(question);

                    for (int i = 1; i < parts.Length - 1; i++)
                    {
                        Console.WriteLine(parts[i].Trim());
                    }

                    Console.Write("Enter your answer: ");
                    string userAnswer = Console.ReadLine();

                    if (userAnswer?.ToLower() == correctAnswer.ToLower())
                    {
                        Console.WriteLine("Correct!\n");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer: {correctAnswer}\n");
                    }
                }
            }

            Console.WriteLine($"The Exam Finished! Total Score: {score}/{questions.Length}");
        }
    }
}
