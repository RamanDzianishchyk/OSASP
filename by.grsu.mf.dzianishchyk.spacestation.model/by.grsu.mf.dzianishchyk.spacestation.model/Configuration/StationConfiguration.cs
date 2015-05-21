// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StationConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the StationConfiguration type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model.Configuration
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// The station configuration.
    /// </summary>
    public class StationConfiguration : EntityTypeConfiguration<Station>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StationConfiguration"/> class.
        /// </summary>
        public StationConfiguration()
        {
            
        }
    }
}
