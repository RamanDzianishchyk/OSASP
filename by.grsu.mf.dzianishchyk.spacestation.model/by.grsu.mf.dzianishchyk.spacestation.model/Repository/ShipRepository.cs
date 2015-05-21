// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShipRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The ship repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model.Repository
{
    using System;
    using System.Linq;

    using @by.grsu.mf.dzianishchyk.spacestation.model.Context;
    using @by.grsu.mf.dzianishchyk.spacestation.model.IRepository;

    /// <summary>
    /// The ship repository.
    /// </summary>
    public class ShipRepository : BaseRepository<Ship>, IShipRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public ShipRepository(DataContext context)
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
        protected override IOrderedQueryable<Ship> Order(IQueryable<Ship> query)
        {
            return query.OrderBy(ship => ship.Name);
        }
    }
}
