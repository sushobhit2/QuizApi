using System;
using System.Collections.Generic;
using UdaanApi.Interfaces;
using UdaanApi.Utility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UdaanApi.Models
{
    public class QuizHandler :IQuizHandler
    {
        FileHandler _fileHandler;
        public QuizHandler()
        {
            _fileHandler = new FileHandler();
        }

        public Quiz GetQuiz(RequestData requestData)
        {
            JToken questionsList = GetQuestionsList(requestData.QuizId);
            Quiz quiz;

            if (requestData.StartingIndex == null)
            {
                quiz = GetQuestions(questionsList);
            }
            else
            {
                quiz = GetQuestions(questionsList, requestData.StartingIndex, requestData.EndIndex);
            }
            return quiz;
        }

        private JToken GetQuestionsList(string quizId)
        {
            string questions = _fileHandler.GetGetQuestionsList(quizId);

            JObject questionsInJson = JObject.Parse(questions);

            JToken questionsInList = questionsInJson["Questions"];
            return questionsInList;
        }

        private Quiz GetQuestions(JToken questionsIds)
        {
            Quiz quiz = new Quiz();
            foreach (var questionId in questionsIds)
            {
                QuestionDetails questionDetails = new QuestionDetails();
                questionDetails.Question = _fileHandler.GetQuestions(questionId.ToString());
                quiz.Questions.Add(questionDetails);
            }
            return quiz;
        }
        private Quiz GetQuestions(JToken questionIds, string startingIndex, string endingIndex)
        {

            Quiz quiz = new Quiz();
            int start = Int32.Parse(startingIndex);
            int end = Int32.Parse(endingIndex);
            for (int i = start; i <= end; i++)
            {
                QuestionDetails questionDetails = new QuestionDetails();

                var question = JObject.Parse(_fileHandler.GetQuestions(questionIds[i].ToString()));
                questionDetails.Question = question["Question"].ToString();
                quiz.Questions.Add(questionDetails);
            }
            return quiz;
        }
       
    }
}
