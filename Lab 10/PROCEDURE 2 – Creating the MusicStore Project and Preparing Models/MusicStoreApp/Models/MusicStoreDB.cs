using Microsoft.EntityFrameworkCore;

namespace MusicStoreApp.Models
{
    public class MusicStoreDB : DbContext
    {
        public MusicStoreDB(DbContextOptions<MusicStoreDB> options)
            : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
    }
}
