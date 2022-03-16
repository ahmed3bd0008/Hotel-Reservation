using System;
using System.Threading.Tasks;
using Entity.Core;

namespace Repository.Interface
{
    public interface IRoomRepository:IGenericRepository<Room>
    {
         bool  isExist(int id);
    }
}