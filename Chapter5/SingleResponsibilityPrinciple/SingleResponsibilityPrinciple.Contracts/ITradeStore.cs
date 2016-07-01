using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Contracts
{
    public interface ITradeStore
    {
        void Store(IEnumerable<TradeRecord> trades);
    }
}
