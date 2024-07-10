using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Repositories.GenericRepo
{
    public interface IGenericRepo <T> where T : class
    {
        Task<IQueryable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        Task<IQueryable<T>> Filter(Func<T, bool> predicate);
    }
}
