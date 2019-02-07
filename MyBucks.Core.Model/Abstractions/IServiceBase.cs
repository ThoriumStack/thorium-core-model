namespace MyBucks.Core.Model.Abstractions
{
    public interface IServiceBase
    {
        string CurrentUserId { get; set; }
        string CurrentContext { get; set; }
        int CurrentTimeZoneOffset { get; set; }
    }
}