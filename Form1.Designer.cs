namespace calculator1
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
            num1 = new Button();
            button2 = new Button();
            divided = new Button();
            num3 = new Button();
            num8 = new Button();
            num9 = new Button();
            minus = new Button();
            num7 = new Button();
            dot = new Button();
            plus = new Button();
            equal = new Button();
            num0 = new Button();
            num2 = new Button();
            num6 = new Button();
            num5 = new Button();
            multiply = new Button();
            button9 = new Button();
            num4 = new Button();
            ResultTextBox = new TextBox();
            DisplayOP = new Label();
            SuspendLayout();
            // 
            // num1
            // 
            num1.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            num1.Location = new Point(12, 103);
            num1.Name = "num1";
            num1.Size = new Size(53, 54);
            num1.TabIndex = 0;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(248, 103);
            button2.Name = "button2";
            button2.Size = new Size(53, 54);
            button2.TabIndex = 1;
            button2.Text = "CE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClearButton;
            // 
            // divided
            // 
            divided.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            divided.Location = new Point(189, 103);
            divided.Name = "divided";
            divided.Size = new Size(53, 54);
            divided.TabIndex = 2;
            divided.Text = "/";
            divided.UseVisualStyleBackColor = true;
            divided.Click += Operators;
            // 
            // num3
            // 
            num3.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            num3.Location = new Point(130, 103);
            num3.Name = "num3";
            num3.Size = new Size(53, 54);
            num3.TabIndex = 3;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += button1_Click;
            // 
            // num8
            // 
            num8.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            num8.Location = new Point(71, 223);
            num8.Name = "num8";
            num8.Size = new Size(53, 54);
            num8.TabIndex = 14;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += button1_Click;
            // 
            // num9
            // 
            num9.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            num9.Location = new Point(130, 223);
            num9.Name = "num9";
            num9.Size = new Size(53, 54);
            num9.TabIndex = 13;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += button1_Click;
            // 
            // minus
            // 
            minus.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            minus.Location = new Point(189, 223);
            minus.Name = "minus";
            minus.Size = new Size(53, 54);
            minus.TabIndex = 12;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += Operators;
            // 
            // num7
            // 
            num7.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            num7.Location = new Point(12, 223);
            num7.Name = "num7";
            num7.Size = new Size(53, 54);
            num7.TabIndex = 10;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += button1_Click;
            // 
            // dot
            // 
            dot.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dot.Location = new Point(130, 283);
            dot.Name = "dot";
            dot.Size = new Size(53, 54);
            dot.TabIndex = 18;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += button1_Click;
            // 
            // plus
            // 
            plus.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            plus.Location = new Point(189, 283);
            plus.Name = "plus";
            plus.Size = new Size(53, 54);
            plus.TabIndex = 17;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += Operators;
            // 
            // equal
            // 
            equal.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            equal.Location = new Point(248, 223);
            equal.Name = "equal";
            equal.Size = new Size(53, 114);
            equal.TabIndex = 16;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += EqualButton;
            // 
            // num0
            // 
            num0.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            num0.Location = new Point(12, 283);
            num0.Name = "num0";
            num0.Size = new Size(112, 54);
            num0.TabIndex = 15;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += button1_Click;
            // 
            // num2
            // 
            num2.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            num2.Location = new Point(71, 103);
            num2.Name = "num2";
            num2.Size = new Size(53, 54);
            num2.TabIndex = 19;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += button1_Click;
            // 
            // num6
            // 
            num6.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            num6.Location = new Point(130, 163);
            num6.Name = "num6";
            num6.Size = new Size(53, 54);
            num6.TabIndex = 24;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += button1_Click;
            // 
            // num5
            // 
            num5.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            num5.Location = new Point(71, 163);
            num5.Name = "num5";
            num5.Size = new Size(53, 54);
            num5.TabIndex = 23;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += button1_Click;
            // 
            // multiply
            // 
            multiply.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            multiply.Location = new Point(189, 163);
            multiply.Name = "multiply";
            multiply.Size = new Size(53, 54);
            multiply.TabIndex = 22;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += Operators;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(248, 163);
            button9.Name = "button9";
            button9.Size = new Size(53, 54);
            button9.TabIndex = 21;
            button9.Text = "C";
            button9.UseVisualStyleBackColor = true;
            // 
            // num4
            // 
            num4.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            num4.Location = new Point(12, 163);
            num4.Name = "num4";
            num4.Size = new Size(53, 54);
            num4.TabIndex = 20;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += button1_Click;
            // 
            // ResultTextBox
            // 
            ResultTextBox.Enabled = false;
            ResultTextBox.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ResultTextBox.Location = new Point(11, 60);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(289, 29);
            ResultTextBox.TabIndex = 25;
            ResultTextBox.Text = "0";
            ResultTextBox.UseWaitCursor = true;
            // 
            // DisplayOP
            // 
            DisplayOP.AutoSize = true;
            DisplayOP.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayOP.Location = new Point(12, 18);
            DisplayOP.Name = "DisplayOP";
            DisplayOP.Size = new Size(0, 21);
            DisplayOP.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 345);
            Controls.Add(DisplayOP);
            Controls.Add(ResultTextBox);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(multiply);
            Controls.Add(button9);
            Controls.Add(num4);
            Controls.Add(num2);
            Controls.Add(dot);
            Controls.Add(plus);
            Controls.Add(equal);
            Controls.Add(num0);
            Controls.Add(num8);
            Controls.Add(num9);
            Controls.Add(minus);
            Controls.Add(num7);
            Controls.Add(num3);
            Controls.Add(divided);
            Controls.Add(button2);
            Controls.Add(num1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcultor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button num1;
        private Button button2;
        private Button divided;
        private Button num3;
        private Button num8;
        private Button num9;
        private Button minus;
        private Button num7;
        private Button dot;
        private Button plus;
        private Button equal;
        private Button num0;
        private Button num2;
        private Button num6;
        private Button num5;
        private Button multiply;
        private Button button9;
        private Button num4;
        private TextBox ResultTextBox;
        private Label DisplayOP;
    }
}
