using Thorium.Core.Model.Abstractions;

namespace Thorium.Core.Model.DataModel
{
    public abstract class BaseContextModel : BaseModel, IBaseContextModel
    {
        public string Context { get; set; }
    }
}