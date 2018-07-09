using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public abstract class  BaseCalculator
    {
        
        public double _initialData { get; set; }
        public DateTime _initialDate = DateTime.Now;        
        public List<string> _memoryList = new List<string>();

        public void _cleanLast()
        {


        }
        public void _cleanAll()
        {

            _memoryList.Clear();
        }

        public void _addDataInMemory(string data)
        {
            _memoryList.Add(data);
        }

        


    }
}
