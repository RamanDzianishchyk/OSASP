// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTestCovariance.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the UnitTestCovariance type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GenericTests
{
    using Generics_Lab_1;
    using Generics_Lab_1.Implementation;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The unit test covariance.
    /// </summary>
    [TestClass]
    public class UnitTestCovariance
    {
        /// <summary>
        /// The test method covariance.
        /// </summary>
        [TestMethod]
        public void TestMethodCovariance()
        {
            ICreator<Device> deviceCreator = new DeviceCreator();
            ICreator<Keyboard> keyboardCreator = new KeyboardCreator();
            deviceCreator = keyboardCreator;
        }
    }
}
