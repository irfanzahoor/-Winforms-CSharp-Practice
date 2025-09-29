namespace Calculator_1
{
    partial class Calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            addbutton = new Button();
            multibutton = new Button();
            divisionbutton = new Button();
            subtractbutton = new Button();
            label5 = new Label();
            modulusButton = new Button();
            powerButton = new Button();
            sqrtButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 39);
            label1.Name = "label1";
            label1.Size = new Size(238, 31);
            label1.TabIndex = 0;
            label1.Text = "My Calculator App ";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(138, 125);
            label2.Name = "label2";
            label2.Size = new Size(171, 21);
            label2.TabIndex = 1;
            label2.Text = "Enter First Number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 218);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(138, 171);
            label4.Name = "label4";
            label4.Size = new Size(190, 21);
            label4.TabIndex = 3;
            label4.Text = "Enter Second Number :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(366, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(412, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(366, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(412, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // addbutton
            // 
            addbutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            addbutton.Location = new Point(77, 257);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(141, 32);
            addbutton.TabIndex = 6;
            addbutton.Text = "Add (+)";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // multibutton
            // 
            multibutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            multibutton.Location = new Point(590, 257);
            multibutton.Name = "multibutton";
            multibutton.Size = new Size(131, 32);
            multibutton.TabIndex = 8;
            multibutton.Text = "Multiply (×)";
            multibutton.UseVisualStyleBackColor = true;
            multibutton.Click += multibutton_Click;
            // 
            // divisionbutton
            // 
            divisionbutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            divisionbutton.Location = new Point(794, 257);
            divisionbutton.Name = "divisionbutton";
            divisionbutton.Size = new Size(114, 32);
            divisionbutton.TabIndex = 9;
            divisionbutton.Text = "Divide (÷)";
            divisionbutton.UseVisualStyleBackColor = true;
            divisionbutton.Click += divisionbutton_Click;
            // 
            // subtractbutton
            // 
            subtractbutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            subtractbutton.Location = new Point(340, 257);
            subtractbutton.Name = "subtractbutton";
            subtractbutton.Size = new Size(119, 32);
            subtractbutton.TabIndex = 10;
            subtractbutton.Text = "Subtract (−)";
            subtractbutton.UseVisualStyleBackColor = true;
            subtractbutton.Click += subtractbutton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(381, 455);
            label5.Name = "label5";
            label5.Size = new Size(74, 26);
            label5.TabIndex = 11;
            label5.Text = "label5";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // modulusButton
            // 
            modulusButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            modulusButton.Location = new Point(77, 345);
            modulusButton.Name = "modulusButton";
            modulusButton.Size = new Size(141, 32);
            modulusButton.TabIndex = 12;
            modulusButton.Text = "Modulus (%)";
            modulusButton.UseVisualStyleBackColor = true;
            modulusButton.Click += modulusButton_Click;
            // 
            // powerButton
            // 
            powerButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            powerButton.Location = new Point(340, 345);
            powerButton.Name = "powerButton";
            powerButton.Size = new Size(119, 32);
            powerButton.TabIndex = 13;
            powerButton.Text = "Power (xʸ)";
            powerButton.UseVisualStyleBackColor = true;
            powerButton.Click += powerButton_Click;
            // 
            // sqrtButton
            // 
            sqrtButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            sqrtButton.Location = new Point(590, 345);
            sqrtButton.Name = "sqrtButton";
            sqrtButton.Size = new Size(131, 32);
            sqrtButton.TabIndex = 14;
            sqrtButton.Text = "Square Root (√x)";
            sqrtButton.UseVisualStyleBackColor = true;
            sqrtButton.Click += sqrtButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(794, 345);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(114, 32);
            clearButton.TabIndex = 15;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(998, 566);
            Controls.Add(clearButton);
            Controls.Add(sqrtButton);
            Controls.Add(powerButton);
            Controls.Add(modulusButton);
            Controls.Add(label5);
            Controls.Add(subtractbutton);
            Controls.Add(divisionbutton);
            Controls.Add(multibutton);
            Controls.Add(addbutton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Calculator App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button addbutton;
        private Button multibutton;
        private Button divisionbutton;
        private Button subtractbutton;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button modulusButton;
        private Button powerButton;
        private Button sqrtButton;
        private Button clearButton;
    }
}
