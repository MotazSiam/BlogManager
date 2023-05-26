using BlogManager.Entities;

namespace BlogManager.DTO.CommentDTOs
{
    public class CreateCommentDTO
    {
        public string content { get; set; }
        public Comment GetEntity()
        {
            return new Comment
            {
                Content = content,
                CreatedDate = DateTime.Now
            };
        }
    }
}
