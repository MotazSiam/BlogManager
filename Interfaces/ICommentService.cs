using BlogManager.DTO.CommentDTOs;
using BlogManager.Entities;

namespace BlogManager.Interfaces
{
    public interface ICommentService
    {
        public List<CommentDTO> GetCommentsByPost(int postId);
        public void Create(CreateCommentDTO commentDTO , int postId);

    }
}
