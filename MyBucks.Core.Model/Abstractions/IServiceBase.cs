namespace MyBucks.Core.Model.Abstractions
{
    public interface IServiceBase
    {
        int CurrentUserId { get; set; }
        string CurrentContext { get; set; }
    }
}