using SingleResponsibilityPrinciple.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message, params object[] args)
        {
            Console.WriteLine(string.Concat("ERROR: ", string.Format(message, args)));
        }

        public void LogInfo(string message, params object[] args)
        {
            Console.WriteLine(string.Concat("INFO: ", string.Format(message, args)));
        }

        public void LogWarning(string message, params object[] args)
        {
            Console.WriteLine(string.Concat("WARN: ", string.Format(message, args)));
        }
    }
}
