// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DockRepository.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the DockRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model.Repository
{
    using System.Linq;

    using @by.grsu.mf.dzianishchyk.spacestation.model.Context;
    using @by.grsu.mf.dzianishchyk.spacestation.model.IRepository;

    /// <summary>
    /// The dock repository.
    /// </summary>
    public class DockRepository : BaseRepository<Dock>, IDockRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DockRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public DockRepository(DataContext context)
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
        protected override IOrderedQueryable<Dock> Order(IQueryable<Dock> query)
        {
            return query.OrderBy(dock => dock.Name);
        }
    }
}
