using WebJournal.Model;

namespace WebJournal.Data.Comments
{
    public class CommentRepo : BaseRepository<Comment>, ICommentRepo
    {
        public CommentRepo(JournalContext context): base(context)
        {
        }
    }
}
