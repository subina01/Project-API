using Carrental.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Carrental.WebAPI.Data
{
    public partial class ApplicationDbContext: DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        

    }
}
