using System.Threading.Tasks;
using Entity.Core;
using Repository.Context;
using Repository.Interface;
namespace Repository.Implementation
{
    public class UntityOfWork : IUntityOfWork
    {
        private readonly AppDbContextTest _context;
        private  RoomRepository _genericRepository;
        private  GenericRepository<RoomType> _roomTypeRepository;
        private  GenericRepository<RoomRate> _roomRateRepository;
        private  GenericRepository<MealPlane> _mealPlaneRepository;
        private  GenericRepository<MealPerPerson> _mealPerPersonRepository;
        private  GenericRepository<MealType> _mealTypeRepository;
        private  GenericRepository<Person> _personRepository;

        public UntityOfWork(AppDbContextTest context)
        {
            _context=context;
        }
         public GenericRepository<Room> roomRepository {
              get{
                  if(_genericRepository==null)
                            _genericRepository=new RoomRepository(_context);
                return  _genericRepository;
              } 
              }
        public GenericRepository<RoomType> roomTypeRepository{
              get{
                  if(_roomTypeRepository==null)
                            _roomTypeRepository=new GenericRepository<RoomType>(_context);
                return  _roomTypeRepository;
              } 
        }

        public GenericRepository<RoomRate> roomRateRepository {
             get{
                  if(_roomRateRepository==null)
                            _roomRateRepository=new GenericRepository<RoomRate>(_context);
                return  _roomRateRepository;
              } 
        }

        public GenericRepository<MealPlane> MealPlaneRepository {
             get{
                  if(_mealPlaneRepository==null)
                            _mealPlaneRepository=new GenericRepository<MealPlane>(_context);
                return  _mealPlaneRepository;
              } 
        }

        public GenericRepository<MealType> MealTypeRepository {
             get{
                  if(_mealTypeRepository==null)
                            _mealTypeRepository=new GenericRepository<MealType>(_context);
                return  _mealTypeRepository;
              } 
        }

        public GenericRepository<MealPerPerson> MealPerPersonRepository {
             get{
                  if(_mealPerPersonRepository==null)
                            _mealPerPersonRepository=new GenericRepository<MealPerPerson>(_context);
                return  _mealPerPersonRepository;
              } 
        }

        public int saveAsyn()
        {
            return _context.SaveChanges();
        }

        public async Task<int> saveAsync()
        {
          return await  _context.SaveChangesAsync();
        }
    }
}