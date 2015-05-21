// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTestContravariance.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the UnitTestContravariance type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


namespace GenericTests
{
    using System;

    using Generics_Lab_1;
    using Generics_Lab_1.Implementation;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The unit test contravariance.
    /// </summary>
    [TestClass]
    public class UnitTestContravariance
    {
        /// <summary>
        /// The test method contravariance.
        /// </summary>
        [TestMethod]
        public void TestMethodContravariance()
        {
            IDescriptor<Device> deviceDescriptor = new DeviceDescriptor();
            IDescriptor<Keyboard> keyboardDescriptor = new KeyboardDescriptor();
            keyboardDescriptor = deviceDescriptor;
        }

        /// <summary>
        /// The test method contravariance.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void TestMethodContravarianceFail()
        {
            IDescriptor<Device> deviceDescriptor = new DeviceDescriptor();
            IDescriptor<Keyboard> keyboardDescriptor = new KeyboardDescriptor();
            deviceDescriptor = (IDescriptor<Device>)keyboardDescriptor;
        }
    }
}
