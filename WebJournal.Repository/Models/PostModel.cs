using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebJournal.Model
{
    public class PostModel: BaseModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public string Description { get; set; }
        public List<CommentModel> Comments { get; set; }
        public List<CategoryModel> CategoriesPost { get; set; }
    }
}
