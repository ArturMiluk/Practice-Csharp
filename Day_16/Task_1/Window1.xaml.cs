using System;
using System.Threading.Tasks;
using System.Windows;
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

                _chatService = new ChatService();
                _ = Task.Run(() => _chatService.StartServer(msg =>
                    Dispatcher.Invoke(() => ChatListBox.Items.Add(msg))));

                _notificationService = new NotificationService();
                _ = Task.Run(() => _notificationService.StartListening(msg =>
                    Dispatcher.Invoke(() =>
                        MessageBox.Show(msg, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information))));
            }
        }

        private void OnShowNotification(object? sender, string message)
        {
            Dispatcher.Invoke(() => MessageBox.Show(message, "Информация", MessageBoxButton.OK, MessageBoxImage.Information));
        }

        private void OnShowGradeDialog(object? sender, (string studentName, Action<string, int, DateTime> callback) data)
        {
            Dispatcher.Invoke(() =>
            {
                var dialog = new AddEditGradeDialog(data.studentName, "", 5, DateTime.Today, data.callback);
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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window1_Closed(object? sender, EventArgs e)
        {
        }
    }
}