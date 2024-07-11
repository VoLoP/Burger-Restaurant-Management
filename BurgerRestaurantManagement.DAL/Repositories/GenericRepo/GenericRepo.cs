using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Repositories.GenericRepo
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {

        private readonly DbContext _ctx;

        public GenericRepo(DbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<T> Add(T entity)
        {
            await _ctx.Set<T>().AddAsync(entity);
            await _ctx.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await _ctx.Set<T>().FindAsync(id);
            if (entity != null)
            {
                _ctx.Set<T>().Remove(entity);
                await _ctx.SaveChangesAsync();
            }
            return entity;
        }

        //AsQueryable() maybe not needed here
        public async Task<IQueryable<T>> Filter(Func<T, bool> predicate)
        {
            return _ctx.Set<T>().Where(predicate).AsQueryable();
        }

        public async Task<T> GetById(int id)
        {
            return await _ctx.Set<T>().FindAsync(id);
        }

        public async Task<T> Update(T entity)
        {
            _ctx.Set<T>().Update(entity);
            await _ctx.SaveChangesAsync();
            return entity;
        }

        public async Task<IQueryable<T>> GetAll()
        {
            return _ctx.Set<T>();
        }
    }
}
