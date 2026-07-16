using Hackathon.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.API.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Note> Notes => Set<Note>();
    }
}