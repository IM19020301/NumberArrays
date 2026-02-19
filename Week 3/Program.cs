using System;
using System.Collections.Generic;
using System.Linq;
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
                int i = 0;
                while (i < Length)
                {
                    Console.WriteLine("Number " + (i + 1) + ": " + Numbers[i]);
                    i++;
                }
            }

            public void SetArray(int[] array)
            {
                int i = 0;
                while (i < Length)
                {
                    Numbers[i] = array[i];
                    i++;
                }
            }

            public int FindItem(int index)
            {
                return Numbers[index];
            }


            public int GetLength()
            {
                return Length;
            }
        }
    }
}
