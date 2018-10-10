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
        private readonly SquareField a;

        /// <summary>
        /// B side
        /// </summary>
        private readonly SquareField b;

        /// <summary>
        /// C side
        /// </summary>
        private readonly SquareField c;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class
        /// </summary>
        /// <param name="name">Name of triangle</param>
        /// <param name="a">A side</param>
        /// <param name="b">B side</param>
        /// <param name="c">C side</param>
        public Triangle(string name, SquareField a, SquareField b, SquareField c)
        {
            this.name = name;
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Gets perimetr of the triangle
        /// </summary>
        public float Perimetr
        {
            get
            {
                return this.a.Value + this.b.Value + this.c.Value;
            }
        }

        /// <summary>
        /// Gets square of the triangle
        /// </summary>
        public float Square
        {
            get
            {
                float semiP = this.Perimetr / 2;
                float val = (float)Math.Sqrt(semiP * (semiP - this.a.Value) * (semiP - this.b.Value) * (semiP - this.c.Value));
                if (val <= 0)
                {
                    throw new ArgumentOutOfRangeException("Traingle doesn`t exist!");
                }

                return val;
            }
        }

        /// <summary>
        /// Compare of two triangles
        /// </summary>
        /// <param name="shapeToCompare">Other traingle</param>
        /// <returns>Result of comparation</returns>
        public int CompareTo(IShape shapeToCompare)
        {
            int result = 0;
            if (this.Square > shapeToCompare.Square)
            {
                result = -1;
            }
            else if (this.Square < shapeToCompare.Square)
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
            return "[" + this.name + "]: " + this.Square + " cm";
        }
    }
}
