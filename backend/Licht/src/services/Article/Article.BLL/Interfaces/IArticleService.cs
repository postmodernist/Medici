using System.Collections.Generic;
using System.Threading.Tasks;
using LichtDataPack.Dtos.Article;

namespace Article.BLL.Interfaces
{
    public interface IArticleService
    {
        Task<IEnumerable<ArticleDto>> GetAllArticles();
        Task<ArticleDto> GetArticleById(int id);
        Task<ArticleDto> AddArticle(ArticleDto article);
        Task<ArticleDto> UpdateArticle(ArticleDto article);
        Task DeleteArticle(int id);
    }
}