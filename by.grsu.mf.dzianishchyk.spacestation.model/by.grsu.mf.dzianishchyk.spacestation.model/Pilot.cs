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
        /// Initializes a new instance of the <see cref="Pilot"/> class.
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
        /// <param name="experienceFlights">
        /// The experience Flights.
        /// </param>
        public Pilot(string firstName, string middleName, string lastName, string biography, DateTime birthday, int experienceFlights = 0)
            : base(firstName, middleName, lastName, biography, birthday)
        {
            this.ExperienceFlights = experienceFlights;
        }

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
