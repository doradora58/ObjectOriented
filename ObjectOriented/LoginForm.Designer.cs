namespace ObjectOriented
{
    partial class LoginForm
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
            ShowLabel = new Label();
            ShowButton = new Button();
            button1 = new Button();
            SilverRadioButton = new RadioButton();
            GoldRadioButton = new RadioButton();
            PlatinumRadioButton = new RadioButton();
            ExecutionButton = new Button();
            SuspendLayout();
            // 
            // ShowLabel
            // 
            ShowLabel.AutoSize = true;
            ShowLabel.Location = new Point(12, 18);
            ShowLabel.Name = "ShowLabel";
            ShowLabel.Size = new Size(38, 15);
            ShowLabel.TabIndex = 0;
            ShowLabel.Text = "label1";
            // 
            // ShowButton
            // 
            ShowButton.Location = new Point(71, 14);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(75, 23);
            ShowButton.TabIndex = 1;
            ShowButton.Text = "Show";
            ShowButton.UseVisualStyleBackColor = true;
            ShowButton.Click += ShowButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(71, 52);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SilverRadioButton
            // 
            SilverRadioButton.AutoSize = true;
            SilverRadioButton.Checked = true;
            SilverRadioButton.Location = new Point(27, 93);
            SilverRadioButton.Name = "SilverRadioButton";
            SilverRadioButton.Size = new Size(53, 19);
            SilverRadioButton.TabIndex = 3;
            SilverRadioButton.TabStop = true;
            SilverRadioButton.Text = "Silver";
            SilverRadioButton.UseVisualStyleBackColor = true;
            // 
            // GoldRadioButton
            // 
            GoldRadioButton.AutoSize = true;
            GoldRadioButton.Location = new Point(27, 127);
            GoldRadioButton.Name = "GoldRadioButton";
            GoldRadioButton.Size = new Size(50, 19);
            GoldRadioButton.TabIndex = 4;
            GoldRadioButton.TabStop = true;
            GoldRadioButton.Text = "Gold";
            GoldRadioButton.UseVisualStyleBackColor = true;
            // 
            // PlatinumRadioButton
            // 
            PlatinumRadioButton.AutoSize = true;
            PlatinumRadioButton.Location = new Point(27, 164);
            PlatinumRadioButton.Name = "PlatinumRadioButton";
            PlatinumRadioButton.Size = new Size(61, 19);
            PlatinumRadioButton.TabIndex = 5;
            PlatinumRadioButton.TabStop = true;
            PlatinumRadioButton.Text = "Platina";
            PlatinumRadioButton.UseVisualStyleBackColor = true;
            // 
            // ExecutionButton
            // 
            ExecutionButton.Location = new Point(128, 162);
            ExecutionButton.Name = "ExecutionButton";
            ExecutionButton.Size = new Size(75, 23);
            ExecutionButton.TabIndex = 7;
            ExecutionButton.Text = "Login";
            ExecutionButton.UseVisualStyleBackColor = true;
            ExecutionButton.Click += ExecutionButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(ExecutionButton);
            Controls.Add(PlatinumRadioButton);
            Controls.Add(GoldRadioButton);
            Controls.Add(SilverRadioButton);
            Controls.Add(button1);
            Controls.Add(ShowButton);
            Controls.Add(ShowLabel);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ShowLabel;
        private Button ShowButton;
        private Button button1;
        private RadioButton SilverRadioButton;
        private RadioButton GoldRadioButton;
        private RadioButton PlatinumRadioButton;
        private Button ExecutionButton;
    }
}
