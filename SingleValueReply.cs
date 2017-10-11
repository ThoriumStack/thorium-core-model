namespace MyBucks.Core.Model
{
    public class SingleValueReply<T> : ReplyBase
    {
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

        public T Value { get; set; }
    }
}
