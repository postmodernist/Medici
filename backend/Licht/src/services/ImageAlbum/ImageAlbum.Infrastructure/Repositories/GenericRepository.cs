﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ImageAlbum.Infrastructure.Interfaces;
using ImageAlbum.Infrastructure.MongoDbConfig;
using LichtDataPack.Interfaces.Entity;
using MongoDB.Driver;

namespace ImageAlbum.Infrastructure.Repositories
{
    public class GenericRepository<T>:IGenericRepository<T> where T: class, IEntity
    {
        private readonly IMongoCollection<T> _col;
        public GenericRepository(IMongoDbConfig settings, string CollectionName)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _col = database.GetCollection<T>(CollectionName);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _col.Find<T>(entity => true).ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await _col.Find<T>(entity => entity.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<bool> AddAsync(T entity)
        {
            try
            {
                await _col.InsertOneAsync(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(T newEntity)
        {
            try
            {
                var oldEntity = await _col.Find<T>(entity => entity.Id == newEntity.Id).FirstOrDefaultAsync();
                if (oldEntity == null)
                    return false;
                await _col.ReplaceOneAsync(oldEntity => oldEntity.Id == newEntity.Id, newEntity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            try
            {
                await _col.DeleteOneAsync(entity => entity.Id == Id);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
