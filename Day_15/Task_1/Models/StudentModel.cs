using System.Collections.ObjectModel;

namespace StudentDiary.Models
{
    public class StudentModel
    {
        public string Name {get; set;} = string.Empty;

        public ObservableCollection<GradeModel> Grades {get; set;}
            = new ObservableCollection<GradeModel>();
    }
}