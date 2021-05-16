using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UdaanApi.Models
{
    public class RequestData
    {
        public RequestData()
        {
            QuizId = null;
            StartingIndex = null;
            EndIndex = null;
        }
        public string QuizId { get; set; }

        public string StartingIndex { get; set; }

        public string EndIndex { get; set; }
    }
}
