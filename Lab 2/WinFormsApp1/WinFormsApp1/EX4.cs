using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace WinFormsApp1
{
    public partial class EX4 : Form
    {
        List<student> students;
        BinaryFormatter formatter;
        static int order;
        public EX4()
        {
            students = new List<student>();
            InitializeComponent();
            formatter = new BinaryFormatter();
            order = 0;
        }

        public void addStudent(object sender, EventArgs e)
        {
            double checkScore1 = Convert.ToDouble(writeScore1Input.Text.ToString());
            double checkScore2 = Convert.ToDouble(writeScore2Input.Text.ToString());
            double checkScore3 = Convert.ToDouble(writeScore3Input.Text.ToString());
            double maxScore = 10.0;
            double minScore = 1.0;
            bool validInput = false;
            if (writePhoneInput.Text.Length < 10
                || writePhoneInput.Text.ToString()[0] != '0'
                || writeIDInput.Text.Length != 8
                || checkScore1 < minScore
                || checkScore1 > maxScore
                || checkScore2 < minScore
                || checkScore2 > maxScore
                || checkScore3 < minScore
                || checkScore3 > maxScore)
            {
                MessageBox.Show("Input Format chưa đúng");

            }
            else
            {
                validInput = true;
            }
            if (validInput)
            {
                student newStudent = new student();
                newStudent.name = writeNameInput.Text.ToString();
                newStudent.id = writeIDInput.Text.ToString();
                newStudent.phone = writePhoneInput.Text.ToString();
                newStudent.score1 = checkScore1;
                newStudent.score2 = checkScore2;
                newStudent.score3 = checkScore3;
                if (writeAverageInput.Text.ToString().Equals(""))
                    writeAverageInput.Text = "0";
                newStudent.average = Convert.ToDouble(writeAverageInput.Text.ToString());
                students.Add(newStudent);
                view.Text += $"{newStudent.name}, {newStudent.id}, {newStudent.phone}, {newStudent.score1}, {newStudent.score2}, {newStudent.score3}, {newStudent.average}\n";
            }
        }

        public void writeStudentFile(object sender, EventArgs e)
        {
            string filePath = filePathInput.Text.ToString();

            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {

                        formatter.Serialize(fileStream, students);
                    }

                    MessageBox.Show("Danh sách sinh viên đã được lưu vào tệp tin mới.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi ghi tệp tin: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đường dẫn đến tệp tin.");
            }
        }

        private void viewStudentInfo(student student)
        {
            nameResult.Text = student.name;
            idResult.Text = student.id;
            phoneResult.Text = student.phone;
            score1Result.Text = student.score1.ToString();
            score2Result.Text = student.score2.ToString();
            score3Result.Text = student.score3.ToString();
            double avg = (student.score1 + student.score2 + student.score3) / 3;
            averageResult.Text = avg.ToString();
        }

        private void readClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                using (FileStream fileStream = new FileStream(ofd.FileName, FileMode.Open))
                {
                    List<student> temp = new List<student>();
                    temp = (List<student>)formatter.Deserialize(fileStream);
                    students = temp;
                }
            }
            else
            {
                MessageBox.Show("File không hợp lệ");
            }
            if (students.Count > 0)
            {
                viewStudentInfo(students[0]);
                studentOrder.Text = (order + 1).ToString();
            }
            string filePath = filePathInput.Text.ToString();
            if (string.IsNullOrEmpty(filePath) || !IsValidPath(filePath))
            {
                MessageBox.Show("Đường dẫn không phù hợp");
            }
            else
            {
                writeFile(filePath);
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
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var student in students)
                    {
                        writer.WriteLine($"Name: {student.name}");
                        writer.WriteLine($"ID: {student.id}");
                        writer.WriteLine($"Phone: {student.phone}");
                        writer.WriteLine($"Score 1: {student.score1}");
                        writer.WriteLine($"Score 2: {student.score2}");
                        writer.WriteLine($"Score 3: {student.score3}");
                        writer.WriteLine($"Average: {student.average}");
                        writer.WriteLine();
                    }
                }
                MessageBox.Show("Kết quả đã được lưu vào tập tin mới");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi ghi tập tin: {ex.Message}");
            }
        }



        private void nextClick(object sender, EventArgs e)
        {
            if (order < students.Count)
            {
                ++order;
                if (order <= students.Count)
                {
                    viewStudentInfo(students[order - 1]);
                    studentOrder.Text = order.ToString();
                }
            }
        }

        private void backClick(object sender, EventArgs e)
        {
            if (order > 1)
            {
                --order;
                viewStudentInfo(students[order - 1]);
                studentOrder.Text = order.ToString();
            }
        }

    }

    [Serializable()]
    public class student
    {
        public string name { get; set; }
        public string id { get; set; }
        public string phone { get; set; }
        public double score1 { get; set; }
        public double score2 { get; set; }
        public double score3 { get; set; }
        public double average { get; set; }

        public student() { }
        public student(string name, string id, string phone, double score1, double score2, double score3, double average)
        {
            this.name = name;
            this.id = id;
            this.phone = phone;
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
            this.average = average;
        }

    }
}
