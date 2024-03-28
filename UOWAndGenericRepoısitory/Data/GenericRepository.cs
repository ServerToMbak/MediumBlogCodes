using UOWAndGenericRepoısitory.Entities;
using Microsoft.EntityFrameworkCore;

namespace UOWAndGenericRepoısitory.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {

        public readonly ApplicationDbContext _context;
        public DbSet<T> entity => _context.Set<T>();
        // your db context
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context ;
        }

    

        public void Add(T entity)
        {
            this.entity.Add(entity);   
            _context.SaveChanges(); 
        }

        public void Delete(T entity)
        {
            this.entity.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {

            return this.entity.ToList();   
        }

        public T GetById(int id)
        {
            var entity = _context.Find<T>(id);

            return entity;
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges(); 
        }
    }
}
