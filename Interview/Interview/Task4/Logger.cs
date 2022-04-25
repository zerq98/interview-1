using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Interview.Task4
{
    public class Logger : ILogger
    {
        private readonly ILogOutput _logOutput;

        public Logger(ILogOutput logOutput)
        {
            _logOutput = logOutput;
        }

        public void LogAsJson(LogEntry logEntry)
        {
            var serializedLogEntry = JsonSerializer.Serialize(logEntry);
            _logOutput.Save(serializedLogEntry);
        }

        public void LogAsOtherFormat(string serializedLogEntry)
        {
            _logOutput.Save(serializedLogEntry);
        }

        public void LogAsXml(LogEntry logEntry)
        {
            var serializer = new XmlSerializer(typeof(LogEntry));
            var stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, logEntry);
            var serializedLogEntry = stringWriter.ToString();
            _logOutput.Save(serializedLogEntry);
        }
    }
}
