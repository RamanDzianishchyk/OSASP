// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EngineerConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   The engineer configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model.Configuration
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// The engineer configuration.
    /// </summary>
    public class EngineerConfiguration : EntityTypeConfiguration<Engineer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EngineerConfiguration"/> class.
        /// </summary>
        public EngineerConfiguration()
        {
            
        }
    }
}
