﻿using Bookmark.DAL.Entity;
using Bookmark.DAL.Infrastructure;
using Bookmark.DAL.Interfaces;
using LichtDataPack.Interfaces.DbTools;
using Microsoft.EntityFrameworkCore;

namespace Bookmark.DAL.Repository
{
    public class BookmarkRepository: GenericRepository<BookmarkRecord> ,IBookmarkRepository
    {
        private readonly BookmarkDbContext _context = new BookmarkDbContext();
        public BookmarkRepository(BookmarkDbContext context) : base(context )
        {
            context = _context;
        }
    }
}