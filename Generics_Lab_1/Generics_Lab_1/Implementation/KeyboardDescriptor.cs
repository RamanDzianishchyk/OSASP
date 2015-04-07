// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KeyboardDescriptor.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the KeyboardDescriptor type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Generics_Lab_1.Implementation
{
    /// <summary>
    /// The keyboard descriptor.
    /// </summary>
    public class KeyboardDescriptor : IDescriptor<Keyboard>
    {
        /// <summary>
        /// The get keyboard description.
        /// </summary>
        /// <param name="keyboard">
        /// The keyboard.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetDescription(Keyboard keyboard)
        {
            return string.Format(
                "Description: {0}; Keyboard layout: {1}", 
                keyboard.Description, 
                keyboard.Keyboardlayout);
        }
    }
}
