namespace MyBucks.Core.Model
{
    public enum ReplyStatus
    {
        /// <summary>
        /// The call was successful
        /// </summary>
        Successful = 0,
        
        /// <summary>
        /// The call failed with an error
        /// </summary>
        Failed = 1,
        
        /// <summary>
        /// The requested resource was not found
        /// </summary>
        NotFound = 2,
        
        /// <summary>
        /// The user was not authorized to access a resource
        /// </summary>
        Unauthorized = 3,
        
        /// <summary>
        /// The call contained invalid input
        /// </summary>
        InvalidInput = 4,
        
    }
}
