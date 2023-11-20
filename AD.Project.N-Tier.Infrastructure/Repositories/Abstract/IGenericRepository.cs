using AD.Project.N_Tier.Infrastructure.Entity.Base;
using System.Linq.Expressions;

namespace AD.Project.N_Tier.Infrastructure.Repositories.Abstract
{
    /// <summary>
    /// CRUD İşlemleri- Select İşlemleri
    /// </summary>
    public interface IGenericRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Insert
        /// </summary>
        /// <returns></returns>
        Task AddAsync(T entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);


        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        void Remove(T entity);

        /// <summary>
        /// ID bazlı veri getirme
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<T> GetByIdAsync(long Id);


        /// <summary>
        /// Koşullu sorgulamalar için kullanılır
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
    }
}
