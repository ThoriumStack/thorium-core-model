using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBucks.Core.Model.Abstractions
{
    public interface IBaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int Id { get; set; }

        string CreatedById { get; set; }

        DateTime CreatedDate { get; set; }
        
        string ModifiedById { get; set; }

        DateTime? ModifiedDate { get; set; }

        [Timestamp]
        byte[] TimeStamp { get; set; }
    }
}