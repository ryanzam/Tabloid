using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebJournal.Model
{
    public class Comment : BaseEntity
    {
        public string Description { get; set; }
        public string Commentor { get; set; }
        public Post Post { get; set; }
    }
}
