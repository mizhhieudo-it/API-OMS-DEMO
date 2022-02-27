﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> DbSet { get; }
        DbContext DbContext { get; set; }

        #region Sync Methods
        /// <summary>
        /// Get all entities
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll(bool allowTracking = true);

        /// <summary>
        /// Get entities by lambda expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IEnumerable<T> GetMany(Expression<Func<T, bool>> predicate, bool allowTracking = true);

        /// <summary>
        /// Get entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(string id, bool allowTracking = true);

        /// <summary>
        /// Get entity by lambda expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        T Get(Expression<Func<T, bool>> predicate, bool allowTracking = true);


        /// <summary>
        /// Add new antity
        /// </summary>
        /// <param name="entity"></param>
        T Add(T entity);

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="entity"></param>
        T Delete(T entity);

        /// <summary>
        /// Delete the entities
        /// </summary>
        /// <param name="entities"></param>
        void DeleteRange(IEnumerable<T> entities);

        /// <summary>
        /// Update an entity
        /// </summary>
        /// <param name="entity"></param>
        T Update(T entity);

        #endregion

        #region Async Methods
        public Task<T> AddAsync(T obj);
        public Task<T> DeleteAsync(T obj);
        public Task<T> DeleteAsync(string id);
        public Task<T> UpdateAsync(T obj);


        /// <summary>
        /// Get all entities async
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync(bool allowTracking = true);

        /// <summary>
        /// Get entities lambda expression async
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> predicate, bool allowTracking = true);

        /// <summary>
        /// Get entity by id async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetByIdAsync(int id, bool allowTracking = true);

        /// <summary>
        /// Get entity by lambda expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, bool allowTracking = true);

        #endregion
    }
}
