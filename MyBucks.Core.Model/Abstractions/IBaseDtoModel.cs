using System;
using System.ComponentModel.DataAnnotations;

namespace MyBucks.Core.Model.Abstractions
{
    public interface IBaseDtoModel
    {
        [Key]
        int Id { get; set; }

        int? CreatedById { get; set; }

        DateTime CreatedDate { get; set; }
        
        int? ModifiedById { get; set; }

        DateTime? ModifiedDate { get; set; }
    }
}