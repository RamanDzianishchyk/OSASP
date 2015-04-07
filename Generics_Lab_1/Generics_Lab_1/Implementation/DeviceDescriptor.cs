// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeviceDescriptor.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the DeviceDescriptor type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Generics_Lab_1.Implementation
{
    /// <summary>
    /// The device descriptor.
    /// </summary>
    public class DeviceDescriptor : IDescriptor<Device>
    {
        /// <summary>
        /// The get description.
        /// </summary>
        /// <param name="device">
        /// The device.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetDescription(Device device)
        {
            return string.Format("Description: {0}", device.Description);
        }
    }
}
