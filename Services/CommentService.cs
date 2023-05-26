using BlogManager.DTO.CommentDTOs;
using BlogManager.Entities;
using BlogManager.Interfaces;

namespace BlogManager.Services
{
    public class CommentService : ICommentService
    {
        private readonly IGenericRepository<Comment> Repo;
        private readonly IPostService postService;
        public CommentService(IGenericRepository<Comment> repo , IPostService PostService)
        {
            Repo = repo;
            postService = PostService;
        }

        public void Create(CreateCommentDTO commentDTO, int postId)
        {
            postService.ValidatePost(postId);
           var entity = commentDTO.GetEntity();
            entity.PostId = postId;
            Repo.Insert(entity);
            Repo.Save();
        }

        public List<CommentDTO> GetCommentsByPost(int postId)
        {
            postService.ValidatePost(postId);
            var entities = Repo.GetAll(comment=>comment.PostId == postId ).Value.ToList();
            var result = entities.Select(comment=>new  CommentDTO().GetDTO(comment)).ToList();
            return result;
        }
         
    }
}
