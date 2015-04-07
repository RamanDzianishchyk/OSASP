// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AlternativeName.cs" company="GRSU">
//   Lab2
// </copyright>
// <summary>
//   Defines the AlternativeName type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Reflection_Lab_2
{
    using System;

    /// <summary>
    /// The attribut for alternative name.
    /// </summary>
    public class AlternativeName : Attribute
    {
        /// <summary>
        /// Gets or sets the name of attribute.
        /// </summary>
        public string Name { get; set; }
    }
}
