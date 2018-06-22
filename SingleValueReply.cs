namespace MyBucks.Core.Model
{
    public abstract class SingleValueReply : ReplyBase {
        public object Value { get; set; }
    }
    
    public class SingleValueReply<T> : SingleValueReply
    {
        private T _value;

        public SingleValueReply()
        {
        }

        public static SingleValueReply<TNew> Success<TNew>(TNew value, string successMessage = "")
        {
            return new SingleValueReply<TNew>(value) { ReplyStatus = ReplyStatus.Successful, ReplyMessage = successMessage };
        }

        public static SingleValueReply<TNew> Failed<TNew>(TNew value, string failureMessage)
        {
            return new SingleValueReply<TNew>()
            {
                ReplyStatus = ReplyStatus.Failed,
                Value = value,
                ReplyMessage = failureMessage
            };
        }

        public SingleValueReply(T value)
        {
            Value = value;
        }

        public new T Value
        {
            get => _value;
            set
            {
                _value = value;
                base.Value = value;
            }
        }
    }
}
