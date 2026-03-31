using System;

namespace StudentDiary
{
    public class StudentRecord
    {
        public string Subject {get; set;} = string.Empty;

        public DateTime Date {get; set;}

        private int grade;

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
            }
        }
    }
}