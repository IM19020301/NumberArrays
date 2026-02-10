using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        // On button press creates a new instance of ArrayofNumbers.
        private void buttonCreateArray_Click(object sender, EventArgs e)
        {
            // Declares varaibles.
            int length;
            bool validLenght;

            // Sets variables.
            validLenght = false;

            // Checks if length is valid and able to be used.
            if (Int32.TryParse(textBoxLengthInput.Text, out length) && length > 0)
            {
                // Marks length as valid.
                validLenght = true;
            }
            else
            {
                // Provids feedback through the labels.
                labelLength.Text = "length is invalid";
            }

            // If length is valid creates a new ArrayofNumbers and then then sets the length of the array.
            if (validLenght == true)
            {
                // Creates a new insatnce of ArrayofNumbers with the set length.
                ArrayofNumbers numberArray = new ArrayofNumbers(length);

                // Outputs the contents of the array for debug purposes.
                numberArray.outputArray();

                // Provids feedback through the labels.
                labelLength.Text = "Length: " + length;
            }
        }
    }
}
