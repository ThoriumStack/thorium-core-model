using MyBucks.Core.Model.Abstractions;

namespace MyBucks.Core.Model.DataModel
{
    public abstract class BaseContextModel : BaseModel, IBaseContextModel
    {
        public string Context { get; set; }
    }
}