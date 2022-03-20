using System;
using System.ComponentModel.DataAnnotations;

namespace WebJournal.Model
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
