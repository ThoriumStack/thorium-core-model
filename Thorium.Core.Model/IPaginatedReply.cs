namespace Thorium.Core.Model
{
    public interface IPaginatedReply
    {
        int TotalItems { get; set; }
        int TotalPages { get; set; }
        
    }
}