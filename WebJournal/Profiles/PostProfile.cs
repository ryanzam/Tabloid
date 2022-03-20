using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebJournal.DTOs;
using WebJournal.Model;

namespace WebJournal.Profiles
{
    public class PostProfile: Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostReadDTO>();
            CreateMap<PostCreateDTO, Post>();
            CreateMap<PostupdateDTO, Post>();
        }
    }
}
