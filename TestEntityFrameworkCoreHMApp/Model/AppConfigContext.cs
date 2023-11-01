using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntityFrameworkCoreHMApp.Model
{
    internal class AppConfigContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-9A7DMMO\SQLEXPRESS1;
                                        Initial Catalog=playlist_db;
                                        Integrated Security=SSPI;
                                        TrustServerCertificate=True;");
        }
    }
}
