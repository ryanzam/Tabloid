using WebJournal.Model;

namespace WebJournal.Data.Posts
{
    public class PostRepo : BaseRepository<Post>, IPostRepo
    {
        public PostRepo(JournalContext context): base(context)
        {
        }
    }
}
