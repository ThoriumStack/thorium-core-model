using Thorium.Core.Model.Abstractions;

namespace Thorium.Core.Model.DtoModel
{
    public abstract class BaseContextDtoModel : BaseDtoModel, IBaseContextDtoModel
    {
        public string Context { get; set; }
    }
}