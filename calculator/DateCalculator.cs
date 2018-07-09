using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.Contracts;

namespace calculator
{
    class DateCalculator : BaseCalculator, IDateCalculator
    {
        public void InitialData(DateTime initData)
        {
            _initialDate = initData;
        }

        public double substract(DateTime t)
        {
            return (_initialDate - t).TotalDays;
        }
    }

}
