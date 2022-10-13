using Microsoft.EntityFrameworkCore;
using NotelyRestApi.Models;

namespace NotelyRestApi.Data
{
    public class NotelyDbContext : DbContext
    {
        public NotelyDbContext(DbContextOptions<NotelyDbContext> options) : base(options)
        {
                
        }

        public DbSet<Note> Notes => Set<Note>();
    }
}
