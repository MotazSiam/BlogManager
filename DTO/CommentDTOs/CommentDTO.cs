using BlogManager.Entities;

namespace BlogManager.DTO.CommentDTOs
{
    public class CommentDTO
    {
        public int id { get; set; }
        public string content { get; set; }
        public DateTime createdDate { get; set; }
        public int postId { get; set; }
        public Comment GetEntity()
        {
            return new Comment { Id = id, Content = content, CreatedDate = createdDate, PostId = postId };
        }

        public CommentDTO GetDTO(Comment enitity)
        {
            return new CommentDTO
            {
                id = enitity.Id,
                content = enitity.Content,
                createdDate = enitity.CreatedDate,
                postId = enitity.PostId,

            };
        }
    }
}
