// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StationRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The station repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model.Repository
{
    using System;
    using System.Linq;

    using @by.grsu.mf.dzianishchyk.spacestation.model.Context;
    using @by.grsu.mf.dzianishchyk.spacestation.model.IRepository;

    /// <summary>
    /// The station repository.
    /// </summary>
    public class StationRepository : BaseRepository<Station>, IStationRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StationRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public StationRepository(DataContext context)
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
        protected override IOrderedQueryable<Station> Order(IQueryable<Station> query)
        {
            return query.OrderBy(station => station.Name);
        }
    }
}
