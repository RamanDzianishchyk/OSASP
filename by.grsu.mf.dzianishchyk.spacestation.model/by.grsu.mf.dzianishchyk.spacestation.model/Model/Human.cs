// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Human.cs" company="GRSU">
//   Project space station in deep space
// </copyright>
// <summary>
//   Defines the human type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model
{
    using System;

    /// <summary>
    /// The human.
    /// </summary>
    public class Human : BaseObject
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the middle name.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the biography.
        /// </summary>
        public string Biography { get; set; }
    }
}
