using WebJournal.Model;

namespace WebJournal.Data.Categories
{
    public class CategoryRepo : BaseRepository<Category>, ICategoryRepo
    {
        public CategoryRepo(JournalContext context) : base(context)
        {
        }
    }
}
