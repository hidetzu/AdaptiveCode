using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BronzeAccount : AccountBase
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            int points;
            points = (int)decimal.Floor(amount / BronzeTransactionCostPerPoint);
            return Math.Max(points, 0);
        }

        private const int BronzeTransactionCostPerPoint = 20;
    }
}
