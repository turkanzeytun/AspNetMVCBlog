using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogg.DAL.Concrates.EF.GenericRepositoryPattern.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        T FindById(object EntityId);
        //IEnumerable<T> Select(System.Linq.Expressions.Expression<Func<T, bool>> Filter = null);
        void Insert(T Entity);
        void Update(T Entity);
        void Delete(object EntityId);
        void Delete(T Entity);
        IQueryable<T> Select(System.Linq.Expressions.Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
    }
}
