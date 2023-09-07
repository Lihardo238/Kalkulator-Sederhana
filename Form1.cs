using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private string currentInput = "";  // Store the current user input
        private double result = 0;        // Store the result of calculations
        private char currentOperator = ' '; // Store the current operator

        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for numeric buttons (0-9)
        private void NumberButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedbutton = (System.Windows.Forms.Button)sender;
            currentInput += clickedbutton.Text;
            UpdateDisplay();
        }

        // Event handler for Clear (C) button
        private void button17_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            currentOperator = ' ';
            UpdateDisplay();
        }

        // Event handler for Backspace (<--)
        private void Button21_Click(object sender, EventArgs e)
        {
            if (currentInput.Length > 0)
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                UpdateDisplay();
            }
        }

        // Event handler for operator buttons (+, -, X, /)
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            // Check if currentInput is a valid number before proceeding
            if (double.TryParse(currentInput, out double numericValue))
            {
                currentOperator = button.Text[0];
                result = numericValue; // Store the current numeric value in result
                currentInput = "";
                UpdateDisplay();
            }
            else
            {
                // Handle the case where currentInput is not a valid number (e.g., display an error message)
                MessageBox.Show("Invalid input. Please enter a valid number before using an operator.");
            }
        }

        // Event handler for Equals (=) button
        private void Button36_Click(object sender, EventArgs e)
        {
            if (currentOperator != ' ' && currentInput != "")
            {
                double operand2 = double.Parse(currentInput);

                switch (currentOperator)
                {
                    case '+':
                        result += operand2;
                        break;
                    case '-':
                        result -= operand2;
                        break;
                    case 'X':
                        result *= operand2;
                        break;
                    case ':':
                        if (operand2 != 0) // Check for division by zero
                            result /= operand2;
                        else
                            MessageBox.Show("Cannot divide by zero.");
                        break;
                }

                currentInput = result.ToString();
                currentOperator = ' ';
                UpdateDisplay();
            }
        }

        // Event handler for the decimal point (.)
        private void Button35_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                currentInput += ".";
                UpdateDisplay();
            }
        }

        // Update the display TextBox with the current input
        private void UpdateDisplay()
        {
            textBox2.Text = currentInput;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }
    }
}
