using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SingleResponsibilityPrinciple.Contracts;


namespace SingleResponsibilityPrinciple
{
    public class TradeProcessor
    {
        private ITradeDataProvider iTradeDataProvider;

        public TradeProcessor(ITradeDataProvider iTradeDataProvider,
            ITradeParser iTradeParser,
            ITradeStore iTradeStore
            )
        {
            this.iTradeDataProvider = iTradeDataProvider;
            this.iTradeParser = iTradeParser;
            this.iTradeStore = iTradeStore;
        }

        public void ProcessTrades()
        {
            var lines = iTradeDataProvider.GetTradeData();
            var trades = iTradeParser.Parser(lines);
            iTradeStore.Store(trades);
        }

        private readonly ITradeParser iTradeParser;
        private readonly ITradeStore iTradeStore;
    }
}
