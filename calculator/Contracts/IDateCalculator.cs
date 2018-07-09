using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Contracts
{
    interface IDateCalculator : ISubstractable<DateTime, double>, IInitialdata<DateTime>
    {
    }
}
