using System;
using System.Collections.Generic;
using System.Text;

namespace MyBucks.Core.Model.DataModel
{
    public class InsertOnlyEntity : BaseEntity
    {
        public bool Active { get; set; } = true;
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
