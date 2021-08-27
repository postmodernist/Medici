using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Comment.DAL.Entites;


namespace Comment.DAL.Infrastructure
{
    public class CommentaryDbContext:DbContext
    {
        public DbSet<Commentary> Commentaries { get; set; }
        public DbSet<CommentaryAttachment> CommentaryAttachments { get; set; }
        public DbSet<CommentaryReply> CommentaryReplies { get; set; }
        public CommentaryDbContext()
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