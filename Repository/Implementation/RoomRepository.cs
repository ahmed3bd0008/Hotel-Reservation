using System;
using System.Linq;
using System.Threading.Tasks;
using Entity.Core;
using Repository.Context;
using Repository.Interface;

namespace Repository.Implementation
{
    public class RoomRepository:GenericRepository<Room>,IRoomRepository
    {
        private readonly AppDbContextTest _appDbContext;

        public RoomRepository(AppDbContextTest appDbContext):base(appDbContext)
        {
            _appDbContext=appDbContext;
        }
      
         bool IRoomRepository.isExist(int id)
        {
          return  _appDbContext.Rooms.Any(d=>d.Id==id);
        }
    }
}