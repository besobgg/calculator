using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.Contracts;

namespace calculator
{
    class StandartCalculator : BaseCalculator, ISubstractable<int, double>, ISubstractable<double, double>,IReturnSum,IInitialdata<double>
    {
        public void InitialData(double initData)
        {
            _initialData = initData;
        }

        public double ReturnSum()
        {
            return _initialData;
        }

        public double substract(double t)
        {


            _calculatorList.Add( t.ToString());
            _calculatorList.Add("-");
            _initialData = _initialData - t;
            return _initialData;


        }

        public double substract(int t)
        {
            _calculatorList.Add(t.ToString());
            _calculatorList.Add("-");
            _initialData = _initialData - t;
            return _initialData;
        }
    }


}
