using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UdaanApi.Models;

namespace UdaanApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuizController : ControllerBase
    {
        public QuizHandler _quizHandler;
        public RequestDataHandler _requestDataHandler;
        public QuizController()
        {
            _quizHandler = new QuizHandler();
            _requestDataHandler = new RequestDataHandler();
        }

        [HttpGet]
        public Quiz Get()
        {
            var queryString = HttpContext.Request.Query;
            var requestData = _requestDataHandler.GetRequestData(queryString);

            var quizData = _quizHandler.GetQuiz(requestData);
            return quizData;
        }
    }
}
