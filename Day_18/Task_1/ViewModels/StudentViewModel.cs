using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using StudentDiary.Database;

namespace StudentDiary.ViewModels
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        private readonly GradeRepository _repository;
        private ObservableCollection<Student> _students = new();
        private Student? _selectedStudent;
        private Grade? _selectedGrade;
        private bool _isLoading;

        public ObservableCollection<Student> Students
        {
            get => _students;
            set
            {
                _students = value;
                OnPropertyChanged(nameof(Students));
            }
        }

        public Student? SelectedStudent
        {
            get => _selectedStudent;
            set
            {
                _selectedStudent = value;
                OnPropertyChanged(nameof(SelectedStudent));
                OnPropertyChanged(nameof(SelectedGrade));
            }
        }

        public Grade? SelectedGrade
        {
            get => _selectedGrade;
            set
            {
                _selectedGrade = value;
                OnPropertyChanged(nameof(SelectedGrade));
            }
        }

        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        public string Role { get; }

        public ICommand LoadCommand { get; }
        public ICommand AddGradeCommand { get; }
        public ICommand EditGradeCommand { get; }
        public ICommand DeleteGradeCommand { get; }

        public event EventHandler<string>? ShowNotification;
        public event EventHandler<(string studentName, Action<string, int, DateTime, string> callback)>? ShowGradeDialog;

        public StudentViewModel(string role)
        {
            Role = role;
            _repository = new GradeRepository();

            LoadCommand = new RelayCommand(async _ => await LoadDataAsync());
            AddGradeCommand = new RelayCommand(_ => AddGrade(), _ => Role == "Teacher" && SelectedStudent != null);
            EditGradeCommand = new RelayCommand(_ => EditGrade(), _ => Role == "Teacher" && SelectedStudent != null && SelectedGrade != null);
            DeleteGradeCommand = new RelayCommand(async _ => await DeleteGrade(), _ => Role == "Teacher" && SelectedStudent != null && SelectedGrade != null);
        }

        private async Task LoadDataAsync()
        {
            IsLoading = true;
            Students = await _repository.GetStudentsWithGradesAsync();
            IsLoading = false;
        }

        private void AddGrade()
        {
            if (SelectedStudent == null) return;

            ShowGradeDialog?.Invoke(this, (SelectedStudent.Name, async (subject, grade, date, comment) =>
            {
                var newGrade = new Grade
                {
                    Subject = subject,
                    Value = grade,
                    Date = date,
                    Comment = comment,
                    StudentId = SelectedStudent.Id
                };

                await _repository.AddGradeAsync(newGrade);
                await LoadDataAsync();
                ShowNotification?.Invoke(this, $"Добавлена оценка {grade} по предмету {subject}");
            }
            ));
        }

        private void EditGrade()
        {
            if (SelectedStudent == null || SelectedGrade == null) return;

            var oldSubject = SelectedGrade.Subject;
            var oldValue = SelectedGrade.Value;

            ShowGradeDialog?.Invoke(this, (SelectedStudent.Name, async (subject, grade, date, comment) =>
            {
                SelectedGrade.Subject = subject;
                SelectedGrade.Value = grade;
                SelectedGrade.Date = date;
                SelectedGrade.Comment = comment;

                await _repository.UpdateGradeAsync(SelectedGrade);
                await LoadDataAsync();
                ShowNotification?.Invoke(this, $"Оценка изменена: {oldSubject} {oldValue} → {subject} {grade}");
            }
            ));
        }

        private async Task DeleteGrade()
        {
            if (SelectedStudent == null || SelectedGrade == null) return;

            var result = MessageBox.Show(
                $"Удалить оценку {SelectedGrade.Value} по предмету {SelectedGrade.Subject}?",
                "Подтверждение удаления",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                await _repository.DeleteGradeAsync(SelectedGrade);
                await LoadDataAsync();
                ShowNotification?.Invoke(this, "Оценка удалена");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}