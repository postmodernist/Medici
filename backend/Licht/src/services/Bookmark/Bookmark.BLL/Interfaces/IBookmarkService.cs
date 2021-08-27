using System.Collections.Generic;
using System.Threading.Tasks;
using LichtDataPack.Dtos.Bookmark;
using LichtDataPack.ViewModels;
using LichtDataPack.ViewModels.Bookmark;

namespace Bookmark.BLL.Interfaces
{
    public interface IBookmarkService
    {
        Task<IEnumerable<BookmarkViewModel>> GetAllBookmarks ();
        Task<BookmarkViewModel> GetBookmarkById (int id);
        Task<BookmarkDto> AddBookmark(BookmarkDto bookmark);
        Task<BookmarkDto> UpdateBookmark(BookmarkDto bookmark);
        Task DeleteBookmark(int id);
    }
}