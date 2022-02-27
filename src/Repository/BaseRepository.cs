using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public DbSet<T> DbSet
        {
            get
            {
                return DbContext.Set<T>();
            }
        }

        public DbContext DbContext { get; set; }

        /// <summary>
        /// Add new entity
        /// </summary>
        /// <param name="entity"></param>
        public T Add(T entity)
        {
            DbSet.Add(entity);
            return entity;
        }

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="entity"></param>
        public T Delete(T entity)
        {
            if (entity != null)
                DbSet.Remove(entity);
            return entity;
        }

        /// <summary>
        /// Delete entities
        /// </summary>
        /// <param name="entities"></param>
        public void DeleteRange(IEnumerable<T> entities)
        {
            DbSet.RemoveRange(entities);
        }

        /// <summary>
        /// Get entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(string id, bool allowTracking = true)
        {
            return DbSet.Find(id);
        }

        /// <summary>
        /// Get entity by lambda expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public T Get(Expression<Func<T, bool>> predicate, bool allowTracking = true)
        {
            return DbSet.FirstOrDefault(predicate);
        }

        /// <summary>
        /// Get list of entities
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll(bool allowTracking = true)
        {
            return DbSet.AsEnumerable();
        }

        /// <summary>
        /// Get entites by lambda expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<T> GetMany(Expression<Func<T, bool>> predicate, bool allowTracking = true)
        {
            return DbSet.Where(predicate).AsEnumerable();
        }

        /// <summary>
        /// Update an entity
        /// </summary>
        /// <param name="entity"></param>
        public T Update(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            DbSet.Attach(entity);
            return entity;
        }


        /// <summary>
        /// Get all entities async
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetAllAsync(bool allowTracking = true)
        {
            var data = await DbSet.ToListAsync();
            return data;
        }

        /// <summary>
        /// Get entities by lambda expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> predicate,
            bool allowTracking = true)
        {
            var data = await DbSet.Where(predicate).ToListAsync();
            return data;
        }

        /// <summary>
        /// Get entity by id async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetByIdAsync(int id, bool allowTracking = true)
        {
            var data = await DbSet.FirstOrDefaultAsync(c =>
            ((int)c.GetType().GetProperty("Id").GetValue(c) == id));

            return data;
        }

        /// <summary>
        /// Get entities by lambda expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, bool allowTracking = true)
        {
            T data;

            if (allowTracking)
            {
                data = await DbSet.FirstOrDefaultAsync(predicate);
            }
            else
            {
                data = await DbSet.AsNoTracking().FirstOrDefaultAsync(predicate);
            }
            return data;
        }

        public async Task<T> AddAsync(T obj)
        {
            await DbSet.AddAsync(obj);
            return obj;
        }

        public async Task<T> DeleteAsync(T obj)
        {
            DbSet.Remove(obj);
            return obj;
        }

        public async Task<T> DeleteAsync(string id)
        {
            var item = await DbSet.FindAsync(id);
            if (item != null)
            {
                throw new Exception("Object not found");
            }
             DbSet.Remove(item);
            return item;
        }

        public async Task<T> UpdateAsync(T obj)
        {
             DbContext.Entry(obj).State = EntityState.Modified;
            return obj;
        }
    }
}
