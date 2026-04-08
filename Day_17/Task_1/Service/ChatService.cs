using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary.Services
{
    public class ChatService
    {
        public async Task SendMessage(string message)
        {
            using var client = new NamedPipeClientStream(".", "chatPipe", PipeDirection.Out);
            await client.ConnectAsync();

            using var writer = new StreamWriter(client, Encoding.UTF8);
            await writer.WriteLineAsync(message);
            await writer.FlushAsync();
        } 

        public async Task StartServer(System.Action<string> onMessage)
        {
            while (true)
            {
                using var server = new NamedPipeServerStream("chatPipe", PipeDirection.In);
                await server.WaitForConnectionAsync();

                using var reader = new StreamReader(server, Encoding.UTF8);
                var message = await reader.ReadLineAsync();

                if (!string.IsNullOrEmpty(message))
                {
                    onMessage(message);
                }
            }
        }
    }
}