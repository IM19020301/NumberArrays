using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Week_3.Program;

namespace Week_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayofNumbers numberArray;
        int[] inputArray;
        int count = 0;

        // On button press creates a new instance of ArrayofNumbers.
        private void buttonCreateArray_Click(object sender, EventArgs e)
        {
            // Declares varaibles.
            int length;
            bool validLenght;

            // Sets variables.
            validLenght = false;

            // Checks if length is valid and able to be used.
            if (Int32.TryParse(textBoxNumberInputs.Text, out length) && length > 0)
            {
                // Marks length as valid.
                validLenght = true;
            }
            else
            {
                // Provids feedback through the labels.
                labelOutput.Text = "length is invalid";
            }

            // If length is valid creates a new ArrayofNumbers and then then sets the length of the array.
            if (validLenght == true)
            {
                // Creates a new insatnce of ArrayofNumbers with the set length.
                numberArray = new ArrayofNumbers(length);

                // Provids feedback through the labels.
                labelLength.Text = "Length: " + length;

                // Creates the input array.
                inputArray = new int[length];

                int i = 0;
                while (i < length)
                {
                    inputArray[i] = (0);
                    i++;
                }

                // Enables the add number button.
                buttonAddNumber.Enabled = true;

                // Updates the label texts.
                labelAddNumber.Text = "Add Number: 0/" + length;
                labelNumberInput.Text = "Please input numbers with ',' between each one.";
            }
        }

        // On button press creates a new inputArray array and then puts its contents into ArrayofNumbers.
        private void buttonAddNumber_Click(object sender, EventArgs e)
        {
            // Declares varaibles.
            int number;

            // Sets variables.
            string inputNumbers = textBoxNumberInputs.Text;
            string[] subNumbers = inputNumbers.Split(',');

            // If the number of input numbers matches the length of the inputArray then continues.
            if (subNumbers.Length == inputArray.Length)
            {
                // Goes through each number in the inputNumbers string and validates them before adding them to the inputArray.
                int i = 0;
                foreach (string str in subNumbers)
                {
                    // Declares varaibles.
                    bool validNumber;

                    // Sets variables.
                    validNumber = false;

                    // Checks if number is valid and able to be used.
                    if (Int32.TryParse(str, out number) && number > 0)
                    {
                        // Marks number as valid.
                        validNumber = true;
                    }
                    else
                    {
                        // Provids feedback through the labels.
                        labelOutput.Text = "number " + i + " is invalid.";
                    }

                    // If number is valid adds it to the inputArray.
                    if (validNumber == true)
                    {
                        // Adds the number to the inputArray.
                        inputArray[i] = number;
                        i++;
                    }
                }

                // Sets the number values of the numberArray to match the inputArray.
                numberArray.setArray(inputArray);

                // Outputs the contents of the array for debug purposes.
                numberArray.outputArray();

                // Updates the label texts.
                labelOutput.Text = "Array populated";
            }
            else
            {
                // Updates the label texts.
                labelOutput.Text = "Incorrect amount of numbers, number count must match length.";
            }
        }
    }
}
