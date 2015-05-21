// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Ship.cs" company="GRSU">
//   Project space station in deep space
// </copyright>
// <summary>
//   Defines the ship type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model
{
    /// <summary>
    /// The space ship.
    /// </summary>
    public class Ship : BaseObject
    {
        /// <summary>
        /// Gets or sets the name of space ship.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the dock of registry.
        /// </summary>
        public Dock DockRegistry { get; set; }

        /// <summary>
        /// Gets or sets the owner pilot.
        /// </summary>
        public Pilot OwnerPilot { get; set; }
    }
}
