// <copyright file="Program.cs" company="My company">
//     Copyright (c) My company". All rights reserved.
// </copyright>

namespace Task3_UI
{
    /// <summary>
    /// Main class of the program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of the program
        /// </summary>
        /// <param name="args">Command line args</param>
        private static void Main(string[] args)
        {
            TrianglesConsoleMenu consoleMenu = new TrianglesConsoleMenu();
            consoleMenu.Menu(args);
        }
    }
}
