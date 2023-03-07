using Microsoft.EntityFrameworkCore;
using moment4.Models;

namespace moment4.Data
{

    public class SongListContext : DbContext
    {
        public SongListContext(DbContextOptions<SongListContext> options) : base(options) { }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
