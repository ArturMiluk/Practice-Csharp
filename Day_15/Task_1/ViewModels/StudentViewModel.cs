using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using StudentDiary.Models;
using StudentDiary.Services;

namespace StudentDiary.ViewModels
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        private readonly GradeService service = new();

        public ObservableCollection<StudentModel> Students {get; set;}
            = new ObservableCollection<StudentModel>();

        private bool isLoading;

        public bool IsLoading
        {
            get => isLoading;
            set
            {
                isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        public ICommand LoadCommand {get;}

        public StudentViewModel()
        {
            LoadCommand = new RelayCommand(async _ => await LoadStudents());
        }

        private async Task LoadStudents()
        {
            IsLoading = true;

            Students = await service.LoadStudentsAsync();

            OnPropertyChanged(nameof(Students));

            IsLoading = false;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}