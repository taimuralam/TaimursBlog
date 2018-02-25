using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DomainDAL.DataAccessLayer;
using DomainDAL.Objects;

namespace DomainDAL.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private DomainContext _context = new DomainContext();

        public BlogRepository(DomainContext context)
        {
            _context = context;
        }


        public IList<Post> Posts(int pageNo, int pageSize)
        {
            var posts = _context.Posts.Where(p => p.Published).OrderByDescending(p => p.PostedOnDateTime)
                .Skip(pageNo * pageSize)
                .Take(pageSize)
                .Include(p => p.Category)
                .ToList();

            var postIds = posts.Select(p => p.Id).ToList();

            return _context.Posts.Where(p => postIds.Contains(p.Id))
                .OrderByDescending(p => p.PostedOnDateTime)
                .Include(p => p.Tags)
                .ToList();
        }

        public int TotalPosts()
        {
            if (_context != null)
            {
                return _context.Posts.Count(p => p.Published);
            }
            else
            {
                return 0;
            }
        }
    }
}
