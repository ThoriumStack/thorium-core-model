namespace MyBucks.Core.Model
{
    public class PagedReportReply<T> : ListReply<T>
    {
        public int TotalRecordCount { get; set; }
        public int TotalPageCount { get; set; }
    }
}
