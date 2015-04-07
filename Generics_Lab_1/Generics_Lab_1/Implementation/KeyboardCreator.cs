// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KeyboardCreator.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the KeyboardCreator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Generics_Lab_1.Implementation
{
    /// <summary>
    /// The keyboard creator.
    /// </summary>
    public class KeyboardCreator : ICreator<Keyboard>
    {
        /// <summary>
        /// The default keyboard description.
        /// </summary>
        private const string DefaultDescription = "Some default keyboard description";

        /// <summary>
        /// The default keyboard layout.
        /// </summary>
        private const string DefaultKeyboardLayout = "Some dault keyboard layout";

        /// <summary>
        /// Create keyborad
        /// </summary>
        /// <returns>
        /// The <see cref="Keyboard"/>.
        /// </returns>
        public Keyboard Create()
        {
            return new Keyboard(DefaultDescription, DefaultKeyboardLayout);
        }
    }
}
