using System.Collections.Generic;
using System.Linq;

namespace MyBucks.Core.Model
{

    public class ListReply : ReplyBase
    {
        public List<object> ResultList { get; set; }
    }
    
    public class ListReply<T> : ListReply
    {
        private List<T> _resultList;

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
            get => _resultList;
            set
            {
                _resultList = value;
                base.ResultList =  _resultList.Cast<object>().ToList();
            }
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
}
