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
    public class Station
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Station"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="location">
        /// The location.
        /// </param>
        public Station(string name, string location)
        {
            this.Name = name;
            this.Location = location;
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

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
