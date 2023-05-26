using BlogManager.Entities;

namespace BlogManager.DTO.PostDTOs
{
    public class UpdatePostDTO
    {
        public string title { get; set; }
        public string content { get; set; }

        public Post UpdateEntity(Post entity)
        {
           entity.Title = title;
            entity.Content = content;

            return entity;
        }
    }
}
