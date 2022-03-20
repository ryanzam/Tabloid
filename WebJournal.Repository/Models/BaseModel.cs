using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebJournal.Model
{
    public class BaseModel
    {
        public class BaseEntity
        {
            public int Id { get; set; }
            public DateTime? CreatedOn { get; set; }
        }
    }
}
