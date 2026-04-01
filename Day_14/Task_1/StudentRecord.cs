using System;
using System.ComponentModel;

namespace StudentDiary
{
    public class StudentRecord : INotifyPropertyChanged
    {
        private string subject = string.Empty;
        private DateTime date;
        private int grade;

        public string Subject
        {
            get => subject;
            set
            {
                subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }

        public DateTime Date
        {
            get => date;
            set
            {
                date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        public int Grade
        {
            get => grade;
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        "Оценка должна быть от 1 до 10");
                }

                grade = value;
                OnPropertyChanged(nameof(Grade));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}