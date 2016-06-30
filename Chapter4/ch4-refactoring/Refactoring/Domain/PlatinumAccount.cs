﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PlatinumAccount : AccountBase
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            int points;
            points = (int)decimal.Ceiling((amount / PlatinumBalanceCostPerPoint) + (amount / PlatinumTransactionCostPerPoint));
            return Math.Max(points, 0);
        }

        private const int PlatinumTransactionCostPerPoint = 2;
        private const int PlatinumBalanceCostPerPoint = 1000;

    }
}
