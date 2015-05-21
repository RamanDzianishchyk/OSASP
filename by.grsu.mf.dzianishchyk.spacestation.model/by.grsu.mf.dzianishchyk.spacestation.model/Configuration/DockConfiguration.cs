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
            HasKey(dock => dock.Id).Property(dock => dock.Id).HasColumnName("DockId");

            Property(dock => dock.Name).HasMaxLength(30).IsRequired();
            Property(dock => dock.CountOfShipsPlaces).IsRequired();

            HasMany(dock => dock.Ships).WithOptional(ship => ship.DockRegistry).WillCascadeOnDelete(false);
            HasMany(dock => dock.Engineers)
                .WithMany(engineer => engineer.FixedDocks)
                .Map(m => m.ToTable("DockWithEngineer").MapLeftKey("DockId").MapRightKey("EngineerId"));
        }
    }
}
