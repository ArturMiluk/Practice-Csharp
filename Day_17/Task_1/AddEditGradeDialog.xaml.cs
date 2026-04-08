using System;
using System.Windows;

namespace StudentDiary.Views
{
    public partial class AddEditGradeDialog : Window
    {
        private readonly Action<string, int, DateTime> _callback;

        public AddEditGradeDialog(string studentName, string currentSubject, int currentGrade, DateTime currentDate, Action<string, int, DateTime> callback)
        {
            InitializeComponent();

            StudentNameTextBlock.Text = studentName;
            SubjectTextBox.Text = currentSubject;
            GradeTextBox.Text = currentGrade.ToString();
            DatePickerControl.SelectedDate = currentDate;

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

            _callback(subject, grade, selectedDate);

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