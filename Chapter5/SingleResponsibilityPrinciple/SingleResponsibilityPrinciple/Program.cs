using SingleResponsibilityPrinciple;
using SingleResponsibilityPrinciple.AdoNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var tradeStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SingleResponsibilityPrinciple.trades.txt");

            var tradeDataProvider = new StreamTradeDataProvider(tradeStream);

            var logger = new ConsoleLogger(); 
            var tradeValidator = new SimpleTradeValidator(logger);
            var tradeMapper = new SimpleTradeMapper(logger);
            var tradeParser = new SimpleTradeParser(tradeValidator, tradeMapper);

            var tradeStore = new AdoNetTradeStore(logger);

            var tradeProcessor = new TradeProcessor(tradeDataProvider, tradeParser, tradeStore);
            tradeProcessor.ProcessTrades();

            Console.ReadKey();
        }
    }
}
