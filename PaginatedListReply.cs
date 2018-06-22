using System.Collections.Generic;
using System.Linq;

namespace MyBucks.Core.Model
{
    
    public class PaginatedListReply<T> : ListReply<T>
    {
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }

        public List<object> ObjectList => base.ResultList.Cast<object>().ToList();
    }
}
