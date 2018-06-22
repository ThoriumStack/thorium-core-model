namespace MyBucks.Core.Model
{
    public class PaginatedListReply<T> : ListReply<T>, IPaginatedReply
    {
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
    }
}
