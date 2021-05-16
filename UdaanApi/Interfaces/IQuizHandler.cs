using System;
using UdaanApi.Models;

namespace UdaanApi.Interfaces
{
    public interface IQuizHandler
    {
        public Quiz GetQuiz(RequestData requestData);
    }
}
