using System.Collections.ObjectModel;

namespace StudentDiary.Database
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public virtual ObservableCollection<Grade> Grades { get; set; } = new();
    }
}