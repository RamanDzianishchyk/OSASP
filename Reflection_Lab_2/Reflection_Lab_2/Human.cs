// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Human.cs" company="GRSU">
//   LAB 2
// </copyright>
// <summary>
//   The class for human.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


namespace Reflection_Lab_2
{
    using System;

    /// <summary>
    /// The human.
    /// </summary>
    [AlternativeName(Name = "HM")]
    public class Human : Humanoid, IViviparous
    {
        /// <summary>
        /// The gestation period.
        /// </summary>
        private readonly int gestationPeriod;

        /// <summary>
        /// Initializes a new instance of the <see cref="Human"/> class.
        /// </summary>
        /// <param name="gestationPeriod">
        /// The gestation period.
        /// </param>
        public Human(int gestationPeriod)
        {
            this.gestationPeriod = gestationPeriod;
        }

        /// <summary>
        /// Gets or sets the count of hands.
        /// </summary>
        public int CountOfHands { get; set; }

        /// <summary>
        /// The get gestation period.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public int GetGestationPeriod()
        {
            return this.gestationPeriod;
        }
    }
}
