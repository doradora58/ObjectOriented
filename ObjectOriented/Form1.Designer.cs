﻿namespace ObjectOriented
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
            button2 = new Button();
            ResultLabel = new Label();
            InputTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(117, 39);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(13, 74);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(38, 15);
            ResultLabel.TabIndex = 11;
            ResultLabel.Text = "label1";
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(11, 39);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(100, 23);
            InputTextBox.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(197, 211);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Form2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(ResultLabel);
            Controls.Add(InputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label ResultLabel;
        private TextBox InputTextBox;
        private Button button1;
    }
}