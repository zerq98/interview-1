using System;
using System.Threading.Tasks;

namespace Interview.Task4
{
    public class Tester4
    {
        public void Test()
        {
            var fileLogOutput = new FileLogOutput("log.txt");
            var logger = new Logger(fileLogOutput);
            logger.LogAsXml(new LogEntry() { Message = "test", Tags = new[] { "t1", "t2" }, Timestamp = DateTime.UtcNow });

            var consoleLogOutput = new ConsoleLogOutput();
            logger = new Logger(consoleLogOutput);
            logger.LogAsJson(new LogEntry() { Message = "test", Tags = new[] { "t1", "t2" }, Timestamp = DateTime.UtcNow });
        }
    }
}
