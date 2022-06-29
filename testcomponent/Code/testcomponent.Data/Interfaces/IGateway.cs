using MongoDB.Driver;

namespace testcomponent.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
