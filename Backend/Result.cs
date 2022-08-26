using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Backend
{
    public class Result<T>
    {
        public T Data { get; set; }

        public ErrorData Error { get; set; }

        public static Result<T> GetSuccess(T transferredData)
        {

            if (object.Equals(transferredData, default(T)) && typeof(T) != typeof(bool))
            {
                throw new ArgumentNullException("Default type is passed as result");
            }
            else
            {
                var transferredDataToReturn = new Result<T>()
                {
                    Data = transferredData,
                };

                return transferredDataToReturn;
            }
        }
        public static Result<T> GetError(int errorCode, string errorMessage)
        {
            var newResult = new Result<T>
            {
                Error = new ErrorData
                (
                    errorCode,
                    errorMessage
                ),
            };

            return newResult;
        }
        public static Result<T> GetError(int errorCode, IEnumerable<string> errorMessage)
        {
            var newResult = new Result<T>
            {
                Error = new ErrorData
                (
                    errorCode,
                    errorMessage
                ),
            };

            return newResult;
        }
    }
    public struct ErrorData
    {
        public ErrorData(int Code, IEnumerable<string> Message)
        {
            this.Code = Code;
            this.Message = Message;
        }
        public ErrorData(int Code, string Message)
        {
            this.Code = Code;
            this.Message = new string[] { Message };
        }
        public readonly int Code { get; }
        public readonly IEnumerable<string> Message { get; }
    }
}
