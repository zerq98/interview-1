namespace Interview.Task4
{
    public interface ILogger
    {
        void LogAsJson(LogEntry logEntry);
        void LogAsXml(LogEntry logEntry);
        void LogAsOtherFormat(string serializedLogEntry);
    }
}
