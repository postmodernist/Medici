namespace ImageAlbum.Infrastructure.MongoDbConfig
{
    public interface IMongoDbConfig
    {
        public string ConnectionString { get; set; }
        public string CollectionName { get; set; }
        public string DatabaseName { get; set; }
    }
}