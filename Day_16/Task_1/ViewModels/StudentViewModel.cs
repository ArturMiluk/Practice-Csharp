using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using StudentDiary.Models;
using StudentDiary.Services;

namespace StudentDiary.ViewModels
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        private readonly GradeService _gradeService = new();
        private readonly JsonService _jsonService = new();

        private ObservableCollection<StudentModel> _students = new();
        public ObservableCollection<StudentModel> Students
        {
            get => _students;
            set
            {
                _students = value;
                OnPropertyChanged(nameof(Students));
            }
        }

        private StudentModel? _selectedStudent;
        public StudentModel? SelectedStudent
        {
            get => _selectedStudent;
            set
            {
                _selectedStudent = value;
                OnPropertyChanged(nameof(SelectedStudent));
                OnPropertyChanged(nameof(SelectedGrade));
                (AddGradeCommand as RelayCommand)?.RaiseCanExecuteChanged();
                (EditGradeCommand as RelayCommand)?.RaiseCanExecuteChanged();
                (DeleteGradeCommand as RelayCommand)?.RaiseCanExecuteChanged();
            }
        }

        private GradeModel? _selectedGrade;
        public GradeModel? SelectedGrade
        {
            get => _selectedGrade;
            set
            {
                _selectedGrade = value;
                OnPropertyChanged(nameof(SelectedGrade));
                (EditGradeCommand as RelayCommand)?.RaiseCanExecuteChanged();
                (DeleteGradeCommand as RelayCommand)?.RaiseCanExecuteChanged();
            }
        }

        public string Role { get; }
        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        public ICommand LoadCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand LoadDiaryCommand { get; }
        public ICommand AddGradeCommand { get; }
        public ICommand EditGradeCommand { get; }
        public ICommand DeleteGradeCommand { get; }

        public event EventHandler<string>? ShowNotification;
        public event EventHandler<(string, Action<string, int, DateTime>)>? ShowGradeDialog;

        public StudentViewModel(UserModel user)
        {
            Role = user.Role;

            LoadCommand = new RelayCommand(async _ => await LoadStudents());
            SaveCommand = new RelayCommand(_ => SaveDiary(), _ => Role == "Teacher");
            LoadDiaryCommand = new RelayCommand(async _ => await LoadDiary());
            AddGradeCommand = new RelayCommand(_ => AddGrade(), _ => Role == "Teacher" && SelectedStudent != null);
            EditGradeCommand = new RelayCommand(_ => EditGrade(), _ => Role == "Teacher" && SelectedStudent != null && SelectedGrade != null);
            DeleteGradeCommand = new RelayCommand(_ => DeleteGrade(), _ => Role == "Teacher" && SelectedStudent != null && SelectedGrade != null);
        }

        private async Task LoadStudents()
        {
            IsLoading = true;
            Students = await _gradeService.LoadStudentsAsync();
            IsLoading = false;
        }

        private async void SaveDiary()
        {
            await _jsonService.SaveAsync("diary.json", Students);
            ShowNotification?.Invoke(this, "Данные сохранены!");
        }

        private async Task LoadDiary()
        {
            IsLoading = true;
            var data = await _jsonService.LoadAsync<ObservableCollection<StudentModel>>("diary.json");
            if (data != null)
            {
                Students = data;
            }
            IsLoading = false;
        }

        private void AddGrade()
        {
            if (SelectedStudent == null) return;

            ShowGradeDialog?.Invoke(this, (SelectedStudent.Name, (subject, grade, date) =>
            {
                SelectedStudent.Grades.Add(new GradeModel
                {
                    Subject = subject,
                    Grade = grade,
                    Date = date
                });
                ShowNotification?.Invoke(this, $"Добавлена оценка {grade} по предмету {subject}");
            }
            ));
        }

        private void EditGrade()
        {
            if (SelectedStudent == null || SelectedGrade == null) return;

            var oldSubject = SelectedGrade.Subject;
            var oldGrade = SelectedGrade.Grade;
            var oldDate = SelectedGrade.Date;

            ShowGradeDialog?.Invoke(this, (SelectedStudent.Name, (subject, grade, date) =>
            {
                SelectedGrade.Subject = subject;
                SelectedGrade.Grade = grade;
                SelectedGrade.Date = date;
                ShowNotification?.Invoke(this, $"Оценка изменена: {oldSubject} {oldGrade} → {subject} {grade}");
            }
            ));
        }

        private async void DeleteGrade()
        {
            if (SelectedStudent == null || SelectedGrade == null) return;

            var result = MessageBox.Show(
                $"Удалить оценку {SelectedGrade.Grade} по предмету {SelectedGrade.Subject}?",
                "Подтверждение удаления",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                SelectedStudent.Grades.Remove(SelectedGrade);
                ShowNotification?.Invoke(this, "Оценка удалена");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}