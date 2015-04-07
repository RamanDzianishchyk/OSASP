// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlueMen.cs" company="GRSU">
//   LAB 2
// </copyright>
// <summary>
//   Class for blue men.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Reflection_Lab_2
{
    /// <summary>
    /// The blue men.
    /// </summary>
    [AlternativeName(Name = "BM")]
    public class BlueMen : Humanoid
    {
        /// <summary>
        /// Gets or sets the count of tentacles.
        /// </summary>
        public int CountOfTentacles { get; set; }
    }
}
