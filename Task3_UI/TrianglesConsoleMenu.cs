// <copyright file="TrianglesConsoleMenu.cs" company="My company">
//     Copyright (c) My company". All rights reserved.
// </copyright>

namespace Task3_UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Task3_Lib;

    /// <summary>
    /// Traingle console menu class
    /// </summary>
    public class TrianglesConsoleMenu
    {
        /// <summary>
        /// List of all shapes
        /// </summary>
        private readonly List<IShape> shapes;

        /// <summary>
        /// Separators string array to split args
        /// </summary>
        private readonly char[] splitSeparators;

        /// <summary>
        /// Initializes a new instance of the <see cref="TrianglesConsoleMenu"/> class
        /// </summary>
        public TrianglesConsoleMenu()
        {
            this.shapes = new List<IShape>();
            this.splitSeparators = new char[] 
            {
                ',',
                ' '
            };
        }

        /// <summary>
        /// User menu
        /// </summary>
        /// <param name="args">Console args</param>
        public void Menu(string[] args)
        {
            switch (args.Length)
            {
                case 4:
                {
                    this.MenuCycle(args);
                    break;
                }

                default:
                {
                    this.Instruction();
                    break;
                }
            }
        }

        /// <summary>
        /// Method to sort list with shapes
        /// </summary>
        private void SortShapes()
        {
            this.shapes.Sort();
        }

        /// <summary>
        /// Instruction for the program (console print)
        /// </summary>
        private void Instruction()
        {
            Console.WriteLine("Program assignment" + Environment.NewLine +
            "Sorts triangles by square desc" + Environment.NewLine +
            "Launch example: Task3_UI.exe <triangle_name>, <first_side>, <second_side>, <third_side>");
        }

        /// <summary>
        /// Method to construct triangle from string array of args
        /// </summary>
        /// <param name="args">Triangle parts in string view</param>
        /// <returns>Triangle object</returns>
        /// <exception cref="ArgumentsCountException">Throws when count of args is not correct</exception>
        /// <exception cref="FormatException">Throws when could not convert one of args to Double</exception>
        /// <exception cref="OverflowException">Throws when converted value was more than doube type value allow</exception>
        private Triangle TriangleConstructor(string[] args)
        {
            if (args.Length == 4)
            {
                return Triangle.Initialize(
                    args[0],
                    (float)Convert.ToDouble(args[1]),
                    (float)Convert.ToDouble(args[2]),
                    (float)Convert.ToDouble(args[3]));
            }
            else
            {
                throw new ArgumentsCountException();
            }
        }

        /// <summary>
        /// Method for emulate console menu
        /// </summary>
        /// <param name="args">Initialized args from console</param>
        private void MenuCycle(string[] args)
        {
            bool exceptionFlag = false;
            do
            {
                try
                {
                    string input = string.Empty;
                    if (!exceptionFlag)
                    {
                        args = args.Select(arg => arg.Replace(",", string.Empty)).ToArray();
                        Triangle triangle = this.TriangleConstructor(args);
                        this.shapes.Add(triangle);
                        this.SortShapes();
                        this.PrintShapes();
                        Console.Write("If you wan to continue please enter \"y\" or \"yes\":");
                        input = Console.ReadLine().ToLower();
                    }
                    if (input == "y" || input == "yes" || exceptionFlag)
                    {
                        Console.Clear();
                        Console.Write("Please enter triangle name and sides values:");
                        input = Console.ReadLine();
                        args = input.Split(this.splitSeparators, StringSplitOptions.RemoveEmptyEntries);
                        exceptionFlag = false;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    exceptionFlag = true;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    exceptionFlag = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    exceptionFlag = true;
                }
                catch (ArgumentsCountException ex)
                {
                    Console.WriteLine(ex.Message);
                    exceptionFlag = true;
                }
            }
            while (true);
        }

        /// <summary>
        /// Print all shapes
        /// </summary>
        private void PrintShapes()
        {
            foreach (IShape shapeItem in this.shapes)
            {
                Console.WriteLine(shapeItem);
            }
        }
    }
}
