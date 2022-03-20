using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
