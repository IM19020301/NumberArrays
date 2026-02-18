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
            this.labelAddNumber = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumberInput
            // 
            this.labelNumberInput.AutoSize = true;
            this.labelNumberInput.Location = new System.Drawing.Point(323, 80);
            this.labelNumberInput.Name = "labelNumberInput";
            this.labelNumberInput.Size = new System.Drawing.Size(67, 13);
            this.labelNumberInput.TabIndex = 0;
            this.labelNumberInput.Text = "Input Length";
            // 
            // buttonCreateArray
            // 
            this.buttonCreateArray.Location = new System.Drawing.Point(260, 177);
            this.buttonCreateArray.Name = "buttonCreateArray";
            this.buttonCreateArray.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateArray.TabIndex = 2;
            this.buttonCreateArray.Text = "Create Array";
            this.buttonCreateArray.UseVisualStyleBackColor = true;
            this.buttonCreateArray.Click += new System.EventHandler(this.buttonCreateArray_Click);
            // 
            // textBoxNumberInputs
            // 
            this.textBoxNumberInputs.Location = new System.Drawing.Point(306, 111);
            this.textBoxNumberInputs.Name = "textBoxNumberInputs";
            this.textBoxNumberInputs.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberInputs.TabIndex = 1;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(267, 217);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(66, 13);
            this.labelLength.TabIndex = 0;
            this.labelLength.Text = "Length: N/A";
            // 
            // buttonAddNumber
            // 
            this.buttonAddNumber.Enabled = false;
            this.buttonAddNumber.Location = new System.Drawing.Point(362, 176);
            this.buttonAddNumber.Name = "buttonAddNumber";
            this.buttonAddNumber.Size = new System.Drawing.Size(70, 24);
            this.buttonAddNumber.TabIndex = 3;
            this.buttonAddNumber.Text = "Add Number";
            this.buttonAddNumber.UseVisualStyleBackColor = true;
            this.buttonAddNumber.Click += new System.EventHandler(this.buttonAddNumber_Click);
            // 
            // labelAddNumber
            // 
            this.labelAddNumber.AutoSize = true;
            this.labelAddNumber.Location = new System.Drawing.Point(359, 217);
            this.labelAddNumber.Name = "labelAddNumber";
            this.labelAddNumber.Size = new System.Drawing.Size(89, 13);
            this.labelAddNumber.TabIndex = 0;
            this.labelAddNumber.Text = "Add Number: 0/?";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(303, 245);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(65, 13);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Output: N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelAddNumber);
            this.Controls.Add(this.buttonAddNumber);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.textBoxNumberInputs);
            this.Controls.Add(this.buttonCreateArray);
            this.Controls.Add(this.labelNumberInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberInput;
        private System.Windows.Forms.Button buttonCreateArray;
        private System.Windows.Forms.TextBox textBoxNumberInputs;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Button buttonAddNumber;
        private System.Windows.Forms.Label labelAddNumber;
        private System.Windows.Forms.Label labelOutput;
    }
}

