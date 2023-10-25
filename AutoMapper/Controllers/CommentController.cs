using AutoMapper;
using AutoMapper_DTO.Data;
using AutoMapper_DTO.DTO;
using AutoMapper_DTO.Model;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper_DTO.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CommentController :ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public CommentController(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context =  context;
        }
        [HttpPost]
        public async Task<ActionResult> MakeComment(CommentDTO commentDTO,int postID)
        {
            var comment = _mapper.Map<Comment>(commentDTO);
            comment.PostId = postID;
            _context.Add(comment);
            _context.SaveChanges();
            return Ok(comment);
        }
    }
}
