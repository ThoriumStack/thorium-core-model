using System;

namespace MyBucks.Core.Model
{
    public class ReplyBase
    {
        public ReplyStatus ReplyStatus { get; set; }
        public string ReplyMessage { get; set; }
        public string UniqueIdentifier { get; set; }
        public long TransactionRef { get; set; }

        public ReplyBase()
        {
            ReplyStatus = ReplyStatus.Successful;
            ReplyMessage = string.Empty;
        }

        public ReplyBase(ReplyStatus status, string message)
        {
            ReplyStatus = status;
            ReplyMessage = message;
        }

        public static ReplyBase Failed(string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                FailureAction?.Invoke(message);
            }
            return new ReplyBase(ReplyStatus.Failed, message);
        }

        public static TReturn Failed<TReturn>(string failureMessage) where TReturn : ReplyBase, new()
        {
            if (!string.IsNullOrWhiteSpace(failureMessage))
            {
                FailureAction?.Invoke(failureMessage);
            }
            return new TReturn()
            {
                ReplyStatus = ReplyStatus.Failed,
                ReplyMessage = failureMessage
            };
        }

        public static ReplyBase Success(string message = "")
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                SuccessAction?.Invoke(message);
            }
            return new ReplyBase(ReplyStatus.Successful, message);
        }

        public static TReturn Success<TReturn>(string message = "") where TReturn : ReplyBase, new()
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                SuccessAction?.Invoke(message);
            }
            return new TReturn()
            {
                ReplyStatus = ReplyStatus.Successful,
                ReplyMessage = message
            };
        }
        
        public static ReplyBase NotFound(string message = "")
        {
            return new ReplyBase(ReplyStatus.Successful, message);
        }

        public static TReturn NotFound<TReturn>(string message = "") where TReturn : ReplyBase, new()
        {
            return new TReturn()
            {
                ReplyStatus = ReplyStatus.NotFound,
                ReplyMessage = message
            };
        }
        
        public static ReplyBase Unauthorized(string message = "")
        {
            return new ReplyBase(ReplyStatus.Unauthorized, message);
        }

        public static TReturn Unauthorized<TReturn>(string message = "") where TReturn : ReplyBase, new()
        {
            return new TReturn()
            {
                ReplyStatus = ReplyStatus.Unauthorized,
                ReplyMessage = message
            };
        }

        public bool IsSuccessful()
        {
            return (ReplyStatus == ReplyStatus.Successful);
        }

        public override string ToString()
        {
            return $"Status: {ReplyStatus}, Message: {ReplyMessage}";
        }

        public static Action<string> SuccessAction { get; set; }
        public static Action<string> FailureAction { get; set; }
    }

    public class RequestBaseObject
    {
        public string CustomerUniqueIdentifier { get; set; }
    }

}
