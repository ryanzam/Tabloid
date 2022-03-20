using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebJournal.Model;

namespace WebJournal.Data
{
    public class IEntityRepositiory
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(int id);
        void CreatePost(Post post);
        void UpdatePost(Post post);
        void DeletePost(Post post);
        bool SaveChanges();
    }
}
