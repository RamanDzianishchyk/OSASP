// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDescriptor.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the IDescriptor type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Generics_Lab_1
{
    /// <summary>
    /// The Descriptor interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IDescriptor<in T>
        where T : Device
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
        string GetDescription(T device);
    }
}
