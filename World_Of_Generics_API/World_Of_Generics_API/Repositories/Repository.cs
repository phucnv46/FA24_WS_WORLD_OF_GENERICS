using AutoMapper;
using Microsoft.EntityFrameworkCore;
using World_Of_Generics_API.Data;
using World_Of_Generics_API.DTOs;
using World_Of_Generics_API.Models;

namespace World_Of_Generics_API.Repositories
{
    public class Repository<T,TDTO> where T : BaseModel where TDTO : BaseDTO
    {
        private readonly StoreDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        private readonly IMapper mapper;

        public Repository(StoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T Get(long id)
        {
            return _dbSet.Find(id) ?? throw new Exception("Khong tim thay Product");
        }

        public void Add(TDTO dTO)
        {
            var entity = mapper.Map<T>(dTO) ?? throw new ArgumentNullException("Lỗi mapping");
            entity.CreateAt = DateTime.Now;
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }



    }
}
