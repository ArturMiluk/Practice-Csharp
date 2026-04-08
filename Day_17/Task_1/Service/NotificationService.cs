using System.IO.MemoryMappedFiles;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary.Services
{
    public class NotificationService
    {
        public void SendNotification(string message)
        {
            using var mmf = MemoryMappedFile.CreateOrOpen("notif", 1024);
            using var stream = mmf.CreateViewStream();
            var bytes = Encoding.UTF8.GetBytes(message);
            stream.Write(bytes, 0, bytes.Length);
        }

        public async Task StartListening(System.Action<string> onMessage)
        {
            while (true)
            {
                using var mmf = MemoryMappedFile.OpenExisting("notif");
                using var stream = mmf.CreateViewStream();

                byte[] buffer = new byte[1024];
                int read = await stream.ReadAsync(buffer, 0, buffer.Length);

                if (read > 0)
                {
                    string msg = Encoding.UTF8.GetString(buffer, 0, read);
                    onMessage(msg);
                }

                await Task.Delay(1000);
            }
        }
    }
}