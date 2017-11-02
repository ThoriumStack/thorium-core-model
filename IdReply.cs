namespace MyBucks.Core.Model
{
    public class IdReply : ReplyBase
    {

        public static IdReply Success(string message, long refId)
        {
            return new IdReply()
            {
                ReplyStatus = ReplyStatus.Successful,
                ReplyMessage = message,
                RefId = refId
            };
        }

        public static new IdReply Failed(string message)
        {
            return new IdReply()
            {
                ReplyStatus = ReplyStatus.Failed,
                ReplyMessage = message,
            };
        }
        public long? RefId { get; set; }

        public static IdReply Failed(string failureMessage, long jobRefId)
        {
            return new IdReply()
            {
                ReplyStatus = ReplyStatus.Failed,
                ReplyMessage = failureMessage,
                RefId = jobRefId
            };
        }
    }
}
