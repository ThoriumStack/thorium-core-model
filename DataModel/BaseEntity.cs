using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MyBucks.Core.Model.DataModel
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Key]
        public long RefId { get; set; }

        public override string ToString()
        {
            return $"RefId :{RefId}";
        }
    }
}
