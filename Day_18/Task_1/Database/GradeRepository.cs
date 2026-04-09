using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDiary.Database
{
    public class GradeRepository
    {
        private readonly AppDbContext _context;

        public GradeRepository()
        {
            _context = new AppDbContext();
        }

        public async Task<ObservableCollection<Student>> GetStudentsWithGradesAsync()
        {
            var students = await _context.Students
                .Include(s => s.Grades)
                .ToListAsync();

            return new ObservableCollection<Student>(students);
        }

        public async Task AddGradeAsync(Grade grade)
        {
            await _context.Grades.AddAsync(grade);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateGradeAsync(Grade grade)
        {
            _context.Grades.Update(grade);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGradeAsync(Grade grade)
        {
            _context.Grades.Remove(grade);
            await _context.SaveChangesAsync();
        }

        public async Task AddStudentAsync(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}