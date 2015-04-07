// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cat.cs" company="GRSU">
//   LAB 2
// </copyright>
// <summary>
//   The class for cat.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Reflection_Lab_2
{
    using System;

    /// <summary>
    /// The cat.
    /// </summary>
    [AlternativeName(Name = "CT")]
    public class Cat : IViviparous
    {
        /// <summary>
        /// The gestation period.
        /// </summary>
        private readonly int gestationPeriod;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cat"/> class.
        /// </summary>
        /// <param name="gestationPeriod">
        /// The gestation period.
        /// </param>
        public Cat(int gestationPeriod)
        {
            this.gestationPeriod = gestationPeriod;
        }

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
