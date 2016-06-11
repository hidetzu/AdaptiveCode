using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePrinter;

namespace SimpleDependency
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Class1();
            Console.ReadKey();
        }
    }
}
