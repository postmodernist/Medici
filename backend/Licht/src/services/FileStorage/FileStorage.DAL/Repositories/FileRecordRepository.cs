using FileStorage.DAL.Entities;
using FileStorage.DAL.Infrastructure;
using FileStorage.DAL.Interfaces;

namespace FileStorage.DAL.Repositories
{
    public class FileRecordRepository: GenericRepository<FileRecord>, IFileRecordRepository
    {
        public FileRecordRepository(FileDbContext context) : base(context)
        {

        }
    }
}