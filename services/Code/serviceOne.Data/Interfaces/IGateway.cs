using MongoDB.Driver;

namespace serviceOne.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
