using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDecorate
{
    public class TodayIsAnEvenDayOfTheMonthPredicate : IPredicate
    {
        private readonly DataTester dataTester;

        public TodayIsAnEvenDayOfTheMonthPredicate(DataTester dataTester)
        {
            this.dataTester = dataTester;
        }

        public bool Test()
        {
            return dataTester.TodayIsAnEvenDayOfTheMonth;
        }
    }
}
