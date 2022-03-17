using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebJournal.Data;
using WebJournal.DTOs;
using WebJournal.Model;

namespace WebJournal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostRepo _repository;
        private readonly IMapper _mapper;

        private JournalContext _context;
        public PostController(IPostRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PostReadDTO>> GetPosts()
        {
            var posts = _repository.GetPosts();
            return Ok(_mapper.Map<IEnumerable<PostReadDTO>>(posts));
        }

        [HttpGet("{id}")]
        public ActionResult<PostReadDTO> GetPost(int id)
        {
            var post = _repository.GetPost(id);
            if(post != null)
            {
                return Ok(_mapper.Map<PostReadDTO>(post));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<PostReadDTO> CreatePost(PostCreateDTO postCreateDTO)
        {
            var postModel = _mapper.Map<Post>(postCreateDTO);
            _repository.CreatePost(postModel);
            _repository.SaveChanges();

            var postReadDTO = _mapper.Map<PostReadDTO>(postModel);

            return CreatedAtRoute(nameof(GetPost), new { Id = postReadDTO.Id }, postReadDTO);
        }

        [HttpPut("{id}")]
        public ActionResult UpdatePost(int id, PostupdateDTO postupdateDTO)
        {
            var postModelRepo = _repository.GetPost(id);
            if (postModelRepo == null)
            {
                return NotFound();
            }

            var postReadDTO = _mapper.Map<PostupdateDTO>(postModelRepo);

            _repository.UpdatePost(postModelRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePost(int id)
        {
            var postModelRepo = _repository.GetPost(id);
            if (postModelRepo == null)
            {
                return NotFound();
            }
            _repository.DeletePost(postModelRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
