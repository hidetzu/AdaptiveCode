using SingleResponsibilityPrinciple.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class SimpleTradeValidator : ITradeValidator
    {
        public SimpleTradeValidator(ILogger log)
        {
            this.Logger = log;
        }


        public bool Validate(string[] fields, int currentLine)
        {
            if (fields.Length != 3)
            {
                Logger.LogWarning("Line {0} malformed. Only {1} field(s) found.", currentLine, fields.Length);
                return false;
            }

            if (fields[0].Length != 6)
            {
                Logger.LogWarning("Trade currencies on line {0} malformed: '{1}'", currentLine, fields[0]);
                return false;
            }

            int tradeAmount;
            if (!int.TryParse(fields[1], out tradeAmount))
            {
                Logger.LogWarning("Trade amount on line {0} not a valid integer: '{1}'", currentLine, fields[1]);
                return false;
            }

            decimal tradePrice;
            if (!decimal.TryParse(fields[2], out tradePrice))
            {
                Logger.LogWarning("Trade price on line {0} not a valid decimal: '{1}'", currentLine, fields[2]);
                return false;
            }

            return true;
        }

        private ILogger Logger;
    }
}
