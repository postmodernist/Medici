using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Posts.DAL.Entities;
using Posts.DAL.Infrastructure;
using Posts.DAL.Interfaces;

namespace Posts.DAL.Repositories
{
    public class PostAttachmentRepository: GenericRepository<PostAttachment>,IPostAttachmentRepository
    {
        public PostDbContext _context = new PostDbContext();
        public PostAttachmentRepository(PostDbContext context) : base(context)
        {
            context = _context;
        }

        public async Task DeleteAttachmentsByPostId(int postId)
        {
            var entity = await _context.PostAttachments.FirstOrDefaultAsync(e => e.PostId == postId);
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity with id = {postId} does not exist");
            }

            try
            {
                _context.PostAttachments.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be deleted: {ex.Message}");
            }
        }
    }
}