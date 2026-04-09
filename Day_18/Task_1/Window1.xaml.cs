using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using StudentDiary.Models;
using StudentDiary.Services;
using StudentDiary.ViewModels;
using StudentDiary.Views;

namespace StudentDiary
{
    public partial class Window1 : Window
    {
        private StudentViewModel? _vm;
        private ChatService? _chatService;
        private NotificationService? _notificationService;

        public Window1()
        {
            InitializeComponent();
            Loaded += Window1_Loaded;
            Closed += Window1_Closed;
        }

        private async void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            _vm = DataContext as StudentViewModel;
            if (_vm != null)
            {
                _vm.ShowNotification += OnShowNotification;
                _vm.ShowGradeDialog += OnShowGradeDialog;
                _vm.PropertyChanged += OnViewModelPropertyChanged;

                _chatService = new ChatService();
                _ = Task.Run(() => _chatService.StartServer(msg =>
                    Dispatcher.Invoke(() => ChatListBox.Items.Add(msg))));

                _notificationService = new NotificationService();
                _ = Task.Run(() => _notificationService.StartListening(msg =>
                    Dispatcher.Invoke(() =>
                        MessageBox.Show(msg, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information))));
            }
        }

        private async void AnimateSubjectChange()
        {
            if (GradesListBox == null) return;

            var fadeOut = (Storyboard)FindResource("FadeOutAnimation");
            Storyboard.SetTarget(fadeOut, GradesListBox);
            fadeOut.Begin();

            await Task.Delay(300);

            var fadeIn = (Storyboard)FindResource("FadeInAnimation");
            Storyboard.SetTarget(fadeIn, GradesListBox);
            fadeIn.Begin();
        }

        private void OnViewModelPropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(StudentViewModel.SelectedStudent))
            {
                AnimateSubjectChange();
            }
        }

        private void OnShowNotification(object? sender, string message)
        {
            Dispatcher.Invoke(() => MessageBox.Show(message, "Информация", MessageBoxButton.OK, MessageBoxImage.Information));
        }

        private void OnShowGradeDialog(object? sender, (string studentName, Action<string, int, DateTime, string> callback) data)
        {
            Dispatcher.Invoke(() =>
            {
                var dialog = new AddEditGradeDialog(data.studentName, "", 5, DateTime.Today, "", data.callback);
                dialog.Owner = this;
                dialog.ShowDialog();
            });
        }

        private async void SendChatMessage_Click(object sender, RoutedEventArgs e)
        {
            if (_chatService != null && !string.IsNullOrWhiteSpace(ChatInputTextBox.Text))
            {
                await _chatService.SendMessage($"{_vm?.Role}: {ChatInputTextBox.Text}");
                ChatInputTextBox.Clear();
            }
        }

        private void ShowGradeDetails_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var grade = button?.Tag as GradeModel;

            if (grade == null) return;

            DetailSubject.Text = grade.Subject;
            DetailGrade.Text = grade.Grade.ToString();
            DetailDate.Text = grade.Date.ToString("dd.MM.yyyy");
            DetailComment.Text = grade.Comment ?? "";

            GradeDetailsPopup.IsOpen = true;
            var showAnim = (Storyboard)PopupBorder.FindResource("ShowPopupAnim");
            showAnim.Begin(PopupBorder);
        }

        private void ShowPopupAnim_Completed(object sender, EventArgs e)
        {
        }

        private void ClosePopup_Click(object sender, RoutedEventArgs e)
        {
            var hideAnim = (Storyboard)PopupBorder.FindResource("HidePopupAnim");
            hideAnim.Completed += (s, _) => GradeDetailsPopup.IsOpen = false;
            hideAnim.Begin(PopupBorder);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window1_Closed(object? sender, EventArgs e)
        {
        }
    }
}