// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DockConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the DockConfiguration type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model.Configuration
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// The dock configuration.
    /// </summary>
    public class DockConfiguration : EntityTypeConfiguration<Dock>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DockConfiguration"/> class.
        /// </summary>
        public DockConfiguration()
        {
            
        }
    }
}
