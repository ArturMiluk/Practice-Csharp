using System;

namespace StudentDiary.Database
{
    public class Grade
    {
        public int Id { get; set; }
        public string Subject { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int Value { get; set; }
        public string Comment { get; set; } = string.Empty;

        public int StudentId { get; set; }
        public virtual Student Student { get; set; } = null!;
    }
}