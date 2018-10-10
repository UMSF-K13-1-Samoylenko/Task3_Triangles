// <copyright file="ArgumentsCountException.cs" company="My company">
//     Copyright (c) My company". All rights reserved.
// </copyright>

namespace Task3_Lib
{
    using System;

    /// <summary>
    /// ArgumentsCountException
    /// Use when the number of arguments passed does not match the required number
    /// </summary>
    public class ArgumentsCountException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentsCountException"/> class
        /// </summary>
        public ArgumentsCountException() : base("The number of arguments does not match")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentsCountException"/> class
        /// </summary>
        /// <param name="message">Message to user</param>
        public ArgumentsCountException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentsCountException"/> class
        /// </summary>
        /// <param name="message">Message to user</param>
        /// <param name="innerException">Base exception</param>
        public ArgumentsCountException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
