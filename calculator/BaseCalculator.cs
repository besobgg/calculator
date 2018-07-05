using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class BaseCalculator
    {
        
        public double _initialData = 0;
        public DateTime _initialDate = DateTime.Now;
        public List<string> _calculatorList = new List<string>();
        public List<string> _memoryList = new List<string>();

        public void _cleanLast()
        {


        }
        public void _cleanAll()
        {


        }

        public void _addDataInMemory(string data)
        {
            _memoryList.Add(data);
        }

        public void _addActionInMemory(string action)
        {

        }



    }
}
