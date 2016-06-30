using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GoldAccount : AccountBase
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            int points;
            points = (int)decimal.Ceiling((amount / GoldBalanceCostPrePoint) + (amount / GoldTransactionCostPerPoint));
            return Math.Max(points, 0);
        }

        private const int GoldTransactionCostPerPoint = 5;
        private const int GoldBalanceCostPrePoint = 2000;

    }
}
