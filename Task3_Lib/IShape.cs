// <copyright file="IShape.cs" company="My company">
//     Copyright (c) My company". All rights reserved.
// </copyright>

namespace Task3_Lib
{
    using System;

    /// <summary>
    /// IShape interface
    /// </summary>
    public interface IShape : IComparable<IShape>
    {
        /// <summary>
        /// Gets sqare of shape
        /// </summary>
        float Square
        {
            get;
        }

        /// <summary>
        /// Gets perimetr of shape
        /// </summary>
        float Perimetr
        {
            get;
        }

        /// <summary>
        /// Method to compare two objects
        /// </summary>
        /// <param name="shapeToCompare">Shape to compare</param>
        /// <returns>Result of compare</returns>
        new int CompareTo(IShape shapeToCompare);
    }
}
