using BlogManager.Entities;

namespace BlogManager.DTO.PostDTOs
{
    public class CreatePostDTO
    {
        public string title { get; set; }
        public string content { get; set; }
        public Post GetEntity()
        {
            return new Post
            {
                CreatedDate = DateTime.Now,
                Title = title,
                Content = content
            };

        }
    }
}
