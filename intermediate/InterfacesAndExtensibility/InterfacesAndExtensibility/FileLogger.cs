using System.IO;

namespace InterfacesAndExtensibility
{
    public class FileLogger : ILogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }

        public void LogError(string message)
        {
            Log(message, MessageType.Error);
        }

        public void LogInfo(string message)
        {
            Log(message, MessageType.Info);
        }

        private void Log(string message, MessageType messageType)
        {
            // a file resource is not managed by the CLR, this means that we have to
            // dispose that resource once we finish using it.
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(messageType.ToString().ToUpper() + ": " + message);
            }
        }
    }
}
