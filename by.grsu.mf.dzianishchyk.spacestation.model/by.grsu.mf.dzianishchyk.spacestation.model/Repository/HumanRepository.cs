// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HumanRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The human repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model.Repository
{
    using System;
    using System.Linq;

    using @by.grsu.mf.dzianishchyk.spacestation.model.Context;
    using @by.grsu.mf.dzianishchyk.spacestation.model.IRepository;

    /// <summary>
    /// The human repository.
    /// </summary>
    public class HumanRepository : BaseRepository<Human>, IHumanRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HumanRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public HumanRepository(DataContext context)
            : base(context)
        {
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
        /// <exception cref="NotImplementedException">
        /// </exception>
        protected override IOrderedQueryable<Human> Order(IQueryable<Human> query)
        {
            return query.OrderBy(human => human.LastName);
        }
    }
}
