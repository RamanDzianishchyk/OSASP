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
            HasKey(station => station.Id).Property(station => station.Id).HasColumnName("StationId");

            Property(station => station.Name).HasMaxLength(30).IsRequired();
            Property(station => station.Location).HasMaxLength(256).IsRequired();

            HasMany(station => station.Docks).WithRequired(dock => dock.Station).WillCascadeOnDelete(true);
            HasMany(station => station.Engineers).WithRequired(engineer => engineer.WorkStation).WillCascadeOnDelete(false);
        }
    }
}
