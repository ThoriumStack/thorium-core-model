using System.Collections.Generic;

namespace MyBucks.Core.Model
{
    public class ListReply<T> : ReplyBase
    {
        public static ListReply<T> Success(List<T> value, string successMessage = "")
        {
            return new ListReply<T>(value)
            {
                ReplyStatus = ReplyStatus.Successful,
                ReplyMessage = successMessage
            };
        }

        public new static ListReply<T> Failed(string failureMessage)
        {
            return new ListReply<T>()
            {
                ReplyStatus = ReplyStatus.Failed,
                ReplyMessage = failureMessage
            };
        }

        public List<T> ResultList { get; set; }


        public ListReply()
        {
            ResultList = new List<T>();
        }
        public ListReply(List<T> value)
        {

            ResultList = value;
        }
    }
}
