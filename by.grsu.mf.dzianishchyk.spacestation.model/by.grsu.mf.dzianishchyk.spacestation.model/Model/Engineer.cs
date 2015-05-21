// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Engineer.cs" company="GRSU">
//   Project space station in deep space
// </copyright>
// <summary>
//   Defines the engineer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The engineer.
    /// </summary>
    public class Engineer : Human
    {
        /// <summary>
        /// Gets or sets the qualification.
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// Gets or sets the fixed docks.
        /// </summary>
        public List<Dock> FixedDocks { get; set; }

        /// <summary>
        /// Gets or sets the work station.
        /// </summary>
        public Station WorkStation { get; set; }
    }
}
