// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeviceCreator.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the DeviceCreator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Generics_Lab_1.Implementation
{
    /// <summary>
    /// The device creator.
    /// </summary>
    public class DeviceCreator : ICreator<Device>
    {
        /// <summary>
        /// The default device description.
        /// </summary>
        private const string DefaultDescription = "Some device description";

        /// <summary>
        /// Create the device
        /// </summary>
        /// <returns>
        /// The <see cref="Device"/>.
        /// </returns>
        public Device Create()
        {
            return new Device(DefaultDescription);
        }
    }
}
