// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Station.cs" company="GRSU">
//   Project space station in deep space
// </copyright>
// <summary>
//   Defines the ship type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model
{
    using System.Collections.Generic;

    /// <summary>
    /// The space station.
    /// </summary>
    public class Station : BaseObject
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the engineers of station.
        /// </summary>
        public List<Engineer> Engineers { get; set; }

        /// <summary>
        /// Gets or sets the docks on space station.
        /// </summary>
        public List<Dock> Docks { get; set; } 
    }
}
