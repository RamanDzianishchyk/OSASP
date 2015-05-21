// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EngineerRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The engineer repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model.Repository
{
    using System.Linq;

    using @by.grsu.mf.dzianishchyk.spacestation.model.Context;
    using @by.grsu.mf.dzianishchyk.spacestation.model.IRepository;

    /// <summary>
    /// The engineer repository.
    /// </summary>
    public class EngineerRepository : BaseRepository<Engineer>,IEngineerRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EngineerRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public EngineerRepository(DataContext context)
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
        protected override IOrderedQueryable<Engineer> Order(IQueryable<Engineer> query)
        {
            return query.OrderBy(engineer => engineer.Qualification);
        }
    }
}
