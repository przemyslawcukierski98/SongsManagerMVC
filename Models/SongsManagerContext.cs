using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsManagerMVC.Models
{
    public class SongsManagerContext : DbContext
    {
        public SongsManagerContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<SongModel> Songs { get; set; }
    }
}
