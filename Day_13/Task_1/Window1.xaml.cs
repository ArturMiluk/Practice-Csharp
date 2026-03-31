using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace StudentDiary
{
    public partial class Window1 : Window
    {
        private ObservableCollection<StudentRecord> records;

        public ICommand AddGradeCommand {get;}
        public ICommand EditGradeCommand {get;}
        public ICommand DeleteGradeCommand {get;}

        public Window1()
        {
            InitializeComponent();

            records = new ObservableCollection<StudentRecord>
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

            scheduleGrid.ItemsSource = records;

            AddGradeCommand = new RelayCommand(_ => AddGrade());
            EditGradeCommand = new RelayCommand(_ => EditGrade());
            DeleteGradeCommand = new RelayCommand(_ => DeleteGrade());

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

            records.Add(newRecord);
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
            scheduleGrid.Items.Refresh();
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
                records.Remove(selectedRecord);
            }
        }

        private void OnFilterClick(object sender, RoutedEventArgs e)
        {
            if (dateFilterPicker.SelectedDate == null)
            {
                scheduleGrid.ItemsSource = records;
                return;
            }

            DateTime selectedDate = dateFilterPicker.SelectedDate.Value;

            var filtered = records
                .Where(r => r.Date.Date == selectedDate.Date)
                .ToList();

            scheduleGrid.ItemsSource = filtered;
        }
    }
}