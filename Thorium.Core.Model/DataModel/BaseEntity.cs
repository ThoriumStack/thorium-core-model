using System;
using System.ComponentModel.DataAnnotations;

namespace Thorium.Core.Model.DataModel
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
