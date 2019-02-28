using System.ComponentModel.DataAnnotations;

namespace Thorium.Core.Model.Abstractions
{
    public interface IBaseDtoModel
    {
        [Key]
        int Id { get; set; }

//        string CreatedById { get; set; }
//
//        DateTime CreatedDate { get; set; }
//        
//        string ModifiedById { get; set; }
//
//        DateTime? ModifiedDate { get; set; }
    }
}