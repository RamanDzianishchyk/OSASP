// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PilotRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The pilot repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model.Repository
{
    using System;
    using System.Linq;

    using @by.grsu.mf.dzianishchyk.spacestation.model.Context;
    using @by.grsu.mf.dzianishchyk.spacestation.model.IRepository;

    /// <summary>
    /// The pilot repository.
    /// </summary>
    public class PilotRepository : BaseRepository<Pilot>, IPilotRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PilotRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public PilotRepository(DataContext context)
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
        protected override IOrderedQueryable<Pilot> Order(IQueryable<Pilot> query)
        {
            return query.OrderBy(pilot => pilot.LastName);
        }
    }
}
