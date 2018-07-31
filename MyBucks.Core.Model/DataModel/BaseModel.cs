using System;
using System.ComponentModel.DataAnnotations;

using MyBucks.Core.Model.Abstractions;

namespace MyBucks.Core.Model.DataModel
{
    public abstract class BaseModel : IBaseModel
    {
        [Key]
        public int Id { get; set; }
        
        public string CreatedById { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        
        public string ModifiedById { get; set; }
        
        public DateTime? ModifiedDate { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }
    }
}