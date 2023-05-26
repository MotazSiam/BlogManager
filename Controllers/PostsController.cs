using BlogManager.DTO.CommentDTOs;
using BlogManager.DTO.PostDTOs;
using BlogManager.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogManager.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostsController : Controller
    {
        private readonly IPostService postService;

        private readonly ICommentService commentService;

        public PostsController(IPostService postService, ICommentService commentService)
        {
            this.postService = postService;
            this.commentService = commentService;
        }

        [HttpGet]
        public ActionResult<List<PostDTO>> GetAll ()
        {
            var result = postService.GetAll();
            return Ok(result);
        }
        [HttpGet("/{id}")]
        public ActionResult<PostDTO> Get(int id)
        {
            var result = postService.GetPost(id);
            return Ok(result);
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreatePostDTO request)
        {
            postService.Create(request);
            return Ok();
        }
        [HttpPut]
        public ActionResult Update([FromBody] UpdatePostDTO request , int postId)
        {
            postService.Update(request, postId);
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            postService.Delete(id);
            return Ok();
        }

        [HttpGet("{post_id}/comments")]
        public ActionResult<List<CommentDTO>> GetComments(int post_id)
        {
            var result = commentService.GetCommentsByPost(post_id);
            return result;
        }

        [HttpPost("{post_id}/comments")]
        public ActionResult CreateComment([FromBody]CreateCommentDTO request , int post_id)
        {
            commentService.Create(request , post_id );
            return Ok();
        }

        
    }
}
