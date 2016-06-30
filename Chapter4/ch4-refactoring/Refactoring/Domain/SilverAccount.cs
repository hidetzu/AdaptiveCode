using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class SilverAccount : AccountBase
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            int points = (int)decimal.Floor(amount / SilverTransactionCostPerPoint);
            return Math.Max(points, 0);
        }

        private const int SilverTransactionCostPerPoint = 10;
    }
}