using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // Public class ArrayofNumbers, stores an array of numbers and provides several methods to do stuff with it.
        public class ArrayofNumbers
        {
            // Properties.
            private int[] Numbers;
            private int Length;

            // Constructor.
            public ArrayofNumbers(int length)
            {
                Length = length;
                Numbers = new int[Length];

                // Sets all values in Numbers to 0.
                int i = 0;
                while (i < Length)
                {
                    Numbers[i] = (0);
                    i++;
                }
            }

            // Method to output the contents of the array for debug purposes.
            public void OutputArray()
            {
                // While loop that runs for the entire length of the Numbers array.
                int i = 0;
                while (i < Length)
                {
                    // Outputs the current value to the console.
                    Console.WriteLine("Number " + (i + 1) + ": " + Numbers[i]);
                    i++;
                }
            }

            // Method to set the value of the Numbers array.
            public void SetArray(int[] array)
            {
                // While loop that runs for the entire length of the Numbers array.
                int i = 0;
                while (i < Length)
                {
                    // Sets the value of Numbers to the same value as array.
                    Numbers[i] = array[i];
                    i++;
                }
            }

            // Method to output the value at a specific index.
            public int FindItem(int index)
            {
                // Returns value at selected index.
                return Numbers[index];
            }

            // Method to update the value at a specific index.
            public void SetItemValue(int index, int newValue)
            {
                // Sets value at selected index.
                Numbers[index] = newValue;
            }

            // Method to find the highest value in the array.
            public int FindMax()
            {
                // Declares variables.
                int highestValue;

                // Sets variables.
                highestValue = 0;

                // While loop that runs for the entire length of the Numbers array.
                int i = 0;
                while (i < Length)
                {
                    // If the value in Numbers is higher than the highest value set the highest value to the value.
                    if (Numbers[i] > highestValue)
                    {
                        // Sets the highestValue to the currently selected value from Numbers.
                        highestValue = Numbers[i];
                    }
                    i++;
                }

                // returns highestValue.
                return highestValue;
            }

            // Method to find if two values in the array are equal.
            public bool AreEqual(int index1, int index2)
            {
                // Declares variables.
                bool areEqual;

                // Sets variables.
                areEqual = false;

                // If the value at the first index is the same as the value at the second index set areEqual to true.
                if (Numbers[index1] == Numbers[index2])
                {
                    // Sets areEqual to true
                    areEqual = true;
                }

                // returns areEqual.
                return areEqual;
            }

            // Method to find the greatest commmon divisor (GCD) between the two numbers.
            public int CalculateGCD(int index1, int index2)
            {
                // Declares function variables
                int number1;
                int number2;
                int smallerInt;
                int difference;

                // Sets function variable values.
                number1 = Numbers[index1];
                number2 = Numbers[index2];
                smallerInt = 1;
                difference = 0;

                // Flips numbers if number2 is smaller than number1.
                if (number2 < number1)
                {
                    (number2, number1) = (number1, number2);
                }

                // If numbers are equal than function ddoes not need to be run.
                if (number1 == number2)
                {
                    difference = number1;
                }
                // Else runs the function as normal.
                else
                {
                    // Run the calculation while the smallest number is not equal to the difference.
                    while (smallerInt != difference)
                    {
                        // If number2 is smaller than number1 subtract number2 from number1.
                        if (number2 < number1)
                        {
                            difference = number1 - number2;
                            number1 = difference;
                            smallerInt = number2;
                        }
                        // Else subtract number1 from number2.
                        else
                        {
                            difference = number2 - number1;
                            number2 = difference;
                            smallerInt = number1;
                        }
                    }
                }

                // Returns the value of the GCD.
                return difference;
            }

            // Method to return the sum of the array.
            public int FindSum()
            {
                // Returns sum of Numbers.
                return Numbers.Sum();
            }

            // method to get the length of the array
            public int GetLength()
            {
                // returns Length.
                return Length;
            }
        }
    }
}
