using EIP.Common.DataAccess;
using EIP.System.Models.Entities;

namespace EIP.System.DataAccess.Log
{
    public class SystemDataLogRepository : MongoDbAsyncRepository<SystemDataLog>, ISystemDataLogRepository
    {
        
    }
}