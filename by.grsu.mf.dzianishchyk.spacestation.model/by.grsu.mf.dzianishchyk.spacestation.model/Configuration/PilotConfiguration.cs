// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PilotConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the PilotConfiguration type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model.Configuration
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// The pilot configuration.
    /// </summary>
    public class PilotConfiguration : EntityTypeConfiguration<Pilot>
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="PilotConfiguration"/> class from being created.
        /// </summary>
        public PilotConfiguration()
        {
            
        }
    }
}
