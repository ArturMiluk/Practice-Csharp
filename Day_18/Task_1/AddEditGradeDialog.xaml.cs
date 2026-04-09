using System;
using System.Windows;

namespace StudentDiary.Views
{
    public partial class AddEditGradeDialog : Window
    {
        private readonly Action<string, int, DateTime, string> _callback;

        public AddEditGradeDialog(string studentName, string currentSubject, int currentGrade, DateTime currentDate, string currentComment, Action<string, int, DateTime, string> callback)
        {
            InitializeComponent();

            StudentNameTextBlock.Text = studentName;
            SubjectTextBox.Text = currentSubject;
            GradeTextBox.Text = currentGrade.ToString();
            DatePickerControl.SelectedDate = currentDate;
            CommentTextBox.Text = currentComment;

            _callback = callback;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SubjectTextBox.Text))
            {
                MessageBox.Show("Введите предмет");
                return;
            }

            if (!int.TryParse(GradeTextBox.Text, out int grade) || grade < 1 || grade > 10)
            {
                MessageBox.Show("Оценка должна быть от 1 до 10");
                return;
            }

            var subject = SubjectTextBox.Text;
            var selectedDate = DatePickerControl.SelectedDate ?? DateTime.Today;
            var comment = CommentTextBox.Text;

            _callback(subject, grade, selectedDate, comment);

            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}