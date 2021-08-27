using System.Collections.Generic;
using System.Threading.Tasks;
using Article.BLL.Interfaces;
using Article.DAL.Entities;
using Article.DAL.Interfaces.Repositories;
using Article.DAL.Repositories;
using AutoMapper;
using LichtDataPack.Dtos.Article;

namespace Article.BLL.Services
{
    public class ArticleService: IArticleService
    {
        private readonly ArticleRepository articleRepository;
        private IMapper _mapper;
        public ArticleService(IMapper mapper)
        {
            articleRepository = new ArticleRepository();
            _mapper = mapper;
        }
        public async Task<IEnumerable<ArticleDto>> GetAllArticles()
        {
            return  _mapper.Map<IEnumerable<ArticleDto>>(await articleRepository.GetAllAsync());
        }

        public async Task<ArticleDto> GetArticleById(int id)
        {
            return _mapper.Map<ArticleDto>(await articleRepository.GetByIdAsync(id));
        }

        public async Task<ArticleDto> AddArticle(ArticleDto article)
        {
            await articleRepository.AddAsync(_mapper.Map<ArticleRecord>(article));
            return article;
        }

        public async Task<ArticleDto> UpdateArticle(ArticleDto article)
        {
            await articleRepository.UpdateAsync(_mapper.Map<ArticleRecord>(article));
            return article;
        }

        public async Task DeleteArticle(int id)
        {
            await articleRepository.DeleteAsync(id);
        }
    }
}