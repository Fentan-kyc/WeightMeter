namespace WeightMeter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resultButton = new Button();
            grammsTextBox = new TextBox();
            callTextBox = new TextBox();
            resultTextBox = new TextBox();
            grammsLabel = new Label();
            callLabel = new Label();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // resultButton
            // 
            resultButton.Location = new Point(297, 165);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(75, 23);
            resultButton.TabIndex = 0;
            resultButton.Text = "Result";
            resultButton.UseVisualStyleBackColor = true;
            resultButton.Click += resultButton_Click;
            // 
            // grammsTextBox
            // 
            grammsTextBox.Location = new Point(248, 119);
            grammsTextBox.Name = "grammsTextBox";
            grammsTextBox.Size = new Size(52, 23);
            grammsTextBox.TabIndex = 1;
            // 
            // callTextBox
            // 
            callTextBox.Location = new Point(380, 119);
            callTextBox.Name = "callTextBox";
            callTextBox.Size = new Size(51, 23);
            callTextBox.TabIndex = 2;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(501, 119);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(38, 23);
            resultTextBox.TabIndex = 3;
            // 
            // grammsLabel
            // 
            grammsLabel.AutoSize = true;
            grammsLabel.Location = new Point(248, 90);
            grammsLabel.Name = "grammsLabel";
            grammsLabel.Size = new Size(52, 15);
            grammsLabel.TabIndex = 4;
            grammsLabel.Text = "Gramms";
            // 
            // callLabel
            // 
            callLabel.AutoSize = true;
            callLabel.Location = new Point(393, 90);
            callLabel.Name = "callLabel";
            callLabel.Size = new Size(27, 15);
            callLabel.TabIndex = 5;
            callLabel.Text = "Call";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(501, 90);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(39, 15);
            resultLabel.TabIndex = 6;
            resultLabel.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(callLabel);
            Controls.Add(grammsLabel);
            Controls.Add(resultTextBox);
            Controls.Add(callTextBox);
            Controls.Add(grammsTextBox);
            Controls.Add(resultButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resultButton;
        private TextBox grammsTextBox;
        private TextBox callTextBox;
        private TextBox resultTextBox;
        private Label grammsLabel;
        private Label callLabel;
        private Label resultLabel;
    }
}