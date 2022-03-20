using AutoMapper;
using WebJournal.Model;

namespace WebJournal.Profiles
{
    public class DefaultProfile: Profile
    {
        public DefaultProfile()
        {
            CreateMap<PostModel, Post>()
                .ForMember(m => m.CategoriesPost, opt => opt.Ignore())
                .ForMember(m => m.Comments, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<CategoryModel, Category>().ReverseMap();
            CreateMap<CommentModel, Comment>().ReverseMap();
        }
    }
}
