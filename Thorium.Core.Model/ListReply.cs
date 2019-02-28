using System.Collections.Generic;

namespace Thorium.Core.Model
{

    public class ListReply : ReplyBase
    {
        public object ResultList { get; protected set; }

        public List<T> GetList<T>()
        {
            return (List<T>) ResultList;
        }
        
    }
    
    public class ListReply<T> : ListReply
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

        public List<T> ResultList
        {
            get => base.GetList<T>();
            set => base.ResultList =  value;
        }

        public ListReply()
        {
            ResultList = new List<T>();
        }
        
        public ListReply(List<T> value)
        {

            ResultList = value;
        }
    }
    
    public static class ListreplyExtensions {
          
    }
}
