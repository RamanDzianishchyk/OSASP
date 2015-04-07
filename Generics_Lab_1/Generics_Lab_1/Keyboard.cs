// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Keyboard.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the Keyboard type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Generics_Lab_1
{
    /// <summary>
    /// The keyboard.
    /// </summary>
    public class Keyboard : Device
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Keyboard"/> class.
        /// </summary>
        /// <param name="description">
        /// The description of keyboard.
        /// </param>
        /// <param name="keyboardLayout">
        /// The keyboard layout.
        /// </param>
        public Keyboard(string description, string keyboardLayout)
            : base(description)
        {
            this.Keyboardlayout = keyboardLayout;
        }

        /// <summary>
        /// Gets or sets the keyboard layout.
        /// </summary>
        public string Keyboardlayout
        {
            get;
            set;
        }
    }
}
