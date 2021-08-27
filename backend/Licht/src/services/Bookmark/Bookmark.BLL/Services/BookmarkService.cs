using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Bookmark.BLL.Interfaces;
using Bookmark.DAL.Entity;
using Bookmark.DAL.Interfaces;
using Bookmark.DAL.Repository;
using LichtDataPack.Dtos.Bookmark;
using LichtDataPack.ViewModels;
using LichtDataPack.ViewModels.Bookmark;

namespace Bookmark.BLL.Services
{
    public class BookmarkService: IBookmarkService
    {
        private IMapper _mapper;
        private readonly IBookmarkRepository _repository;

        public BookmarkService(IMapper mapper , IBookmarkRepository bookmarkRepository)
        {
            _mapper = mapper;
            _repository = bookmarkRepository;
        }
        public async Task<IEnumerable<BookmarkViewModel>> GetAllBookmarks()
        {
            var bookmarks = _mapper.Map<IEnumerable<BookmarkViewModel>>(await _repository.GetAllAsync());
            //ToDo Add integrations Post and Articles using Kafka + GRPC
            return bookmarks;
        }

        public async Task<BookmarkViewModel> GetBookmarkById(int id)
        {
             var bookmark =  _mapper.Map<BookmarkViewModel>(await _repository.GetByIdAsync(id));
            //ToDo Add integrations Post and Articles using Kafka + GRPC
            return bookmark;
        }

        public async Task<BookmarkDto> AddBookmark(BookmarkDto bookmark)
        {
            await _repository.AddAsync(_mapper.Map<BookmarkRecord>(bookmark));
            return bookmark;
        }

        public async Task<BookmarkDto> UpdateBookmark(BookmarkDto bookmark)
        {
            await _repository.UpdateAsync(_mapper.Map<BookmarkRecord>(bookmark));
            return bookmark;
        }

        public async Task DeleteBookmark(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}