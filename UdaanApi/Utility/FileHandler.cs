using System;
using System.IO;

namespace UdaanApi.Utility
{
    public class FileHandler
    {

        public string GetGetQuestionsList(string quizId)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Quiz", "Quiz"+quizId+".json");
            string questions = System.IO.File.ReadAllText(path);
            return questions;
        }

        public string GetQuestions(string questionId)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "QuestionsAndAnswers", "QnA"+questionId+".json");
            string question = System.IO.File.ReadAllText(path);
            return question;
        }

        public void WriteResponsesInFile()
        {

        }
    }
}



// QuizController params: quizid and pagination
//QuizController-> RequestHandler gets quizId and pagination details
// QuizHandler -> GetQuiz and Questions
