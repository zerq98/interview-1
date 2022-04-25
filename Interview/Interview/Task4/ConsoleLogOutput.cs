using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Task4
{
    internal class ConsoleLogOutput : ILogOutput
    {
        public void Save(string serializedLog)
        {
            Console.WriteLine(serializedLog);
        }
    }
}
