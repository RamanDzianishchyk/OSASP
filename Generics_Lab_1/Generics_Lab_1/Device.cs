// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Device.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the Device type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Generics_Lab_1
{
    /// <summary>
    /// The device.
    /// </summary>
    public class Device
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Device"/> class.
        /// </summary>
        /// <param name="description">
        /// The description of device.
        /// </param>
        public Device(string description)
        {
            this.Description = description;
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
    }
}
