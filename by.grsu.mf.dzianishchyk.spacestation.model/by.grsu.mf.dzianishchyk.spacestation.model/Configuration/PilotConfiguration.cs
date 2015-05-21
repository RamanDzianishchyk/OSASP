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
        /// Initializes a new instance of the <see cref="PilotConfiguration"/> class. 
        /// Prevents a default instance of the <see cref="PilotConfiguration"/> class from being created.
        /// </summary>
        public PilotConfiguration()
        {
            HasKey(pilot => pilot.Id).Property(pilot => pilot.Id).HasColumnName("PilotId");

            Property(pilot => pilot.FirstName).HasMaxLength(30).IsOptional();
            Property(pilot => pilot.MiddleName).HasMaxLength(30).IsOptional();
            Property(pilot => pilot.LastName).HasMaxLength(30).IsRequired();
            Property(pilot => pilot.ExperienceFlights).IsRequired();

            HasOptional(pilot => pilot.OwnShip).WithOptionalDependent(ship => ship.OwnerPilot).WillCascadeOnDelete(false);
        }
    }
}
