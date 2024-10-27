namespace ExamSystem.Models;

public class Category
{
    public string Name { get; set; }
    public List<Question> Questions { get; set; } = new List<Question>();
}