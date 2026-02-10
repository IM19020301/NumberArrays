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
            private int[] Numbers { get; set; }

            // Constructor.
            public ArrayofNumbers(int length)
            {
                Numbers = new int[length];

                int i = 0;
                while (i < length)
                {
                    Numbers[i] = (0);
                    i++;
                }
            }

            // Method to output the contents of the array for debug purposes.
            public void outputArray()
            {
                int i = 0;
                while (i < Numbers.Length)
                {
                    Console.WriteLine("Number " + (i + 1) + ": " + Numbers[i]);
                    i++;
                }
            }
        }
    }
}
