using AutoMapper;
using WebJournal.Model;

namespace WebJournal.Profiles
{
    public class DefaultProfile: Profile
    {
        public DefaultProfile()
        {
            CreateMap<Post, PostModel>();
            CreateMap<Category, CategoryModel>();
            CreateMap<Comment, CommentModel>();
        }
    }
}
