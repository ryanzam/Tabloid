using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebJournal.Model;

namespace WebJournal.Data
{
    public class PostRepo : IPostRepo
    {
        private readonly JournalContext _context;

        public PostRepo(JournalContext context)
        {
            _context = context;
        }

        public Post GetPost(int id)
        {
            return _context.Posts.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Post> GetPosts()
        {
            return _context.Posts.ToList();
        }

        public void CreatePost(Post post)
        {
            if(post == null)
            {
                throw new ArgumentNullException(nameof(post));
            }
            _context.Posts.Add(post);
        }

        public void UpdatePost(Post post)
        {
            if(post == null)
            {
                throw new ArgumentNullException(nameof(post));
            }

            var p = _context.Posts.FirstOrDefault(p => p.Id == post.Id);
            if (p == null)
            {
                throw new ArgumentNullException(nameof(post));
            }
            _context.Entry<Post>(p).CurrentValues.SetValues(post);
            _context.SaveChanges();
        }

        public void DeletePost(Post post)
        {
            if (post == null)
            {
                throw new ArgumentNullException(nameof(post));
            }
            _context.Posts.Remove(post);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}
