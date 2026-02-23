namespace Week_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNumberInput = new System.Windows.Forms.Label();
            this.buttonCreateArray = new System.Windows.Forms.Button();
            this.textBoxNumberInputs = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.buttonAddNumber = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonSearchIndex = new System.Windows.Forms.Button();
            this.labelSearchOutput = new System.Windows.Forms.Label();
            this.buttonModifyValue = new System.Windows.Forms.Button();
            this.labelInput1 = new System.Windows.Forms.Label();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.buttonFindMax = new System.Windows.Forms.Button();
            this.labelMaxValue = new System.Windows.Forms.Label();
            this.buttonAreEqual = new System.Windows.Forms.Button();
            this.labelAreEqual = new System.Windows.Forms.Label();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.labelInput2 = new System.Windows.Forms.Label();
            this.buttonFindGCD = new System.Windows.Forms.Button();
            this.labelFindGCD = new System.Windows.Forms.Label();
            this.buttonFindSum = new System.Windows.Forms.Button();
            this.labelFindSum = new System.Windows.Forms.Label();
            this.labelFindAverage = new System.Windows.Forms.Label();
            this.buttonFindAverage = new System.Windows.Forms.Button();
            this.buttonToString = new System.Windows.Forms.Button();
            this.buttonScalarMultiply = new System.Windows.Forms.Button();
            this.buttonAddConstant = new System.Windows.Forms.Button();
            this.panelArrayCreation = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelArrayCreation.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumberInput
            // 
            this.labelNumberInput.Location = new System.Drawing.Point(30, 10);
            this.labelNumberInput.Name = "labelNumberInput";
            this.labelNumberInput.Size = new System.Drawing.Size(200, 14);
            this.labelNumberInput.TabIndex = 0;
            this.labelNumberInput.Text = "Input Length or numbers seperarted by \",\".";
            this.labelNumberInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreateArray
            // 
            this.buttonCreateArray.Location = new System.Drawing.Point(15, 70);
            this.buttonCreateArray.Name = "buttonCreateArray";
            this.buttonCreateArray.Size = new System.Drawing.Size(110, 24);
            this.buttonCreateArray.TabIndex = 2;
            this.buttonCreateArray.Text = "Create Empty Array";
            this.buttonCreateArray.UseVisualStyleBackColor = true;
            this.buttonCreateArray.Click += new System.EventHandler(this.ButtonCreateArray_Click);
            // 
            // textBoxNumberInputs
            // 
            this.textBoxNumberInputs.Location = new System.Drawing.Point(50, 40);
            this.textBoxNumberInputs.Name = "textBoxNumberInputs";
            this.textBoxNumberInputs.Size = new System.Drawing.Size(160, 20);
            this.textBoxNumberInputs.TabIndex = 1;
            // 
            // labelLength
            // 
            this.labelLength.Location = new System.Drawing.Point(89, 111);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(80, 14);
            this.labelLength.TabIndex = 0;
            this.labelLength.Text = "Length: N/A";
            this.labelLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddNumber
            // 
            this.buttonAddNumber.Location = new System.Drawing.Point(135, 70);
            this.buttonAddNumber.Name = "buttonAddNumber";
            this.buttonAddNumber.Size = new System.Drawing.Size(110, 24);
            this.buttonAddNumber.TabIndex = 3;
            this.buttonAddNumber.Text = "Create Full Array";
            this.buttonAddNumber.UseVisualStyleBackColor = true;
            this.buttonAddNumber.Click += new System.EventHandler(this.ButtonAddNumber_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.Location = new System.Drawing.Point(20, 12);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(480, 14);
            this.labelOutput.TabIndex = 0;
            this.labelOutput.Text = "Output: N/A";
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSearchIndex
            // 
            this.buttonSearchIndex.Enabled = false;
            this.buttonSearchIndex.Location = new System.Drawing.Point(15, 20);
            this.buttonSearchIndex.Name = "buttonSearchIndex";
            this.buttonSearchIndex.Size = new System.Drawing.Size(70, 24);
            this.buttonSearchIndex.TabIndex = 4;
            this.buttonSearchIndex.Text = "Search";
            this.buttonSearchIndex.UseVisualStyleBackColor = true;
            this.buttonSearchIndex.Click += new System.EventHandler(this.ButtonSearchIndex_Click);
            // 
            // labelSearchOutput
            // 
            this.labelSearchOutput.Location = new System.Drawing.Point(20, 105);
            this.labelSearchOutput.Name = "labelSearchOutput";
            this.labelSearchOutput.Size = new System.Drawing.Size(70, 14);
            this.labelSearchOutput.TabIndex = 0;
            this.labelSearchOutput.Text = "Value: N/A";
            // 
            // buttonModifyValue
            // 
            this.buttonModifyValue.Enabled = false;
            this.buttonModifyValue.Location = new System.Drawing.Point(15, 60);
            this.buttonModifyValue.Name = "buttonModifyValue";
            this.buttonModifyValue.Size = new System.Drawing.Size(70, 24);
            this.buttonModifyValue.TabIndex = 6;
            this.buttonModifyValue.Text = "Update";
            this.buttonModifyValue.UseVisualStyleBackColor = true;
            this.buttonModifyValue.Click += new System.EventHandler(this.ButtonModifyValue_Click);
            // 
            // labelInput1
            // 
            this.labelInput1.Location = new System.Drawing.Point(195, 26);
            this.labelInput1.Name = "labelInput1";
            this.labelInput1.Size = new System.Drawing.Size(70, 14);
            this.labelInput1.TabIndex = 0;
            this.labelInput1.Text = "Index/Index 1";
            this.labelInput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Enabled = false;
            this.textBoxInput1.Location = new System.Drawing.Point(100, 22);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(80, 20);
            this.textBoxInput1.TabIndex = 5;
            // 
            // buttonFindMax
            // 
            this.buttonFindMax.Enabled = false;
            this.buttonFindMax.Location = new System.Drawing.Point(15, 10);
            this.buttonFindMax.Name = "buttonFindMax";
            this.buttonFindMax.Size = new System.Drawing.Size(80, 24);
            this.buttonFindMax.TabIndex = 7;
            this.buttonFindMax.Text = "Max";
            this.buttonFindMax.UseVisualStyleBackColor = true;
            this.buttonFindMax.Click += new System.EventHandler(this.ButtonFindMax_Click);
            // 
            // labelMaxValue
            // 
            this.labelMaxValue.Location = new System.Drawing.Point(15, 45);
            this.labelMaxValue.Name = "labelMaxValue";
            this.labelMaxValue.Size = new System.Drawing.Size(100, 14);
            this.labelMaxValue.TabIndex = 0;
            this.labelMaxValue.Text = "Max Value: N/A";
            this.labelMaxValue.Click += new System.EventHandler(this.labelMaxValue_Click);
            // 
            // buttonAreEqual
            // 
            this.buttonAreEqual.Enabled = false;
            this.buttonAreEqual.Location = new System.Drawing.Point(125, 10);
            this.buttonAreEqual.Name = "buttonAreEqual";
            this.buttonAreEqual.Size = new System.Drawing.Size(80, 24);
            this.buttonAreEqual.TabIndex = 9;
            this.buttonAreEqual.Text = "Equal";
            this.buttonAreEqual.UseVisualStyleBackColor = true;
            this.buttonAreEqual.Click += new System.EventHandler(this.ButtonAreEqual_Click);
            // 
            // labelAreEqual
            // 
            this.labelAreEqual.Location = new System.Drawing.Point(125, 45);
            this.labelAreEqual.Name = "labelAreEqual";
            this.labelAreEqual.Size = new System.Drawing.Size(100, 14);
            this.labelAreEqual.TabIndex = 0;
            this.labelAreEqual.Text = "Are Equal: N/A";
            this.labelAreEqual.Click += new System.EventHandler(this.labelAreEqual_Click);
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Enabled = false;
            this.textBoxInput2.Location = new System.Drawing.Point(100, 62);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(80, 20);
            this.textBoxInput2.TabIndex = 11;
            // 
            // labelInput2
            // 
            this.labelInput2.Location = new System.Drawing.Point(195, 66);
            this.labelInput2.Name = "labelInput2";
            this.labelInput2.Size = new System.Drawing.Size(70, 14);
            this.labelInput2.TabIndex = 0;
            this.labelInput2.Text = "Value/Index 2";
            this.labelInput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFindGCD
            // 
            this.buttonFindGCD.Enabled = false;
            this.buttonFindGCD.Location = new System.Drawing.Point(235, 10);
            this.buttonFindGCD.Name = "buttonFindGCD";
            this.buttonFindGCD.Size = new System.Drawing.Size(100, 24);
            this.buttonFindGCD.TabIndex = 13;
            this.buttonFindGCD.Text = "buttonFindGCD";
            this.buttonFindGCD.UseVisualStyleBackColor = true;
            this.buttonFindGCD.Click += new System.EventHandler(this.ButtonFindGCD_Click);
            // 
            // labelFindGCD
            // 
            this.labelFindGCD.Location = new System.Drawing.Point(235, 45);
            this.labelFindGCD.Name = "labelFindGCD";
            this.labelFindGCD.Size = new System.Drawing.Size(100, 14);
            this.labelFindGCD.TabIndex = 0;
            this.labelFindGCD.Text = "GCD: N/A";
            this.labelFindGCD.Click += new System.EventHandler(this.labelFindGCD_Click);
            // 
            // buttonFindSum
            // 
            this.buttonFindSum.Enabled = false;
            this.buttonFindSum.Location = new System.Drawing.Point(15, 70);
            this.buttonFindSum.Name = "buttonFindSum";
            this.buttonFindSum.Size = new System.Drawing.Size(80, 24);
            this.buttonFindSum.TabIndex = 15;
            this.buttonFindSum.Text = "Sum";
            this.buttonFindSum.UseVisualStyleBackColor = true;
            this.buttonFindSum.Click += new System.EventHandler(this.ButtonFindSum_Click);
            // 
            // labelFindSum
            // 
            this.labelFindSum.Location = new System.Drawing.Point(15, 100);
            this.labelFindSum.Name = "labelFindSum";
            this.labelFindSum.Size = new System.Drawing.Size(100, 14);
            this.labelFindSum.TabIndex = 0;
            this.labelFindSum.Text = "Sum: N/A";
            // 
            // labelFindAverage
            // 
            this.labelFindAverage.Location = new System.Drawing.Point(125, 100);
            this.labelFindAverage.Name = "labelFindAverage";
            this.labelFindAverage.Size = new System.Drawing.Size(100, 14);
            this.labelFindAverage.TabIndex = 0;
            this.labelFindAverage.Text = "Average: N/A";
            // 
            // buttonFindAverage
            // 
            this.buttonFindAverage.Enabled = false;
            this.buttonFindAverage.Location = new System.Drawing.Point(125, 70);
            this.buttonFindAverage.Name = "buttonFindAverage";
            this.buttonFindAverage.Size = new System.Drawing.Size(80, 24);
            this.buttonFindAverage.TabIndex = 17;
            this.buttonFindAverage.Text = "Average";
            this.buttonFindAverage.UseVisualStyleBackColor = true;
            this.buttonFindAverage.Click += new System.EventHandler(this.ButtonFindAverage_Click);
            // 
            // buttonToString
            // 
            this.buttonToString.Enabled = false;
            this.buttonToString.Location = new System.Drawing.Point(235, 70);
            this.buttonToString.Name = "buttonToString";
            this.buttonToString.Size = new System.Drawing.Size(80, 24);
            this.buttonToString.TabIndex = 19;
            this.buttonToString.Text = "ToString";
            this.buttonToString.UseVisualStyleBackColor = true;
            this.buttonToString.Click += new System.EventHandler(this.ButtonToString_Click);
            // 
            // buttonScalarMultiply
            // 
            this.buttonScalarMultiply.Location = new System.Drawing.Point(355, 10);
            this.buttonScalarMultiply.Name = "buttonScalarMultiply";
            this.buttonScalarMultiply.Size = new System.Drawing.Size(90, 24);
            this.buttonScalarMultiply.TabIndex = 20;
            this.buttonScalarMultiply.Text = "Scalar Multiply";
            this.buttonScalarMultiply.UseVisualStyleBackColor = true;
            this.buttonScalarMultiply.Click += new System.EventHandler(this.ButtonScalarMultiply_Click);
            // 
            // buttonAddConstant
            // 
            this.buttonAddConstant.Location = new System.Drawing.Point(355, 70);
            this.buttonAddConstant.Name = "buttonAddConstant";
            this.buttonAddConstant.Size = new System.Drawing.Size(90, 24);
            this.buttonAddConstant.TabIndex = 21;
            this.buttonAddConstant.Text = "Add Constant";
            this.buttonAddConstant.UseVisualStyleBackColor = true;
            this.buttonAddConstant.Click += new System.EventHandler(this.ButtonAddConstant_Click);
            // 
            // panelArrayCreation
            // 
            this.panelArrayCreation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelArrayCreation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelArrayCreation.Controls.Add(this.labelNumberInput);
            this.panelArrayCreation.Controls.Add(this.textBoxNumberInputs);
            this.panelArrayCreation.Controls.Add(this.buttonCreateArray);
            this.panelArrayCreation.Controls.Add(this.buttonAddNumber);
            this.panelArrayCreation.Controls.Add(this.labelLength);
            this.panelArrayCreation.Location = new System.Drawing.Point(100, 60);
            this.panelArrayCreation.Name = "panelArrayCreation";
            this.panelArrayCreation.Size = new System.Drawing.Size(260, 140);
            this.panelArrayCreation.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.buttonSearchIndex);
            this.panelSearch.Controls.Add(this.buttonModifyValue);
            this.panelSearch.Controls.Add(this.textBoxInput1);
            this.panelSearch.Controls.Add(this.textBoxInput2);
            this.panelSearch.Controls.Add(this.labelInput2);
            this.panelSearch.Controls.Add(this.labelInput1);
            this.panelSearch.Controls.Add(this.labelSearchOutput);
            this.panelSearch.Location = new System.Drawing.Point(398, 60);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(280, 140);
            this.panelSearch.TabIndex = 0;
            // 
            // panelOutput
            // 
            this.panelOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutput.Controls.Add(this.labelOutput);
            this.panelOutput.Location = new System.Drawing.Point(130, 220);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(520, 40);
            this.panelOutput.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonFindMax);
            this.panel1.Controls.Add(this.labelMaxValue);
            this.panel1.Controls.Add(this.buttonFindSum);
            this.panel1.Controls.Add(this.labelFindSum);
            this.panel1.Controls.Add(this.buttonAddConstant);
            this.panel1.Controls.Add(this.buttonAreEqual);
            this.panel1.Controls.Add(this.buttonScalarMultiply);
            this.panel1.Controls.Add(this.labelAreEqual);
            this.panel1.Controls.Add(this.buttonToString);
            this.panel1.Controls.Add(this.buttonFindAverage);
            this.panel1.Controls.Add(this.labelFindGCD);
            this.panel1.Controls.Add(this.labelFindAverage);
            this.panel1.Controls.Add(this.buttonFindGCD);
            this.panel1.Location = new System.Drawing.Point(160, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 130);
            this.panel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelArrayCreation);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelArrayCreation.ResumeLayout(false);
            this.panelArrayCreation.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNumberInput;
        private System.Windows.Forms.Button buttonCreateArray;
        private System.Windows.Forms.TextBox textBoxNumberInputs;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Button buttonAddNumber;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonSearchIndex;
        private System.Windows.Forms.Label labelSearchOutput;
        private System.Windows.Forms.Button buttonModifyValue;
        private System.Windows.Forms.Label labelInput1;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.Button buttonFindMax;
        private System.Windows.Forms.Label labelMaxValue;
        private System.Windows.Forms.Button buttonAreEqual;
        private System.Windows.Forms.Label labelAreEqual;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.Label labelInput2;
        private System.Windows.Forms.Button buttonFindGCD;
        private System.Windows.Forms.Label labelFindGCD;
        private System.Windows.Forms.Button buttonFindSum;
        private System.Windows.Forms.Label labelFindSum;
        private System.Windows.Forms.Label labelFindAverage;
        private System.Windows.Forms.Button buttonFindAverage;
        private System.Windows.Forms.Button buttonToString;
        private System.Windows.Forms.Button buttonScalarMultiply;
        private System.Windows.Forms.Button buttonAddConstant;
        private System.Windows.Forms.Panel panelArrayCreation;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Panel panel1;
    }
}

