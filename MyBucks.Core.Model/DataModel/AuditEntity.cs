using System;
using System.Collections.Generic;
using System.Text;

namespace MyBucks.Core.Model.DataModel
{
    public class AuditEntity : InsertOnlyEntity
    {
        public string UserId { get; set; }
    }
}
