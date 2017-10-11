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
            return new ReplyBase(ReplyStatus.Failed, message);
        }

        public static TReturn Failed<TReturn>(string failureMessage) where TReturn : ReplyBase, new()
        {
            return new TReturn()
            {
                ReplyStatus = ReplyStatus.Failed,
                ReplyMessage = failureMessage
            };
        }

        public static ReplyBase Success(string message = "")
        {
            return new ReplyBase(ReplyStatus.Successful, message);
        }

        public static TReturn Success<TReturn>(string message = "") where TReturn : ReplyBase, new()
        {
            return new TReturn()
            {
                ReplyStatus = ReplyStatus.Successful,
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
    }

    public class RequestBaseObject
    {
        public string CustomerUniqueIdentifier { get; set; }
    }
}
