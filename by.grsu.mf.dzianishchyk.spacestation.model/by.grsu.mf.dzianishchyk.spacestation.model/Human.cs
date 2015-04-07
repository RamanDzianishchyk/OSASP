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
    public class Human
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Human"/> class.
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
        public Human(string firstName, string middleName, string lastName, string biography, DateTime birthday)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Biography = biography;
            this.Birthday = birthday;
        }

        /// <summary>
        /// Gets or sets the id (all in the future will have an id)
        /// </summary>
        public int Id { get; set; }

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

        /// <summary>
        /// Gets or sets the birthday.
        /// </summary>
        public DateTime Birthday { get; set; }
    }
}
