using System.Collections.ObjectModel;
using System.Threading.Tasks;
using StudentDiary.Models;

namespace StudentDiary.Services
{
    public class GradeService
    {
        public async Task<ObservableCollection<StudentModel>> LoadStudentsAsync()
        {
            await Task.Delay(2000);

            return new ObservableCollection<StudentModel>
            {
                new StudentModel
                {
                    Name = "Милюк Артур",
                    Grades = new ObservableCollection<GradeModel>
                    {
                        new GradeModel { Subject = "КПиЯП", Grade = 4, Date = System.DateTime.Today },
                        new GradeModel { Subject = "ТПО", Grade = 5, Date = System.DateTime.Today }
                    }
                },
            };
        }
    }
}