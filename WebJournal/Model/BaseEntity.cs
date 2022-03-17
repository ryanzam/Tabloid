using System;

namespace WebJournal.Model
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsPosted { get; set; }
        public DateTime PostedOn { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
