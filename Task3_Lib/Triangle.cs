// <copyright file="Triangle.cs" company="My company">
//     Copyright (c) My company". All rights reserved.
// </copyright>

namespace Task3_Lib
{
    using System;

    /// <summary>
    /// Traingle class
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Name of triangle
        /// </summary>
        private readonly string name;

        /// <summary>
        /// A side
        /// </summary>
        private readonly float a;

        /// <summary>
        /// B side
        /// </summary>
        private readonly float b;

        /// <summary>
        /// C side
        /// </summary>
        private readonly float c;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class
        /// </summary>
        /// <param name="name">Name of triangle</param>
        /// <param name="a">A side</param>
        /// <param name="b">B side</param>
        /// <param name="c">C side</param>
        private Triangle(string name, float a, float b, float c)
        {
            this.name = name;
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Gets perimetr of the triangle.
        /// </summary>
        public float Perimetr
        {
            get
            {
                return this.a + this.b + this.c;
            }
        }

        /// <summary>
        /// Gets square of the triangle
        /// </summary>
        public float Area
        {
            get
            {
                float semiPerimetr = this.Perimetr / 2;
                float rootExpression = semiPerimetr * (semiPerimetr - this.a) * (semiPerimetr - this.b) * (semiPerimetr - this.c);
                float areaValue = (float)Math.Sqrt(rootExpression);
                return areaValue;
            }
        }

        /// <summary>
        /// Create instance of <see cref="Triangle"/> if parametrs are correct or throws exception in other case
        /// </summary>
        /// <param name="name">Name of future triangle</param>
        /// <param name="a">A side</param>
        /// <param name="b">B side</param>
        /// <param name="c">C side</param>
        /// <returns>Instance of <see cref="Triangle"/> or exception</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws in case when parametrs are incorrect</exception>
        public static Triangle Initialize(string name, float a, float b, float c)
        {
            if (Triangle.TriangleExist(a, b, c))
            {
                return new Triangle(name, a, b, c);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Triangle doesn`t exist!");
            }
        }

        /// <summary>
        /// Compare of two triangles by Area value (desc)
        /// </summary>
        /// <param name="shapeToCompare">Other traingle</param>
        /// <returns>Result of comparation</returns>
        public int CompareTo(IShape shapeToCompare)
        {
            int result = 0;
            if (this.Area > shapeToCompare.Area)
            {
                result = -1;
            }
            else if (this.Area < shapeToCompare.Area)
            {
                result = 1;
            }

            return result;
        }

        /// <summary>
        /// Method to get string view of the triangle
        /// </summary>
        /// <returns>String view of the triangle</returns>
        public override string ToString()
        {
            return $"[{this.name}]: {this.Area} cm";
        }

        /// <summary>
        /// Checking the existence of a triangle.
        /// </summary>
        /// <param name="a">A side value of future triangle.</param>
        /// <param name="b">B side value of future triangle.</param>
        /// <param name="c">C side value of future triangle.</param>
        /// <returns>True, if triangle with such parameters can exist.</returns>
        private static bool TriangleExist(float a, float b, float c)
        {
            return (a > 0 && b > 0 && c > 0) && ((a + b) > c) && ((a + c) > b) && ((b + c) > a);
        }
    }
}
