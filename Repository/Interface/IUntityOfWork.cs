using System.Threading.Tasks;
using Entity.Core;
using Repository.Implementation;

namespace Repository.Interface
{
    public interface IUntityOfWork
    {
           GenericRepository<Room> roomRepository { get; }
           GenericRepository<RoomType> roomTypeRepository { get; }
           GenericRepository<RoomRate> roomRateRepository { get; }
           GenericRepository<MealPlane> MealPlaneRepository { get; }
           GenericRepository<MealType> MealTypeRepository { get; }
           GenericRepository<MealPerPerson>MealPerPersonRepository { get; }
           Task<int>saveAsync();
           int saveAsyn();
    }
}