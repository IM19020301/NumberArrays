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
            this.labelLengthInput = new System.Windows.Forms.Label();
            this.buttonCreateArray = new System.Windows.Forms.Button();
            this.textBoxLengthInput = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLengthInput
            // 
            this.labelLengthInput.AutoSize = true;
            this.labelLengthInput.Location = new System.Drawing.Point(314, 84);
            this.labelLengthInput.Name = "labelLengthInput";
            this.labelLengthInput.Size = new System.Drawing.Size(67, 13);
            this.labelLengthInput.TabIndex = 0;
            this.labelLengthInput.Text = "Input Length";
            // 
            // buttonCreateArray
            // 
            this.buttonCreateArray.Location = new System.Drawing.Point(307, 182);
            this.buttonCreateArray.Name = "buttonCreateArray";
            this.buttonCreateArray.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateArray.TabIndex = 1;
            this.buttonCreateArray.Text = "Create Array";
            this.buttonCreateArray.UseVisualStyleBackColor = true;
            this.buttonCreateArray.Click += new System.EventHandler(this.buttonCreateArray_Click);
            // 
            // textBoxLengthInput
            // 
            this.textBoxLengthInput.Location = new System.Drawing.Point(297, 115);
            this.textBoxLengthInput.Name = "textBoxLengthInput";
            this.textBoxLengthInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxLengthInput.TabIndex = 2;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(314, 222);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(66, 13);
            this.labelLength.TabIndex = 3;
            this.labelLength.Text = "Length: N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.textBoxLengthInput);
            this.Controls.Add(this.buttonCreateArray);
            this.Controls.Add(this.labelLengthInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLengthInput;
        private System.Windows.Forms.Button buttonCreateArray;
        private System.Windows.Forms.TextBox textBoxLengthInput;
        private System.Windows.Forms.Label labelLength;
    }
}

