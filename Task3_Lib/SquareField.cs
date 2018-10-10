// <copyright file="SquareField.cs" company="My company">
//     Copyright (c) My company". All rights reserved.
// </copyright>

namespace Task3_Lib
{
    using System;

    /// <summary>
    /// SquareField class to limit range of field values
    /// </summary>
    public class SquareField
    {
        /// <summary>
        /// Real value of current field
        /// </summary>
        private float val;

        /// <summary>
        /// Initializes a new instance of the <see cref="SquareField"/> class
        /// </summary>
        public SquareField()
        {
            this.Value = 1;
        }

        /// <summary>
        /// Gets or sets value of field
        /// </summary>
        public float Value
        {
            get
            {
                return this.val;
            }

            set
            {
                if (this.ValueCorrect(value))
                {
                    this.val = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Value is equal or less than zero. Please use correct value more than zero!");
                }
            }
        }

        /// <summary>
        /// Method to check is value correct
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <returns>Check result</returns>
        private bool ValueCorrect(float value)
        {
            return value > 0;
        }
    }
}
