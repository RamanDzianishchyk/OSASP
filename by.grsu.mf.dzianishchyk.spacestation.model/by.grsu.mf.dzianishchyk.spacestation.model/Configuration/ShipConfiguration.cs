﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShipConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   The ship configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model.Configuration
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// The ship configuration.
    /// </summary>
    public class ShipConfiguration : EntityTypeConfiguration<Ship>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipConfiguration"/> class.
        /// </summary>
        public ShipConfiguration()
        {
            HasKey(ship => ship.Id).Property(ship => ship.Id).HasColumnName("ShipId");

            Property(ship => ship.Name).HasMaxLength(30).IsRequired();
        }
    }
}
