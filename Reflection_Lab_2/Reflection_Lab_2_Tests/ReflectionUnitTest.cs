// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReflectionUnitTest.cs" company="GRSU">
//   LAB 2
// </copyright>
// <summary>
//   Defines the ReflectionUnitTest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Reflection_Lab_2_Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Reflection_Lab_2;

    /// <summary>
    /// The reflection unit test.
    /// </summary>
    [TestClass]
    public class ReflectionUnitTest
    {
        /// <summary>
        /// The test method alternative name.
        /// </summary>
        [TestMethod]
        public void TestMethodAlternativeName()
        {
            var myobj = new List<object> { new Cat(2), new Human(9), new BlueMen() };
            foreach (var value in myobj)
            {
                var attribs = value.GetType().GetCustomAttributes(typeof(AlternativeName), false);
                if (attribs.Count() != 0)
                {
                    var alt = (AlternativeName)attribs[0];
                    if (alt.Name == "BM")
                    {
                        Console.WriteLine("BlueMen");
                    }
                    else
                    {
                        if (alt.Name == "HM")
                        {
                            Console.WriteLine("Human");
                        }
                        else
                        {
                            if (alt.Name == "CT")
                            {
                                Console.WriteLine("Cat");
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// The test method interface.
        /// </summary>
        [TestMethod]
        public void TestMethodInterface()
        {
            var myobj = new List<object> { new Cat(2), new Human(9), new BlueMen() };
            var count = myobj.Count(value => value.GetType().GetInterface("IViviparous") == typeof(IViviparous));
            Assert.AreEqual(count, 2);
        }

        /// <summary>
        /// The test method extension.
        /// </summary>
        [TestMethod]
        public void TestMethodExtension()
        {
            var myobj = new List<object> { new Cat(2), new Human(9), new BlueMen() };
            var count = myobj.Count(value => value.GetType().BaseType == typeof(Humanoid));
            Assert.AreEqual(count, 2);
        }

        /// <summary>
        /// The test method.
        /// </summary>
        [TestMethod]
        public void TestMethod()
        {
            var objects = new List<object> { new Cat(2), new Human(9), new BlueMen() };
            var sb = new StringBuilder();
            foreach (var obj in objects)
            {
                sb.Append(obj.GetType());
                sb.Append(";");
            }

            Console.WriteLine(sb.ToString());
            var types = objects.Select(obj => obj.GetType()).ToList();
            Assert.IsTrue(types.Contains(typeof(Cat)), "Doesn't contain cat");
            Assert.IsTrue(types.Contains(typeof(Human)), "Doesn't contain human");
            Assert.IsTrue(types.Contains(typeof(BlueMen)), "Doesn't contain blue men");
        }

        /// <summary>
        /// The test method property finding.
        /// </summary>
        [TestMethod]
        public void TestMethodPropertyFinding()
        {
            var objects = new List<object> { new Cat(2), new Human(9), new BlueMen() };

            foreach (var obj in objects)
            {
                if (obj is BlueMen)
                {
                    Assert.IsNotNull(
                        obj.GetType().GetProperty("CountOfTentacles"),
                        "Count of tentacles property of blue men is not present!");
                }

                if (obj is Human)
                {
                    Assert.IsNotNull(
                        obj.GetType().GetProperty("CountOfHands"),
                        "Count of hands property of human is not present!");
                }

                if (obj is Cat)
                {
                    Assert.IsTrue(
                        obj.GetType().GetProperties().Length == 0,
                        " Cat haven't any properties!");
                }
            }
        }
    }
}
