using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebJournal.Model;

namespace WebJournal.Data
{
    public interface IPostRepo
    {
        IEnumerable<Post> GetPosts();
        Post GetPost(int id);
        void CreatePost(Post post);
        void UpdatePost(Post post);
        void DeletePost(Post post);
        bool SaveChanges();
    }
}
