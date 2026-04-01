using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace StudentDiary
{
    public partial class Window1 : Window, INotifyPropertyChanged
    {
        public ObservableCollection<StudentRecord> Records {get;}

        public ICommand AddGradeCommand {get;}
        public ICommand EditGradeCommand {get;}
        public ICommand DeleteGradeCommand {get;}

        public ICommand RefreshCommand {get;}

        public double AverageGrade =>
            Records.Count == 0 ? 0 : Records.Average(r => r.Grade);

        public Window1()
        {
            InitializeComponent();

            Records = new ObservableCollection<StudentRecord>
            {
                new StudentRecord
                {
                    Subject = "КПиЯП",
                    Date = DateTime.Today,
                    Grade = 5
                },
                new StudentRecord
                {
                    Subject = "ТПО",
                    Date = DateTime.Today.AddDays(1),
                    Grade = 4
                }
            };

            Records.CollectionChanged += (s, e) =>
            {
                OnPropertyChanged(nameof(AverageGrade));
            };

            AddGradeCommand = new RelayCommand(_ => AddGrade());
            EditGradeCommand = new RelayCommand(_ => EditGrade());
            DeleteGradeCommand = new RelayCommand(_ => DeleteGrade());
            RefreshCommand = new RelayCommand(_ => RefreshGrades());

            DataContext = this;
        }

        private void AddGrade()
        {
            var newRecord = new StudentRecord
            {
                Subject = "Новый предмет",
                Date = DateTime.Today,
                Grade = 5
            };

            Records.Add(newRecord);
            OnPropertyChanged(nameof(AverageGrade));
        }

        private void EditGrade()
        {
            if (scheduleGrid.SelectedItem is not StudentRecord selectedRecord)
            {
                MessageBox.Show("Выберите запись",
                    "Ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }

            selectedRecord.Grade = 5;
            OnPropertyChanged(nameof(AverageGrade));
        }

        private void DeleteGrade()
        {
            if (scheduleGrid.SelectedItem is not StudentRecord selectedRecord)
            {
                MessageBox.Show("Выберите запись",
                    "Ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }

            var result = MessageBox.Show(
                "Удалить запись?",
                "Подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Records.Remove(selectedRecord);
                OnPropertyChanged(nameof(AverageGrade));
            }
        }

        private void RefreshGrades()
        {
            OnPropertyChanged(nameof(AverageGrade));

            MessageBox.Show("Оценки обновлены",
                "Информация",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void OnFilterClick(object sender, RoutedEventArgs e){}

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}