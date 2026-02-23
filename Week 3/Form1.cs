using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        private void ButtonCreateArray_Click(object sender, EventArgs e)
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
                // Provids feedback through the label.
                labelOutput.Text = "length is invalid";
            }

            // If length is valid creates a new ArrayofNumbers and then then sets the length of the array.
            if (validLenght == true)
            {
                // Creates a new instance of ArrayofNumbers with the set length.
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

                // Enables and disables buttons.
                buttonAddNumber.Enabled = false;
                buttonCreateArray.Enabled = false;
                buttonSearchIndex.Enabled = true;
                buttonModifyValue.Enabled = true;
                textBoxInput1.Enabled = true;
                textBoxInput2.Enabled = true;
                buttonFindMax.Enabled = true;
                buttonAreEqual.Enabled = true;
                buttonFindGCD.Enabled = true;
                buttonFindSum.Enabled = true;
                buttonFindAverage.Enabled = true;
                buttonToString.Enabled = true;

                // Provids feedback through the labels.
                labelOutput.Text = "Empty array created.";
            }
        }

        // On button press creates a new inputArray array and then puts its contents into ArrayofNumbers.
        private void ButtonAddNumber_Click(object sender, EventArgs e)
        {
            // Declares varaibles.
            int length;
            int number;

            // Sets variables.
            string inputNumbers = textBoxNumberInputs.Text;
            string[] subNumbers = inputNumbers.Split(',');
            length = subNumbers.Length;

            // Creates the input array.
            inputArray = new int[length];

            // Goes through each number in the inputNumbers string and validates them before adding them to the inputArray.
            int i = 0;
            foreach (string str in subNumbers)
            {
                // Declares varaibles.
                bool validNumber;

                // Sets variables.
                validNumber = false;

                // Checks if number is valid and able to be used.
                if (Int32.TryParse(str, out number) && number >= 0)
                {
                    // Marks number as valid.
                    validNumber = true;
                }
                else
                {
                    // Provids feedback through the label.
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

            // Creates a new instance of ArrayofNumbers with the set length.
            numberArray = new ArrayofNumbers(inputArray);

            // Enables and disables buttons.
            buttonAddNumber.Enabled = false;
            buttonCreateArray.Enabled = false;
            buttonSearchIndex.Enabled = true;
            buttonModifyValue.Enabled = true;
            textBoxInput1.Enabled = true;
            textBoxInput2.Enabled = true;
            buttonFindMax.Enabled = true;
            buttonAreEqual.Enabled = true;
            buttonFindGCD.Enabled = true;
            buttonFindSum.Enabled = true;
            buttonFindAverage.Enabled = true;
            buttonToString.Enabled = true;

            // Provids feedback through the label.
            labelLength.Text = "Length: " + length;
            labelOutput.Text = "Full array created";
        }

        // On button press finds the value stored in numberArray at the inputed index.
        private void ButtonSearchIndex_Click(object sender, EventArgs e)
        {
            // Declares varaibles.
            int targetIndex;
            bool validIndex;

            // Sets variables.
            validIndex = false;

            // Checks if targetIndex is valid and able to be used.
            if (Int32.TryParse(textBoxInput1.Text, out targetIndex) && targetIndex >= 0)
            {
                // Marks targetIndex as valid.
                validIndex = true;
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Invalid search index";
            }

            // If targetIndex is valid search the for the value at targetIndex.
            if (validIndex == true && targetIndex < numberArray.GetLength())
            {
                // Provids feedback through the labels.
                labelSearchOutput.Text = "Found value: " + numberArray.FindItem(targetIndex);
                labelOutput.Text = "Search successful";
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Invalid search index";
            }
        }

        // On button press replaces the value stored in numberArray at the inputed index with the inpuded value.
        private void ButtonModifyValue_Click(object sender, EventArgs e)
        {
            // Declares varaibles.
            int targetIndex;
            int newValue;
            bool validIndex;
            bool validValue;

            // Sets variables.
            validIndex = false;
            validValue = false;

            // Checks if targetIndex is valid and able to be used.
            if (Int32.TryParse(textBoxInput1.Text, out targetIndex) && targetIndex >= 0)
            {
                // Marks targetIndex as valid.
                validIndex = true;
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Invalid search index";
            }

            // Checks if newValue is valid and able to be used.
            if (Int32.TryParse(textBoxInput2.Text, out newValue) && newValue >= 0)
            {
                // Marks newValue as valid.
                validValue = true;
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Invalid new value";
            }

            // If targetIndex and newValue is valid updates value at targetIndex.
            if (validIndex == true && validValue == true && targetIndex < numberArray.GetLength())
            {
                // Updates the value of the item at the target index
                numberArray.SetItemValue(targetIndex, newValue);

                // Provids feedback through the label.
                labelOutput.Text = "Update successful";
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Invalid index or new value";
            }
        }

        // On button press finds the maximum value stored in numberArray.
        private void ButtonFindMax_Click(object sender, EventArgs e)
        {
            labelMaxValue.Text = "Max Value: " + numberArray.FindMax();
        }

        // On button press checks if the values at the two selected indexes are equal.
        private void ButtonAreEqual_Click(object sender, EventArgs e)
        {
            // Declares varaibles.
            int targetIndex1;
            int targetIndex2;
            bool validIndex1;
            bool validIndex2;

            // Sets variables.
            validIndex1 = false;
            validIndex2 = false;

            // Checks if targetIndex1 is valid and able to be used.
            if (Int32.TryParse(textBoxInput1.Text, out targetIndex1) && targetIndex1 >= 0)
            {
                // Marks targetIndex1 as valid.
                validIndex1 = true;
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Invalid index 1";
            }

            // Checks if targetIndex2 is valid and able to be used.
            if (Int32.TryParse(textBoxInput2.Text, out targetIndex2) && targetIndex2 >= 0)
            {
                // Marks targetIndex2 as valid.
                validIndex2 = true;
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Invalid index 2";
            }

            // If both indexes are valid, both indexes are less than array length, and both indexes are not equal.
            if (validIndex1 == true && validIndex2 == true && targetIndex1 < numberArray.GetLength() && targetIndex2 < numberArray.GetLength() && targetIndex1 != targetIndex2)
            {
                // Provids feedback through the label.
                labelAreEqual.Text = "Are Equal: " + numberArray.AreEqual(targetIndex1, targetIndex2);
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Invalid index 1 or 2 are invalid";
            }
        }

        // On button press finds the GCD of the two numbers at teh selected indexes
        private void ButtonFindGCD_Click(object sender, EventArgs e)
        {
            // Declares varaibles.
            int targetIndex1;
            int targetIndex2;
            bool validIndex1;
            bool validIndex2;

            // Sets variables.
            validIndex1 = false;
            validIndex2 = false;

            // Checks if targetIndex1 is valid and able to be used.
            if (Int32.TryParse(textBoxInput1.Text, out targetIndex1) && targetIndex1 >= 0)
            {
                // Marks targetIndex1 as valid.
                validIndex1 = true;
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Invalid index 1";
            }

            // Checks if targetIndex2 is valid and able to be used.
            if (Int32.TryParse(textBoxInput2.Text, out targetIndex2) && targetIndex2 >= 0)
            {
                // Marks targetIndex2 as valid.
                validIndex2 = true;
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Invalid index 2";
            }

            // If both indexes are valid, both indexes are less than array length, and both indexes are not equal.
            if (validIndex1 == true && validIndex2 == true && targetIndex1 < numberArray.GetLength() && targetIndex2 < numberArray.GetLength() && targetIndex1 != targetIndex2)
            {
                // Provids feedback through the label.
                labelFindGCD.Text = "GCD: " + numberArray.CalculateGCD(targetIndex1, targetIndex2);
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Index 1 or 2 are invalid";
            }
        }

        // On button press finds the sum of all values in numberArray.
        private void ButtonFindSum_Click(object sender, EventArgs e)
        {
            labelFindSum.Text = "Sum: " + numberArray.FindSum();
        }

        // On button press finds the average of all values in numberArray.
        private void ButtonFindAverage_Click(object sender, EventArgs e)
        {
            labelFindAverage.Text = "Average: " + numberArray.FindAverage();
        }

        // On button press outputs the entire array in one long string.
        private void ButtonToString_Click(object sender, EventArgs e)
        {
            labelOutput.Text = numberArray.ToString();
        }

        // On button press scales entire array by an input scalar.
        private void ButtonScalarMultiply_Click(object sender, EventArgs e)
        {
            // Declares varaibles.
            int scalar;
            bool validScalar;

            // Sets variables.
            validScalar = false;

            // Checks if targetIndex2 is valid and able to be used.
            if (Int32.TryParse(textBoxInput2.Text, out scalar) && scalar >= 0)
            {
                // Marks targetIndex2 as valid.
                validScalar = true;
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Invalid scalar";
            }

            // If scalar is valid.
            if (validScalar == true)
            {
                // Runs numberArray the method.
                numberArray.ScalarMultiply(scalar);

                // Provids feedback through the label.
                labelOutput.Text = "Array multiplied by scalar";
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Invalid scalar";
            }
        }

        // On button press adds inputed constant to every element.
        private void ButtonAddConstant_Click(object sender, EventArgs e)
        {
            // Declares varaibles.
            int constant;
            bool validConstant;

            // Sets variables.
            validConstant = false;

            // Checks if targetIndex2 is valid and able to be used.
            if (Int32.TryParse(textBoxInput2.Text, out constant) && constant >= 0)
            {
                // Marks targetIndex2 as valid.
                validConstant = true;
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Invalid constant";
            }

            // If constant is valid.
            if (validConstant == true)
            {
                // Runs numberArray the method.
                numberArray.AddConstant(constant);

                // Provids feedback through the label.
                labelOutput.Text = "Constant added to array.";
            }
            else
            {
                // Provids feedback through the label.
                labelOutput.Text = "Invalid constant";
            }
        }
    }
}
