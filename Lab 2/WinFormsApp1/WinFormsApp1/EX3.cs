using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                MessageBox.Show("Đường dẫn không phù hợp");
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
            MessageBox.Show("Kết quả đã được lưu vào tập tin mới");
        }

        private long EvaluateExpression(string expression)
        {
            expression = expression.Replace(" ", "");
            return EvaluateExpressionHelper(expression);
        }

        private long EvaluateExpressionHelper(string expression)
        {
            Stack<int> stack = new Stack<int>();
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(i);
                }
                else if (expression[i] == ')')
                {
                    if (stack.Count == 0)
                    {
                        MessageBox.Show("Input format không hợp lệ");
                        return 0;
                    }

                    pairs.Add(stack.Pop(), i);
                }
            }

            if (stack.Count != 0)
            {
                MessageBox.Show("Input format không hợp lệ");
                return 0;
            }

            return Evaluate(expression, 0, expression.Length - 1, pairs);
        }

        private long Evaluate(string expression, int start, int end, Dictionary<int, int> pairs)
        {
            if (start > end)
                return 0;

            if (expression[start] == '(' && pairs.ContainsKey(start) && pairs[start] == end)
                return Evaluate(expression, start + 1, end - 1, pairs);

            var operators = new char[] { '+', '-', '*', '/' };
            var tokens = SplitExpression(expression.Substring(start, end - start + 1), operators);

            var values = new List<long>();
            var ops = new List<char>();

            foreach (var token in tokens)
            {
                if (token == "+" || token == "-" || token == "*" || token == "/")
                {
                    ops.Add(token[0]);
                }
                else
                {
                    values.Add(long.Parse(token));
                }
            }

            for (int i = 0; i < ops.Count; i++)
            {
                if (ops[i] == '*' || ops[i] == '/')
                {
                    long temp = ops[i] == '*' ? values[i] * values[i + 1] : values[i] / values[i + 1];
                    values[i] = temp;
                    values.RemoveAt(i + 1);
                    ops.RemoveAt(i);
                    i--;
                }
            }

            long result = values[0];
            for (int i = 0; i < ops.Count; i++)
            {
                if (ops[i] == '+')
                {
                    result += values[i + 1];
                }
                else if (ops[i] == '-')
                {
                    result -= values[i + 1];
                }
            }

            return result;
        }

        private List<string> SplitExpression(string expression, char[] operators)
        {
            var result = new List<string>();
            int startIndex = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (operators.Contains(expression[i]))
                {
                    result.Add(expression.Substring(startIndex, i - startIndex));
                    result.Add(expression[i].ToString());
                    startIndex = i + 1;
                }
            }
            result.Add(expression.Substring(startIndex));
            return result;
        }
    }
}
