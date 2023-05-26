using BlogManager.DTO.PostDTOs;
using BlogManager.Entities;

namespace BlogManager.Interfaces
{
    public interface IPostService
    {
        public void Create(CreatePostDTO post);
        public void Update(UpdatePostDTO post ,int id);
        public List<Post> GetAll();
        public Post GetPost(int id);
        public void Delete(int id);
        public void ValidatePost(int id);

    }
}
