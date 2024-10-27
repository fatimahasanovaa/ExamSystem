using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExamSystem.Models;

namespace ExamSystem.Services
{
    public class QuestionService
    {
        private readonly string _filePath = "Data/questions.txt";

        public List<Question> GetQuestionsByCategory(string category)
        {
            var questions = new List<Question>();
            var lines = File.ReadAllLines(_filePath);

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts[0] == category)
                {
                    questions.Add(new Question
                    {
                        Text = parts[1],
                        Options = parts[2].Split(',').ToList(),
                        CorrectAnswerIndex = int.Parse(parts[3])
                    });
                }
            }
            return questions;
        }
    }
}