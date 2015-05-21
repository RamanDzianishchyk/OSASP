// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The base repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    using @by.grsu.mf.dzianishchyk.spacestation.model.Context;
    using @by.grsu.mf.dzianishchyk.spacestation.model.IRepository;

    /// <summary>
    /// The base repository.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseObject
    {
        /// <summary>
        /// The context.
        /// </summary>
        protected readonly DataContext Context;

        /// <summary>
        /// Gets the query.
        /// </summary>
        protected IQueryable<T> Query
        {
            get
            {
                return this.Order(this.Context.Set<T>());
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{T}"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public BaseRepository(DataContext context)
        {
            this.Context = context;
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public virtual T Get(int id)
        {
            return this.Context.Set<T>().Find(id);
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public virtual T Update(T entity)
        {
            var attachedEntity = this.Context.Set<T>().Find(entity.Id);
            if (attachedEntity != null)
            {
                this.Context.Entry(attachedEntity).CurrentValues.SetValues(entity);
                this.Context.SaveChanges();
            }

            return entity;
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public virtual T Delete(T entity)
        {
            var e = this.Context.Set<T>().Remove(entity);
            this.Context.SaveChanges();
            return e;
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null)
        {
            return filter == null
                ? this.Query.ToList()
                : this.Query.Where(filter).ToList();
        }

        /// <summary>
        /// The count.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public virtual int Count(Expression<Func<T, bool>> filter = null)
        {
            return filter == null
                ? this.Query.Count()
                : this.Query.Where(filter).Count();
        }

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public virtual T Add(T entity)
        {
            var e = this.Context.Set<T>().Add(entity);
            this.Context.SaveChanges();
            return e;
        }

        /// <summary>
        /// The order.
        /// </summary>
        /// <param name="query">
        /// The query.
        /// </param>
        /// <returns>
        /// The <see cref="IOrderedQueryable"/>.
        /// </returns>
        protected abstract IOrderedQueryable<T> Order(IQueryable<T> query);
    }
}
