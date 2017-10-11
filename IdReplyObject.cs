namespace MyBucks.Core.Model
{
    public class IdReplyObject : ReplyBase
    {

        public static IdReplyObject Success(string message, long refId)
        {
            return new IdReplyObject()
            {
                ReplyStatus = ReplyStatus.Successful,
                ReplyMessage = message,
                RefId = refId
            };
        }

        public static new IdReplyObject Failed(string message)
        {
            return new IdReplyObject()
            {
                ReplyStatus = ReplyStatus.Failed,
                ReplyMessage = message,
            };
        }
        public long? RefId { get; set; }

        public static IdReplyObject Failed(string failureMessage, long jobRefId)
        {
            return new IdReplyObject()
            {
                ReplyStatus = ReplyStatus.Failed,
                ReplyMessage = failureMessage,
                RefId = jobRefId
            };
        }
    }
}
