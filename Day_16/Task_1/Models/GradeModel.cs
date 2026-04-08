using System;

namespace StudentDiary.Models
{
    public class GradeModel
    {
        public string Subject { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int Grade { get; set; }
    }
}