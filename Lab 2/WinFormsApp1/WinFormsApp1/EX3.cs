using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EX3 : Form
    {
        public EX3()
        {
            InitializeComponent();
        }

        private void readClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                using (StreamReader read = new StreamReader(ofd.FileName))
                {
                    string fileText = read.ReadToEnd();
                    fileContents.Text = fileText;
                }
            }
        }

        private void writeClick(object sender, EventArgs e)
        {
            string path = filePathInput.Text;
            if (string.IsNullOrEmpty(path) || !IsValidPath(path))
            {
                MessageBox.Show("Invalid path.");
            }
            else
            {
                writeFile(path);
            }
        }

        static bool IsValidPath(string path)
        {
            try
            {
                bool isValid = !string.IsNullOrEmpty(path) && Path.GetFullPath(path) == path;
                return isValid;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void writeFile(string filePath)
        {
            string[] lines = fileContents.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    long result = EvaluateExpression(line);
                    writer.WriteLine($"{line} = {result}");
                }
            }
            MessageBox.Show("Content has been saved to a new file.");
        }

        private long EvaluateExpression(string expression)
        {
            // Remove all spaces from the expression
            expression = expression.Replace(" ", "");

            return EvaluateExpressionHelper(expression);
        }

        private long EvaluateExpressionHelper(string expression)
        {
            // Find the innermost bracketed expression
            int startBracketIndex = expression.LastIndexOf('(');
            if (startBracketIndex != -1)
            {
                int endBracketIndex = expression.IndexOf(')', startBracketIndex);
                if (endBracketIndex == -1)
                    throw new ArgumentException("Invalid expression: Unmatched brackets");

                // Evaluate the expression inside the brackets recursively
                string subExpression = expression.Substring(startBracketIndex + 1, endBracketIndex - startBracketIndex - 1);
                long subResult = EvaluateExpressionHelper(subExpression);

                // Replace the bracketed expression with its result
                expression = expression.Substring(0, startBracketIndex) + subResult + expression.Substring(endBracketIndex + 1);
                return EvaluateExpressionHelper(expression); // Recur to handle nested brackets
            }
            else
            {
                // If no brackets found, evaluate the entire expression without recursion
                string[] tokens = expression.Split(new char[] { '+', '-', '*', '/' });

                long total = 0;
                char currentOperator = '+';

                foreach (string token in tokens)
                {
                    if (IsOperator(token[0])) // Check if the first character of the token is an operator
                    {
                        currentOperator = token[0];
                    }
                    else
                    {
                        long nextNumber;
                        if (!long.TryParse(token, out nextNumber))
                            throw new FormatException("Invalid number format");

                        switch (currentOperator)
                        {
                            case '+':
                                total += nextNumber;
                                break;
                            case '-':
                                total -= nextNumber;
                                break;
                            case '*':
                                total *= nextNumber;
                                break;
                            case '/':
                                if (nextNumber == 0)
                                    throw new DivideByZeroException("Division by zero.");
                                total /= nextNumber;
                                break;
                            default:
                                throw new ArgumentException("Invalid operator");
                        }
                    }
                }

                return total;
            }
        }

        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }
    }
}
