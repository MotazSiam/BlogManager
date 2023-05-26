using BlogManager.Entities;

namespace BlogManager.DTO.PostDTOs
{
    public class PostDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime createdDate { get; set; }
       public PostDTO GetDTO (Post entity)
        {
            return new PostDTO
            {
                id = entity.Id,
                title = entity.Title,
                content = entity.Content,
                createdDate = entity.CreatedDate,
            };
        }
    }
}
