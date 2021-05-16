using System;
using System.Collections.Generic;

namespace UdaanApi.Models
{
    public class Quiz
    {
        public Quiz()
        {
            Questions = new List<QuestionDetails>();
        }   
        public List<QuestionDetails> Questions { get; set; }
    }
}
