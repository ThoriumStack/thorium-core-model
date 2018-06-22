namespace MyBucks.Core.Model
{
    public class IdReply : ReplyBase
    {

        public new static IdReply Success(long refId, string message="")
        {
            return new IdReply()
            {
                ReplyStatus = ReplyStatus.Successful,
                ReplyMessage = message,
                RefId = refId
            };
        }

        public new static IdReply Failed(string message)
        {
            return new IdReply()
            {
                ReplyStatus = ReplyStatus.Failed,
                ReplyMessage = message,
            };
        }
        public long? RefId { get; set; }

        public static IdReply Failed(long id, string failureMessage)
        {
            return new IdReply()
            {
                ReplyStatus = ReplyStatus.Failed,
                ReplyMessage = failureMessage,
                RefId = id
            };
        }
    }
}
