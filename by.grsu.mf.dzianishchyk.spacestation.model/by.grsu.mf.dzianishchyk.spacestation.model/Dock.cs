// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Dock.cs" company="GRSU">
//   Project space station in deep space
// </copyright>
// <summary>
//   Defines the dock type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model
{
    using System.Collections.Generic;

    /// <summary>
    /// The dock.
    /// </summary>
    public class Dock : BaseObject
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the station.
        /// </summary>
        public Station Station { get; set; }

        /// <summary>
        /// Gets or sets the count of ships places.
        /// </summary>
        public int CountOfShipsPlaces { get; set; }

        /// <summary>
        /// Gets or sets the ships.
        /// </summary>
        public List<Ship> Ships { get; set; }

        /// <summary>
        /// Gets or sets the engineers.
        /// </summary>
        public List<Engineer> Engineers { get; set; } 
    }
}
