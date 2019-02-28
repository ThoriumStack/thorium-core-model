namespace Thorium.Core.Model
{
    public class IdReply : ReplyBase
    {

        public long? RefId { get; set; }
        
        public new static IdReply Success(long refId, string message="")
        {
            return new IdReply()
            {
                ReplyStatus = ReplyStatus.Successful,
                ReplyMessage = message,
                RefId = refId
            };
        }
        
        public new static IdReply Success(int refId, string message="")
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
        

        public static IdReply Failed(long id, string failureMessage)
        {
            return new IdReply()
            {
                ReplyStatus = ReplyStatus.Failed,
                ReplyMessage = failureMessage,
                RefId = id
            };
        }
        
        public static IdReply Failed(int id, string failureMessage)
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
