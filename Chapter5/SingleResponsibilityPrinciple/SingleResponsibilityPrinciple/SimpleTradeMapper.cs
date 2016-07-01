using SingleResponsibilityPrinciple.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class SimpleTradeMapper : ITradeMapper
    {
        private ILogger Log;

        public SimpleTradeMapper(ILogger log)
        {
            this.Log = log;
        }

        public TradeRecord Map(string[] fileds)
        {
            var sourceCurrencyCode = fileds[0].Substring(0, 3);
            var destinationCurrencyCode = fileds[0].Substring(3, 3);
            var tradeAmount = int.Parse(fileds[1]);
            var tradePrice = decimal.Parse(fileds[2]);

            // calculate values
            var trade = new TradeRecord
            {
                SourceCurrency = sourceCurrencyCode,
                DestinationCurrency = destinationCurrencyCode,
                Lots = tradeAmount / LotSize,
                Price = tradePrice
            };
            return trade;
        }

        private static float LotSize = 100000f;
    }
}
