using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Bookmark.DAL.Entity;

namespace Bookmark.DAL.Infrastructure
{
    public class BookmarkDbContext:DbContext
    {
        public DbSet<BookmarkRecord> Bookmarks { get; set; }

        public BookmarkDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var connectionString = configuration.Build().GetSection("connectionString").GetSection("DefaultConnection").Value;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}