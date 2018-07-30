using MyBucks.Core.Model.Abstractions;

namespace MyBucks.Core.Model.DtoModel
{
    public abstract class BaseContextDtoModel : BaseDtoModel, IBaseContextDtoModel
    {
        public string Context { get; set; }
    }
}