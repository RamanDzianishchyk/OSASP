// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICreator.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the ICreator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Generics_Lab_1
{
    /// <summary>
    /// The Creator interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface ICreator<out T>
        where T : Device
    {
        /// <summary>
        /// The create.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        T Create();
    }
}
