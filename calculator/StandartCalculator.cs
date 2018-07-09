using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.Contracts;

namespace calculator
{
   public  class StandartCalculator : BaseCalculator,IStandartCalculator
    {
       
        
        public void InitialData(double initData)
        {
            _initialData = initData;
            _memoryList.Add(initData.ToString());
        }

        public double ReturnSum()
        {
            return _initialData;
            _memoryList.Clear();
        }

        public double substract(double t)
        {
           
            _memoryList.Add("-");
            _memoryList.Add(t.ToString());
            _initialData = _initialData - t;
            return _initialData;
            
        }
               
    }


}
