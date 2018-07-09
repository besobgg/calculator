using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Contracts
{
    interface IStandartCalculator :  ISubstractable<double, double>, IReturnSum, IInitialdata<double>
    {
        double _initialData { get; set; }


    }
}
