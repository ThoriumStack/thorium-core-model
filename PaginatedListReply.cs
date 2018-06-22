namespace MyBucks.Core.Model
{
    public class PaginatedListReply<T> : ListReply<T>
    {
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
    }
}
