// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pilot.cs" company="GRSU">
//   Project space station in deep space
// </copyright>
// <summary>
//   Defines the pilot type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model
{
    using System;

    /// <summary>
    /// The pilot.
    /// </summary>
    public class Pilot : Human
    {
        /// <summary>
        /// Gets or sets the own ship.
        /// </summary>
        public Ship OwnShip { get; set; }

        /// <summary>
        /// Gets or sets the experience flights.
        /// </summary>
        public int ExperienceFlights { get; set; }
    }
}
