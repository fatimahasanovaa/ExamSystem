using System;
using System.IO;

namespace ExamSystem
{
    public class FileCreator
    {
        public static void CreateExamFiles()
        {
            CreateFile("math.txt", new string[]
            {
                "1 + 1 ?; a) 1; b) 2; c) 3; d) 4; b",
                "5 * 3 ?; a) 15; b) 10; c) 20; d) 25; a",
                "9 - 4 ?; a) 2; b) 5; c) 4; d) 6; b",
                "16 / 4 ?; a) 2; b) 4; c) 5; d) 6; b",
                "7 + 6 ?; a) 13; b) 12; c) 11; d) 10; a",
                "10 * 2 ?; a) 15; b) 10; c) 20; d) 30; c",
                "20 - 8 ?; a) 10; b) 15; c) 12; d) 8; c",
                "15 + 4 ?; a) 19; b) 20; c) 21; d) 22; a",
                "50 / 5 ?; a) 8; b) 9; c) 10; d) 11; c",
                "12 + 3 ?; a) 15; b) 14; c) 16; d) 17; a"
            });

            CreateFile("logic.txt", new string[]
            {
                "Julia's mother named her four daughters February, March, and April. What is the name of her other daughter?\na) May; b) Julia; c) January; d) June; b",
                "A train is going north, and the wind is blowing from the east. In which direction does the train's smoke go?\na) East; b) West; c) North; d) South; d",
                "There are 10 birds on a tree, and a hunter shoots one of them. How many birds are left?\na) 9; b) 10; c) 0; d) 1; c",
                "On an island, there are only people who lie and people who tell the truth. If a man says, 'I am lying,' who is this man?\na) Truth-teller; b) Liar; c) Unknown; d) Nonsense; a",
                "A farm has 10 sheep, 20 cows, and 40 chickens. How many legs does the farmer have?\na) 2; b) 4; c) 20; d) 0; a",
                "In a children's race, if you pass the child in 2nd place, which place are you in?\na) 1st; b) 2nd; c) 3rd; d) 4th; b",
                "A house has 4 floors, and each floor has 3 windows. How many windows are there in total?\na) 12; b) 15; c) 9; d) 18; a",
                "A fully loaded truck is crossing a bridge. If the load falls when the driver stops in the middle, what happens?\na) The bridge collapses; b) The load falls; c) The truck tips over; d) The load is unloaded; b",
                "Which animal has no threshold?\na) Fish; b) Dog; c) Cat; d) Horse; a",
                "There are 5 apples to be shared among 3 people. Each person takes an apple. How many apples are left?\na) 1; b) 2; c) 3; d) 0; a"
            });

            CreateFile("english.txt", new string[]
            {
                "What is the capital of England?\na) London; b) Paris; c) Rome; d) Madrid; a",
                "The opposite of 'hot' is?\na) Warm; b) Cold; c) Cool; d) Ice; b",
                "How many letters are in the English alphabet?\na) 25; b) 26; c) 24; d) 27; b",
                "What color do you get when you mix red and blue?\na) Green; b) Purple; c) Orange; d) Yellow; b",
                "Which day comes after Tuesday?\na) Thursday; b) Friday; c) Monday; d) Wednesday; d",
                "What is the opposite of 'up'?\na) Down; b) Left; c) Right; d) Top; a",
                "How many months are in a year?\na) 10; b) 12; c) 11; d) 13; b",
                "What is the first letter of the alphabet?\na) B; b) C; c) A; d) D; c",
                "Which animal says 'meow'?\na) Dog; b) Cow; c) Cat; d) Bird; c",
                "What is the color of the sky on a clear day?\na) Red; b) Blue; c) Yellow; d) Green; b"
            });

            Console.WriteLine("The exam files created successfully.");
        }

        private static void CreateFile(string fileName, string[] questions)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var question in questions)
                {
                    writer.WriteLine(question);
                }
            }
        }
    }
}
