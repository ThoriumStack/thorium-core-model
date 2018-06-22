namespace MyBucks.Core.Model
{
    public interface IPaginatedReply
    {
        int TotalItems { get; set; }
        int TotalPages { get; set; }
    }
}