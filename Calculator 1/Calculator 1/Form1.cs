namespace Calculator_1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out int num1, out int num2))
            {
                int sum = num1 + num2;
                ShowResult($"The sum of {num1} and {num2} is: {sum}");
            }
        }

        private void multibutton_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out int num1, out int num2))
            {
                int product = num1 * num2;
                ShowResult($"The multiplication of {num1} and {num2} is: {product}");
            }
        }

        private void divisionbutton_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out int num1, out int num2))
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero!");
                    return;
                }
                double result = (double)num1 / num2; // ✅ float division
                ShowResult($"The division of {num1} and {num2} is: {result}");
            }
        }

        private void subtractbutton_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out int num1, out int num2))
            {
                int diff = num1 - num2;
                ShowResult($"The subtraction of {num1} and {num2} is: {diff}");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // ✅ Helper methods

        private bool TryGetInputs(out int num1, out int num2)
        {
            if (!int.TryParse(textBox1.Text, out num1) || !int.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("Please enter valid numbers in both boxes.");
                num1 = num2 = 0;
                return false;
            }
            return true;
        }

        private void ShowResult(string message)
        {
            label5.Text = message;
            label5.Visible = true;
        }

        // ✅ New Features

        private void modulusButton_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out int num1, out int num2))
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Cannot take modulus with zero!");
                    return;
                }
                int result = num1 % num2;
                ShowResult($"The modulus of {num1} and {num2} is: {result}");
            }
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out int num1, out int num2))
            {
                double result = Math.Pow(num1, num2);
                ShowResult($"{num1} raised to the power {num2} is: {result}");
            }
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int num1))
            {
                MessageBox.Show("Please enter a valid number in the first box for Square Root.");
                return;
            }

            if (num1 < 0)
            {
                MessageBox.Show("Cannot take square root of a negative number!");
                return;
            }

            double result = Math.Sqrt(num1);
            ShowResult($"The square root of {num1} is: {result}");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
            label5.Visible = false;
        }
    }
}


