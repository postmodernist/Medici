using Bookmark.DAL.Entity;
using Bookmark.DAL.Infrastructure;
using Bookmark.DAL.Interfaces;
using LichtDataPack.Interfaces.DbTools;
using Microsoft.EntityFrameworkCore;

namespace Bookmark.DAL.Repository
{
    public class BookmarkRepository: GenericRepository<BookmarkRecord> ,IBookmarkRepository
    {
        public BookmarkRepository(BookmarkDbContext context) : base(context)
        {
        }
    }
}