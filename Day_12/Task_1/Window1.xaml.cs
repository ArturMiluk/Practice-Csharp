using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Task_1;

namespace StudentDiary
{
    public partial class Window1 : Window
    {
        private ObservableCollection<StudentRecord> records;

        public Window1()
        {
            InitializeComponent();

            records = new ObservableCollection<StudentRecord>
            {
                new StudentRecord
                {
                    Subject = "КПиЯП",
                    Date = DateTime.Today,
                    Grade = 7
                },
                new StudentRecord
                {
                    Subject = "ТПО",
                    Date = DateTime.Today.AddDays(+1),
                    Grade = 6
                }
            };

            scheduleGrid.ItemsSource = records;
        }

        private void OnAddGradeClick(object sender, RoutedEventArgs e)
        {
            var newRecord = new StudentRecord
            {
                Subject = "Новый предмет",
                Date = DateTime.Today,
                Grade = 5
            };

            records.Add(newRecord);
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