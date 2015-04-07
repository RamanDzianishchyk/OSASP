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
            var count = 0;

            var myobj = new List<object> { new Cat(2), new Human(9), new BlueMen() };

            foreach (var value in myobj)
            {
                if (value.GetType().GetInterface("IViviparous") == typeof(IViviparous))
                {
                    count++;
                    var attribs = value.GetType().GetCustomAttributes(typeof(AlternativeName), false);
                    var alt = (AlternativeName)attribs[0];

                    if (alt.Name == "CT")
                    {
                        var cat = (Cat)value;
                        int gestationPeriod = cat.GetGestationPeriod();
                        Console.WriteLine(gestationPeriod);
                    }
                    else
                    {
                        if (alt.Name == "HM")
                        {
                            var human = (Human)value;
                            int gestationPeriod = human.GetGestationPeriod();
                            Console.WriteLine(gestationPeriod);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Blue men want capture the Earth");
                }
            }

            Assert.AreEqual(count, 2);
        }

        /// <summary>
        /// The test method extension.
        /// </summary>
        [TestMethod]
        public void TestMethodExtension()
        {
            var count = 0;

            var myobj = new List<object> { new Cat(2), new Human(9), new BlueMen() };

            foreach (var value in myobj)
            {
                if (value.GetType().BaseType == typeof(Humanoid))
                {
                    count++;
                    var attribs = value.GetType().GetCustomAttributes(typeof(AlternativeName), false);
                    var alt = (AlternativeName)attribs[0];

                    if (alt.Name == "HM")
                    {
                        var human = (Human)value;
                        int gestationPeriod = human.GetGestationPeriod();
                        Console.WriteLine(gestationPeriod);
                    }
                    else
                    {
                        if (alt.Name == "BM")
                        {
                            var blueMen = (BlueMen)value;
                            blueMen.CountOfTentacles = 10;
                            Console.WriteLine(blueMen.CountOfTentacles);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Small beautiful cats");
                }
            }

            Assert.AreEqual(count, 2);
        }
    }
}
