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
        /// Initializes a new instance of the <see cref="Engineer"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="middleName">
        /// The middle name.
        /// </param>
        /// <param name="lastName">
        /// The last name.
        /// </param>
        /// <param name="biography">
        /// The biography.
        /// </param>
        /// <param name="birthday">
        /// The birthday.
        /// </param>
        /// <param name="qualification">
        /// The qualification.
        /// </param>
        public Engineer(string firstName, string middleName, string lastName, string biography, DateTime birthday, string qualification)
            : base(firstName, middleName, lastName, biography, birthday)
        {
            this.Qualification = qualification;
        }

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
