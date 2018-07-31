using System;
using System.ComponentModel.DataAnnotations;

namespace MyBucks.Core.Model.Abstractions
{
    public interface IBaseDtoModel
    {
        [Key]
        int Id { get; set; }

        string CreatedById { get; set; }

        DateTime CreatedDate { get; set; }
        
        string ModifiedById { get; set; }

        DateTime? ModifiedDate { get; set; }
    }
}