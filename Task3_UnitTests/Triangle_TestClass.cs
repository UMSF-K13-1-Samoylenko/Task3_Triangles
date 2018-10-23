// <copyright file="Triangle_TestClass.cs" company="My company">
//     Copyright (c) My company". All rights reserved.
// </copyright>

namespace Task3_UnitTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Task3_Lib;

    /// <summary>
    /// Class with unit tests of triangle class
    /// </summary>
    [TestClass]
    public class Triangle_TestClass
    {
        /// <summary>
        /// Checking square calc if input correct
        /// </summary>
        /// <param name="a">A side of triangle</param>
        /// <param name="b">B side of triangle</param>
        /// <param name="c">C side of triangle</param>
        /// <param name="expected">Expected square</param>
        [DataTestMethod]
        [DataRow(3, 4, 5, 6)]
        [DataRow(5, 5, 6, 12)]
        [DataRow((float)1.2, (float)2.2, (float)3.3, (float)0.64)]
        [DataRow(3, 3, 3, (float)3.9)]
        public void Square_InputCorrect(float a, float b, float c, float expected)
        {
            // Arrange
            Triangle triangle = Triangle.Initialize("test", a, b, c);

            // Actual
            float actual = (float)Math.Round(triangle.Area, 2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Checking work of Initializer in <see cref="Triangle"/> class
        /// </summary>
        /// <param name="a">A side of triangle</param>
        /// <param name="b">B side of triangle</param>
        /// <param name="c">C side of triangle</param>
        [DataTestMethod]
        [DataRow(0, 1, 1)]
        [DataRow(1, 0, 1)]
        [DataRow(1, 1, 0)]
        [DataRow(-1, 1, 1)]
        [DataRow(1, -1, 1)]
        [DataRow(1, 1, -1)]
        [DataRow(1, 2, 100)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SquareField_InputIncorrect(float a, float b, float c)
        {
            Triangle triangle = Triangle.Initialize("test", a, b, c);
        }

        /// <summary>
        /// Test of CompareTo()
        /// </summary>
        /// <param name="firstTriangleA">First triangle a side value</param>
        /// <param name="firstTriangleB">First triangle b side value</param>
        /// <param name="firstTriangleC">First triangle c side value</param>
        /// <param name="secondTriangleA">Second triangle a side value</param>
        /// <param name="secondTriangleB">Second triangle b side value</param>
        /// <param name="secondTriangleC">Second triangle c side value</param>
        /// <param name="expected">Result of compareTo</param>
        [DataTestMethod]
        [DataRow(5, 5, 6, 3, 4, 5, -1)]
        [DataRow(3, 4, 5, 5, 5, 6, 1)]
        [DataRow(3, 4, 5, 3, 4, 5, 0)]
        public void CompareTo_Test(
            float firstTriangleA,
            float firstTriangleB, 
            float firstTriangleC,
            float secondTriangleA,
            float secondTriangleB, 
            float secondTriangleC,
            int expected)
        {
            // Arrange
            Triangle a = Triangle.Initialize(string.Empty, firstTriangleA, firstTriangleB, firstTriangleC);
            Triangle b = Triangle.Initialize(string.Empty, secondTriangleA, secondTriangleB, secondTriangleC);

            // Act
            int actual = a.CompareTo(b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test of ToString()
        /// </summary>
        /// <param name="name">Name of future triangle</param>
        /// <param name="a">A side value</param>
        /// <param name="b">B side value</param>
        /// <param name="c">C side value</param>
        /// <param name="expected">Expected result of ToString()</param>
        [DataTestMethod]
        [DataRow("", 3, 4, 5, "[]: 6 cm")]
        [DataRow("Test", 3, 4, 5, "[Test]: 6 cm")]
        [DataRow("Hello name", 5, 5, 6, "[Hello name]: 12 cm")]
        public void ToString_Test(string name, float a, float b, float c, string expected)
        {
            // Arrange
            Triangle triangle = Triangle.Initialize(name, a, b, c);

            // Act
            string actual = triangle.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
