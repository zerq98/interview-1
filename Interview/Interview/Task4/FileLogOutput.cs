using System.IO;

namespace Interview.Task4
{
    internal class FileLogOutput:ILogOutput
    {
        private string path;

        public FileLogOutput(string filePath)
        {
            this.path = filePath;
        }

        public void Save(string serializedLog)
        {
            File.WriteAllText(@path, serializedLog);
        }
    }
}