using System;

namespace Thorium.Core.Model.DataModel
{
    public class InsertOnlyEntity : BaseEntity
    {
        public bool Active { get; set; } = true;
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
