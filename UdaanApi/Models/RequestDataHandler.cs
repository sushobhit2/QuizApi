using System;
using Microsoft.AspNetCore.Http;

namespace UdaanApi.Models
{
    public class RequestDataHandler
    {
        public RequestData GetRequestData(IQueryCollection queryCollection)
        {
            RequestData requestData = new RequestData();
            requestData.QuizId = queryCollection["_id"];

            if (queryCollection.ContainsKey("startingIndex"))
            {
                requestData.StartingIndex = queryCollection["startingIndex"];
                requestData.EndIndex = queryCollection["endIndex"];

            }

            return requestData;
        }
    }
}
