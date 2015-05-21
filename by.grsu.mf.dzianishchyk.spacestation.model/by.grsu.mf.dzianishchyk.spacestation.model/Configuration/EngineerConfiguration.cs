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
            HasKey(engineer => engineer.Id).Property(engineer => engineer.Id).HasColumnName("EngineerId");

            Property(engineer => engineer.FirstName).HasMaxLength(30).IsOptional();
            Property(engineer => engineer.MiddleName).HasMaxLength(30).IsOptional();
            Property(engineer => engineer.LastName).HasMaxLength(30).IsRequired();
            Property(engineer => engineer.Qualification).HasMaxLength(255).IsRequired();
        }
    }
}
