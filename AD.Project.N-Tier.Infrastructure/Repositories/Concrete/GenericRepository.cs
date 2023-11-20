using AD.Project.N_Tier.Infrastructure.AppDbContext;
using AD.Project.N_Tier.Infrastructure.Entity.Base;
using AD.Project.N_Tier.Infrastructure.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AD.Project.N_Tier.Infrastructure.Repositories.Concrete
{
    /// <summary>
    /// EntityFrameWork Core - Generic Repository - Context - DbSet - Inheritance 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContexts _context;
        /// <summary>
        /// TO-DO DbSet Araştırılacak
        /// </summary>
        private readonly DbSet<T> _dbSet;
        public GenericRepository(AppDbContexts context)
        {
            _context = context;
            _dbSet= _context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }
        
        /// <summary>
        /// Birden fazla Add İşlemini tek method ile yapma AddRangeAsync
        /// </summary>
        /// <returns></returns>
        /// 
        
        public async Task<T> GetByIdAsync(long Id)
        {
            return await _dbSet.FindAsync(Id);
        }
        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
