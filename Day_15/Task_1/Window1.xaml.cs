using System.Windows;
using StudentDiary.ViewModels;

namespace StudentDiary
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DataContext = new StudentViewModel();
        }
    }
}