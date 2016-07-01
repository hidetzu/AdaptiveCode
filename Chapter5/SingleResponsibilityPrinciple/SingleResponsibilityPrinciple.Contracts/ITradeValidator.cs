using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Contracts
{
    public interface ITradeValidator
    {
        bool Validate(string[] fields, int currentLine);
    }
}
