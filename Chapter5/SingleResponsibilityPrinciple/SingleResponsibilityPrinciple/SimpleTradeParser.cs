using SingleResponsibilityPrinciple.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class SimpleTradeParser : ITradeParser
    {
        public SimpleTradeParser(ITradeValidator iTradeValidator, ITradeMapper iTradeMapper)
        {
            this.iTradeValidator = iTradeValidator;
            this.iTradeMapper = iTradeMapper;
        }

        public IEnumerable<TradeRecord> Parser(IEnumerable<string> tradeData)
        {
            var trades = new List<TradeRecord>();

            var lineCount = 1;
            foreach (var line in tradeData)
            {
                var fields = line.Split(new char[] { ',' });

                if (!iTradeValidator.Validate(fields, lineCount))
                    continue;

                TradeRecord trade = iTradeMapper.Map(fields);

                trades.Add(trade);

                lineCount++;
            }

            return trades;
        }

        private ITradeValidator iTradeValidator;
        private ITradeMapper iTradeMapper;
    }
}
