using BlogManager.DTO.PostDTOs;
using BlogManager.Entities;
using BlogManager.Interfaces;

namespace BlogManager.Services
{
    public class PostService : IPostService
    {
        private readonly IGenericRepository<Post> Repo;
        public PostService(IGenericRepository<Post> repo)
        {
            Repo = repo;
        }

        public void Create(CreatePostDTO postDTO)
        {
            var entity = postDTO.GetEntity();

            Repo.Insert(entity);
            Repo.Save();
        }

        public List<Post> GetAll()
        {
            var posts = Repo.GetAll().Value.ToList();
            return posts; 
        }

        public Post GetPost(int id)
        {
           var post = Repo.GetById(id);
            return post;
        }

        public void Update(UpdatePostDTO post, int id)
        {
            ValidatePost(id);
            var entity = Repo.GetById(id);
            entity = post.UpdateEntity(entity);
            
            Repo.Update(entity);
            Repo.Save();
        }
        public void Delete(int id)
        {
            ValidatePost(id);
            var entity = Repo.GetById(id);
            Repo.Delete(entity);
            Repo.Save();
        }

        public void ValidatePost(int id)
        {
            var entity = Repo.GetById(id);
            if (entity == null)
            {
                throw new Exception("Post Not exist");
            }
        }
    }
}
