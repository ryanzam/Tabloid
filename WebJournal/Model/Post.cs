using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebJournal.Model
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public string Description { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Category> Categories { get; set; }
    }
}
