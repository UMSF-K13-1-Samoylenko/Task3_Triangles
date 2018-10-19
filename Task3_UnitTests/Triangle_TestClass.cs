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
            SquareField squareFieldA = new SquareField
            {
                Value = a
            };
            SquareField squareFieldB = new SquareField
            {
                Value = b
            };
            SquareField squareFieldC = new SquareField
            {
                Value = c
            };
            Triangle triangle = new Triangle("test", squareFieldA, squareFieldB, squareFieldC);

            // Actual
            float actual = (float)Math.Round(triangle.Square, 2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Checking work of squareField class
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
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SquareField_InputIncorrect(float a, float b, float c)
        {
            SquareField squareFieldA = new SquareField
            {
                Value = a
            };
            SquareField squareFieldB = new SquareField
            {
                Value = b
            };
            SquareField squareFieldC = new SquareField
            {
                Value = c
            };
        }
    }
}
