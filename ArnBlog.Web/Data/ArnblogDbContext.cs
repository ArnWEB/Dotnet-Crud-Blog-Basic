using ArnBlog.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ArnBlog.Web.Data
{
    public class ArnblogDbContext : DbContext
    {
        public ArnblogDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
